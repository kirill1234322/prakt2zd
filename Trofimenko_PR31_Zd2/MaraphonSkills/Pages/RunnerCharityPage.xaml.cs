using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для RunnerCharityPage.xaml
    /// </summary>
    public partial class RunnerCharityPage : Page
    {
        Core.MarathonEntities context;
        public RunnerCharityPage()
        {
            context = new Core.MarathonEntities();
            InitializeComponent();

            CharityComboBox.ItemsSource = context.Charity.ToList();
            CharityComboBox.SelectedValuePath = "CharityId";
            CharityComboBox.DisplayMemberPath = "CharityName";

            GetCharityInfo(1);
        }
        private void GetCharityInfo(int charityId)
        {
            context = new Core.MarathonEntities();
            
                CharityNameLabel.Content = context.Charity.Where(x => x.CharityId == charityId).First().CharityName;
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.StreamSource = new MemoryStream(context.Charity.Where(x => x.CharityId == charityId).FirstOrDefault().Logo);
                image.EndInit();
                CharityLogoImage.Source = image;
                CharityDescriptionTextBlock.Text = context.Charity.Where(x => x.CharityId == charityId).FirstOrDefault().CharityDescription;
                
            int donationAmount = 0;
            if (CharityComboBox.SelectedValue != null)
            {
                CharityItemsControl.ItemsSource = context.Sponsor.Where(x => x.CharityId == charityId && x.Runner.Email == Properties.Settings.Default.currentUserEmail).ToList();
                foreach (var item in context.Sponsor.Where(x => x.CharityId == charityId && x.Runner.Email == Properties.Settings.Default.currentUserEmail).ToList())
                {

                    donationAmount += Convert.ToInt32(item.Amount);
                }
            }
            else
            {
                CharityItemsControl.ItemsSource = context.Sponsor.Where(x => x.Runner.Email == Properties.Settings.Default.currentUserEmail).ToList();
                foreach (var item in context.Sponsor.Where(x => x.Runner.Email == Properties.Settings.Default.currentUserEmail))
                {
                    donationAmount += Convert.ToInt32(item.Amount);
                }
            }
                //donationAmount = Convert.ToInt32(context.Sponsor.Where(x => x.Runner.Email == Properties.Settings.Default.currentUserEmail));
                
                DonationAmount.Content = String.Format("Всего: ${0}",donationAmount);

            
        }

        private void CharityComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GetCharityInfo(Convert.ToInt32(CharityComboBox.SelectedValue));
        }
    }
}
