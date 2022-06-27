using MaraphonSkills.Core.API;
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
    /// Логика взаимодействия для CharityPage.xaml
    /// </summary>
    public partial class CharityPage : Page
    {
        Core.MarathonEntities context;
        public CharityPage()
        {
            context = new Core.MarathonEntities();

            InitializeComponent();

          //  CharityItemsControl.ItemsSource = CharityAPI.GetCharityList();
        }
    }
}
