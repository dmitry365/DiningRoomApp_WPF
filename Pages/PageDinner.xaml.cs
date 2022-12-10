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

namespace DiningRoomApp
{
    /// <summary>
    /// Логика взаимодействия для PageDinner.xaml
    /// </summary>
    public partial class PageDinner : Page
    {
        int SummaDinner;
        public PageDinner()
        {
            InitializeComponent();
        }
        private void BasketFirst_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)BasketFirst.IsChecked)
            {
                SummaDinner += 80;
            }
            else if (SummaDinner != 0)
            {
                SummaDinner -= 80;
            }
        }
        private void BasketSecond_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)BasketSecond.IsChecked)
            {
                SummaDinner += 40;
            }
            else if (SummaDinner != 0)
            {
                SummaDinner -= 40;
            }
        }
        private void BasketThird_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)BasketThird.IsChecked)
            {
                SummaDinner += 50;
            }
            else if (SummaDinner != 0)
            {
                SummaDinner -= 50;
            }
        }
        private void BasketFourth_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)BasketFourth.IsChecked)
            {
                SummaDinner += 90;
            }
            else if (SummaDinner != 0)
            {
                SummaDinner -= 90;
            }
        }
        private void BasketFifth_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)BasketFifth.IsChecked)
            {
                SummaDinner += 85;
            }
            else if (SummaDinner != 0)
            {
                SummaDinner -= 85;
            }
        }
        private void BasketSixth_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)BasketSixth.IsChecked)
            {
                SummaDinner += 30;
            }
            else if (SummaDinner != 0)
            {
                SummaDinner -= 30;
            }
        }
        private void Button_Click_Pay(object sender, RoutedEventArgs e)
        {           
            if (SummaDinner != 0)
            {
                WindowPay windowPay = new WindowPay();
                windowPay.Result.Content = this.SummaDinner.ToString();
                windowPay.ShowDialog();
            }
        }
    }
}
