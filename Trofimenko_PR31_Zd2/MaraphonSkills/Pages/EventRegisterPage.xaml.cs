using MaraphonSkills.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MaraphonSkills.Pages
{
	/// <summary>
	/// Логика взаимодействия для EventRegisterPage.xaml
	/// </summary>
	public partial class EventRegisterPage : Page
	{
		private MainWindow MW { get; }
		Core.MarathonEntities context;

		private readonly string Email;
		private readonly string Password;
		private readonly string FirstName;
		private readonly string LastName;
		private readonly Gender Gender;
		private readonly string ImagePath;
		private readonly DateTime BirthDate;
		private readonly Country Country;

		private double allSum;
		private double AllSum
		{
			get => allSum;
			set
			{
				allSum = value;
				if (AllSumLabel != null)
					AllSumLabel.Content = $"${allSum}";
			}
		}

		public EventRegisterPage(MainWindow mw, string email, string pswd, string fName, string lName,
			Gender gender, string imgPath, DateTime birthDate, Country country)
		{
			InitializeComponent();
			MW = mw;
			//EmailTB, Password1PB, FirstNameTB, LastNameTB, GenderCB, SelectedImage, BirthDateDP, CountryCB
			(Email, Password, FirstName, LastName, Gender, ImagePath, BirthDate, Country) =
				(email, pswd, fName, lName, gender, imgPath, birthDate, country);

			context = new MarathonEntities();
			DataContext = context.Charity.ToList();
		}


		private void ShowCharityInfo(object sender, MouseButtonEventArgs e)
		{
			var charity = (Charity)CharityCB.SelectedItem;

			if (charity != null)
			{
				new CharityInfoWindow(charity.CharityName, $"/Resources/{charity.CharitiLogo}", charity.CharityDescription).ShowDialog();
			}
		}

		private void UpdateAllSum()
		{
			var sum = 0d;

			EventTypeCBs?.Children
				.OfType<CheckBox>()
				.ToList()
				.ForEach(x =>
				{
					if (x.IsChecked == true)
						sum += Convert.ToDouble(x.Tag);
				});

			ComplectsRBs?.Children
				.OfType<RadioButton>()
				.ToList()
				.ForEach(x =>
				{
					if (x.IsChecked == true)
						sum += Convert.ToDouble(x.Tag);
				});

			sum += Double.Parse(SumTB.Text);

			AllSum = sum;
		}

		private void NumberTB_PreviewTextInput(object sender, TextCompositionEventArgs e)
		{
			char inputSymbol = e.Text[0];
			e.Handled = !(char.IsDigit(inputSymbol) || inputSymbol == ',');
		}

		private void CheckBox_CheckedUnchecked(object sender, RoutedEventArgs e) => UpdateAllSum();

		private void SumTB_TextChanged(object sender, TextChangedEventArgs e)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(SumTB.Text) || Convert.ToDouble(SumTB.Text) < 0)
				{
					SumTB.Text = "0";
				}

				UpdateAllSum();
			}
			catch (FormatException) { }
		}

        private void CancelButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
			MW.MainFrame.GoBack();
		}

        private void RegistrationButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
			////НАЛИЧИЕ ДАННЫХ
			//EventTypeCBs
			var b1 = EventTypeCBs.Children.OfType<CheckBox>()
				.ToList()
				.Any(x => x.IsChecked == true);
			//CharityCB
			var b2 = CharityCB.SelectedItem != null;
			//ComplectsRBs
			var b3 = ComplectsRBs.Children.OfType<RadioButton>()
				.ToList()
				.Any(x => x.IsChecked == true);

			if (!(b1 && b2 && b3))
			{
				MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
				return;
			}

			RaceKitOption raceKit = null;
			if (OptionA.IsChecked == true) raceKit = context.RaceKitOption.ToList()[0];
			else
			if (OptionB.IsChecked == true) raceKit = context.RaceKitOption.ToList()[1];
			else
			if (OptionC.IsChecked == true) raceKit = context.RaceKitOption.ToList()[2];


			//Email, Password, FirstName, LastName, Gender, byte[] Photo, DateOfBirth, Country.CountryCode
			////TABLES: Registration, Runner, User
			context.User.Add(new User
			{
				Email = this.Email,
				Password = this.Password,
				FirstName = this.FirstName,
				LastName = this.LastName,
				Role = context.Role.First(x => x.RoleName == "R")
			});
			context.SaveChanges();

			var runner = new Runner
			{
				Email = this.Email,
				Gender1 = this.Gender,
				DateOfBirth = this.BirthDate,
				CountryCode = this.Country.CountryCode,
				Img = System.IO.File.ReadAllBytes(ImagePath)
			};
			context.Runner.Add(runner);
			context.SaveChanges();

			var registration = new Registration
			{
				RunnerId = context.Runner.ToList().Last().RunnerId,
				RegistrationDateTime = DateTime.Now,
				RaceKitOption = raceKit,
				RegistrationStatusId = context.RegistrationStatus.ToList()[0].RegistrationStatusId,
				Cost = (decimal)AllSum,
				CharityId = ((Charity)CharityCB.SelectedItem).CharityId,
				SponsorshipTarget = 0.ToString()
			};
			context.Registration.Add(registration);
			context.SaveChanges();

			MW.Auth(context.User.ToList().Last());
			MW.MainFrame.Navigate(new Pages.RunnerRegistrationConfirmationPage());
		}
    }
}
