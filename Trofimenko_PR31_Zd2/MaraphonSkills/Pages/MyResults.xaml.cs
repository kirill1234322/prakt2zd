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
    /// Логика взаимодействия для MyResults.xaml
    /// </summary>
    public partial class MyResults : Page
    {
        public class Fordatagrid
        {
            public string runfio { get; set; }
            public int? position { get; set; }
            public TimeSpan? time { get; set; }
            public string strana { get; set; }
        }
        Core.MarathonEntities context;
        string email;
        public MyResults(string _email)
        {
            email = _email;
            context = new Core.MarathonEntities();
            InitializeComponent();
            var genderclass = context.Runner.Where(x => x.Email == email).FirstOrDefault();
            var gender = genderclass.Gender;
            txt_gender.Text = gender.ToString();
            DateTime birth = (DateTime)context.Runner.Where(x => x.Email == email).Select(x => x.DateOfBirth).SingleOrDefault();
            DateTime date = DateTime.Now;
            TimeSpan d = date - birth;
            if ((d.Days / 365) <= 18 && (d.Days / 365) > 29)
            {
                txt_age.Text = "18-29";
            }
            if ((d.Days / 365) <= 29 && (d.Days / 365) > 36)
            {
                txt_age.Text = "27-36";
            }
            if ((d.Days / 365) <= 36 && (d.Days / 365) > 49)
            {
                txt_age.Text = "36-49";
            }


          
            List<Fordatagrid> local = new List<Fordatagrid>();
            foreach (var item in context.RunnerMarathon.Where(x=>x.Runner.Email== email).ToList())
            {   
                if(item.Position>0)
                    local.Add(new Fordatagrid()
                    {
                        runfio = item.Runner.RunnerFIO,
                        position = item.Position,
                        time = item.Time,
                        strana = item.user3.Country.CountryName
                    });

                
            }

            grid_Results.ItemsSource = local;
            //   grid_Results.ItemsSource = db.StatisticsMarathon.Where(x => x.ID_User == id).ToList();
        }

        private void btn_showallresults_Click(object sender, RoutedEventArgs e)
        {
            PerviousResult pr = new PerviousResult();
            NavigationService.Navigate(pr);
        }
    }
}
