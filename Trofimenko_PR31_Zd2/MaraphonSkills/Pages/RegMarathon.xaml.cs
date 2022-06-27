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
    /// Логика взаимодействия для RegMarathon.xaml
    /// </summary>
    public partial class RegMarathon : Page
    {
        int price;
        int fundMoney;
        int marathonid = 0;
        string racekitoption = "";
        MarathonEntities db = new MarathonEntities();
        public RegMarathon() //int _id
        {
            InitializeComponent();
            //   id = _id;
            db = new MarathonEntities();
            List<Core.Sponsor> sponsor = db.Sponsor.ToList();
            chxb_vznos.ItemsSource = sponsor;
            txt_price.Text = "";

        }

        private void btn_reg_Click(object sender, RoutedEventArgs e)
        {
            if (chxb_vznos.SelectedItem != null)
            {
                if(check_full.IsChecked == false && check_half.IsChecked == false && check_min.IsChecked == false)
                {
                    MessageBox.Show("Не выбран вид марафона!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                else
                {
                    if(radio_a.IsChecked == false && radio_b.IsChecked == false && radio_c.IsChecked == false)
                    {
                        MessageBox.Show("Не выбран вариант комплектов!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                    else
                    {
                        try
                        {
                            RunnerMarathon run = new RunnerMarathon(); //записываем на марафон
                            run.Position = 0;
                            run.Time = null;
                            run.MarathonId = db.user3.Where(x => x.MarathonId == marathonid).First().MarathonId;
                            run.RunnerId = db.Runner.Where(x => x.User.Email == Properties.Settings.Default.currentUserEmail).First().RunnerId;
                            db.RunnerMarathon.Add(run);
                            db.SaveChanges();


                            Registration reg = new Registration(); //регистрируем нового участника марафона
                            reg.RunnerId = db.Runner.Where(x => x.User.Email == Properties.Settings.Default.currentUserEmail).First().RunnerId;
                            reg.RegistrationDateTime = DateTime.Now;
                            reg.RaceKitOptionId = db.RaceKitOption.Where(x => x.RaceKitOption1 == racekitoption).First().RaceKitOptionId;
                            reg.RegistrationStatusId = 1;
                            reg.Cost = price;
                            reg.CharityId = 1;
                            reg.SponsorshipTarget = "спонсорство";

                            db.Registration.Add(reg);
                            db.SaveChanges();


                            Sponsorship sponsorstvo = new Sponsorship(); //кто кого спонсирует
                            sponsorstvo.SponsorshipName = "спонсорство";
                            sponsorstvo.RegistrationId = db.Registration.Where(x => x.Cost == price && x.RunnerId == reg.RunnerId).First().RegistrationId;
                            sponsorstvo.Amount = price;


                            db.Sponsorship.Add(sponsorstvo);
                            db.SaveChanges();
                            this.NavigationService.Navigate(new RunnerRegistrationConfirmationPage());
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("По выбранным параметрам на данный момент не проводятся марафоны!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
            }

            else
            {
                MessageBox.Show("Не выбран взнос!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void check_min_Checked(object sender, RoutedEventArgs e)
        {
            price = 20;
            txt_price.Text = Convert.ToString(price);
            check_half.IsChecked = false;
            check_full.IsChecked = false;
            marathonid = 1;
        }

        private void check_half_Checked(object sender, RoutedEventArgs e)
        {
            price = 75;
            txt_price.Text = Convert.ToString(price);
            check_min.IsChecked = false;
            check_full.IsChecked = false;
            marathonid = 2;
        }

        private void check_full_Checked(object sender, RoutedEventArgs e)
        {
            price = 145;
            txt_price.Text = Convert.ToString(price);
            check_min.IsChecked = false;
            check_half.IsChecked = false;
            marathonid = 3;
        }

        private void radio_a_Checked(object sender, RoutedEventArgs e)
        {
            price += 0;
            txt_price.Text = Convert.ToString(price);
            racekitoption = "bib+bracelet";
        }

        private void radio_b_Checked(object sender, RoutedEventArgs e)
        {
            price += 20;
            txt_price.Text = Convert.ToString(price);
            racekitoption = "bib+bracelet+hat+waterbootle";
        }

        private void radio_c_Checked(object sender, RoutedEventArgs e)
        {
            price += 45;
            txt_price.Text = Convert.ToString(price);
            racekitoption = "bib+bracelet+hat+waterbootle+T-shirt";
        }

        private void check_full_Unchecked(object sender, RoutedEventArgs e)
        {         
            if (check_full.IsChecked == false && check_half.IsChecked == false && check_min.IsChecked == false)
            {
                price = 0;
            }
            txt_price.Text = Convert.ToString(price);
        }

        private void check_half_Unchecked(object sender, RoutedEventArgs e)
        {           
            if (check_full.IsChecked == false && check_half.IsChecked == false && check_min.IsChecked == false)
            {
                price = 0;
            }
            txt_price.Text = Convert.ToString(price);
        }

        private void check_min_Unchecked(object sender, RoutedEventArgs e)
        {           
            if (check_full.IsChecked == false && check_half.IsChecked == false && check_min.IsChecked == false)
            {
                price = 0;
            }
            txt_price.Text = Convert.ToString(price);
        }

        private void radio_a_Unchecked(object sender, RoutedEventArgs e)
        {
            price -= 0;
            txt_price.Text = Convert.ToString(price);
        }

        private void radio_b_Unchecked(object sender, RoutedEventArgs e)
        {
            price -= 20;
            txt_price.Text = Convert.ToString(price);
        }

        private void radio_c_Unchecked(object sender, RoutedEventArgs e)
        {
            price -= 45;
            txt_price.Text = Convert.ToString(price);
        }

        private void chxb_vznos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Core.Sponsor f = (Core.Sponsor)chxb_vznos.SelectedItem;
            txb_price.Text = f.Amount.ToString();
        }
    }
}
    

