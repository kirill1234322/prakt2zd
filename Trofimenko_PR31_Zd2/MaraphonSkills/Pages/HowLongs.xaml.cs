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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MaraphonSkills.Pages
{
    /// <summary>
    /// Логика взаимодействия для HowLongs.xaml
    /// </summary>
    public partial class HowLongs : Page
    {

        Core.MarathonEntities context;
        public HowLongs()
        {
            InitializeComponent();
            context = new Core.MarathonEntities();
            gridDistance.ItemsSource = context.HowLong.Where(x => x.Speed != null).ToList();
            gridSpeed.ItemsSource = context.HowLong.Where(x => x.Length != null).ToList();
        }

       
        private void gridDistance_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            HowLong element = gridDistance.SelectedValue as HowLong;
            if (element != null)
            {
                txtInfo2.Text = "Дистанция: " + Convert.ToString(element.Length);
                txtName2.Text = "По дистанции: " + element.Name;

                if (element.Image != null)
                    using (var stream = new MemoryStream(element.Image))
                    {
                        var decoder = BitmapDecoder.Create(stream, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
                        imgInfo.Source = decoder.Frames[0];
                    }
            }
            else
            {
                MessageBox.Show("Вы ничего не выбрали", "Ошибка");
            }
        }
        private void gridSpeed_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            HowLong element = gridSpeed.SelectedValue as HowLong;
            if (element != null)
            {
                txtInfo.Text = "Скорость: " + Convert.ToString(element.Speed);
                txtName.Text = "По скорости: " + element.Name;

                if (element.Image != null)
                    using (var stream = new MemoryStream(element.Image))
                    {
                        var decoder = BitmapDecoder.Create(stream, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
                        imgInfo.Source = decoder.Frames[0];
                    }
            }
            else
            {
                MessageBox.Show("Вы ничего не выбрали", "Ошибка");
            }
        }

    
    }
}
