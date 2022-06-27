using MaraphonSkills.Core;
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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MaraphonSkills.Pages
{
    /// <summary>
    /// Логика взаимодействия для ImportVolunteers.xaml
    /// </summary>
    public partial class ImportVolunteers : Page
    {
        Core.MarathonEntities context;
        List<Volunteer> vol2 = new List<Volunteer>();
        public ImportVolunteers()
        {
            InitializeComponent();
            context = new Core.MarathonEntities();
        }

        private void btnAddInBd_Click(object sender, RoutedEventArgs e)
        {
            Volunteer volbd = new Volunteer();
            foreach (var vol in vol2)
            {
                volbd.CountryCode = vol.CountryCode;
                volbd.FirstName = vol.FirstName;
                volbd.LastName = vol.LastName;
                volbd.Gender = vol.Gender;
                volbd.Email = vol.Email;
            }

            context.Volunteer.Add(volbd);
            context.SaveChanges();


            this.NavigationService.Navigate(new Uri("VolunteerManagement.xaml", UriKind.Relative));
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("VolunteerManagement.xaml", UriKind.Relative));
        }

        private void btnOpenFolder_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.FilterIndex = 1;
            open.Filter = "csv|*.csv";

            if (open.ShowDialog() == DialogResult.OK)
            {
                var lines = File.ReadAllLines(open.FileName);

                var data = from l in lines.Skip(1)
                           let split = l.Split(',')
                           select new Volunteer
                           {
                               FirstName = split[0],
                               LastName = split[1],
                               CountryCode = split[2],
                               Gender = split[3],
                               Email = split[4]
                           };
                vol2 = data.ToList();


                txbFilePath.Text = open.FileName.ToString();
            }
        }

    }
}
