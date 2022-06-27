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
    /// Логика взаимодействия для PerviousResult.xaml
    /// </summary>
    public partial class PerviousResult : Page
    {
        Core.MarathonEntities context = new Core.MarathonEntities();


        public class Fordatagrid
        {
            public string runfio { get; set; }
            public int? position { get; set; }
            public TimeSpan? time { get; set; }
            public string strana { get; set; }
        }

        public PerviousResult()
        {
            InitializeComponent();
            context = new Core.MarathonEntities();
            
            List<string> age = new List<string> { "18-27", "27-36", "36-49" };
          //  List<string> distance = new List<string> { "42km" };
            cmbMarathon.ItemsSource = context.user3.ToList();
            cmbDistance.ItemsSource = context.Distance.ToList();

            //List<Fordatagrid> local = new List<Fordatagrid>();

            //foreach (var item in context.RunnerMarathon.ToList())
            //{
            //    local.Add(new Fordatagrid()
            //    {
            //        runfio = item.Runner.RunnerFIO,
            //        position = item.Position,
            //        time = item.Time,
            //        strana = item.user3.Country.CountryName
            //    });
            //    txtRunnerAllCount.Text = local.Count.ToString();
            //}
            List<Fordatagrid> fordatagrids = new List<Fordatagrid>();
            foreach (var item in context.RunnerMarathon.ToList())
            {
                if (item.Position != 0 && item.Position < 5)
                    fordatagrids.Add(new Fordatagrid()
                    {
                        runfio = item.Runner.RunnerFIO,
                        position = item.Position,
                        time = item.Time,
                        strana = item.user3.Country.CountryName
                    });
                txtRunnerFinishCount.Text = fordatagrids.Count.ToString();
            }
            txtRunnerAllCount.Text = context.RunnerMarathon.ToList().Count.ToString();

            cmbGender.ItemsSource = context.Gender.Select(x => x.Gender1).ToList();
            cmbAge.ItemsSource = age;
            gridResult.ItemsSource = fordatagrids;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (cmbDistance.SelectedIndex != -1 && cmbMarathon.SelectedIndex == -1)//если дистанция выбрана
            {
                var distance = (cmbDistance.SelectedValue as Distance).MarathonId; //выбранный марафон по дистанции (связка)
                var aaa = context.RunnerMarathon.Where(y => y.user3.MarathonId == distance).ToList(); //получили раннеров по дистанции

                List<Fordatagrid> bind = new List<Fordatagrid>();

                foreach (var item in aaa)
                {
                    if (item.Position != 0 && item.Position < 5)
                        bind.Add(new Fordatagrid()
                    {
                        runfio = item.Runner.RunnerFIO,
                        position = item.Position,
                        time = item.Time,
                        strana = item.user3.Country.CountryName
                    });
                }
                gridResult.ItemsSource = bind;
            }
            if (cmbDistance.SelectedIndex == -1 && cmbMarathon.SelectedIndex != -1)//если марафон выбран
            {
                string marathon = (cmbMarathon.SelectedValue as user3).MarathonName; //выбранный марафон
                var aaa = context.RunnerMarathon.Where(y => y.user3.MarathonName == marathon).ToList();

                List<Fordatagrid> bind = new List<Fordatagrid>();

                foreach (var item in aaa)
                {
                    if (item.Position != 0 && item.Position < 5)
                        bind.Add(new Fordatagrid()
                    {
                        runfio = item.Runner.RunnerFIO,
                        position = item.Position,
                        time = item.Time,
                        strana = item.user3.Country.CountryName
                    });
                }
                gridResult.ItemsSource = bind;
            }


            if (cmbDistance.SelectedIndex != -1 && cmbMarathon.SelectedIndex != -1) //если выбрано всё
            {
                string marathon = (cmbMarathon.SelectedValue as user3).MarathonName; //выбранный марафон
                int distance = (cmbDistance.SelectedValue as Distance).MarathonId; //выбранная дистанция
                
                var aaa = context.RunnerMarathon.Where(y => y.user3.MarathonName == marathon && y.user3.MarathonId == distance).ToList();

                List<Fordatagrid> bind = new List<Fordatagrid>();

                foreach (var item in aaa)
                {
                    if (item.Position != 0 && item.Position < 5)
                        bind.Add(new Fordatagrid()
                    {
                        runfio = item.Runner.RunnerFIO,
                        position = item.Position,
                        time = item.Time,
                        strana = item.user3.Country.CountryName
                    });
                }


                gridResult.ItemsSource = bind;
            }
        }
    }
}
