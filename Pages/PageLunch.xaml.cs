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
    /// Логика взаимодействия для PageLunch.xaml
    /// </summary>
    public partial class PageLunch : Page
    {
        int SummaLunch;
        public PageLunch()
        {
            InitializeComponent();
        }
        private void BasketFirst_Click(object sender, RoutedEventArgs e)
        {            
            if ((bool)BasketFirst.IsChecked)
            {
                SummaLunch += 140;
            }
            else if (SummaLunch != 0)
            {
                SummaLunch -= 140;
            }
        }
        private void BasketSecond_Click(object sender, RoutedEventArgs e)
        {           
            if ((bool)BasketSecond.IsChecked)
            {
                SummaLunch += 100;
            }
            else if (SummaLunch != 0)
            {
                SummaLunch -= 100;
            }
        }
        private void BasketThird_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)BasketThird.IsChecked)
            {
                SummaLunch += 120;
            }
            else if (SummaLunch != 0)
            {
                SummaLunch -= 120;
            }
        }
        private void BasketFourth_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)BasketFourth.IsChecked)
            {
                SummaLunch += 50;
            }
            else if (SummaLunch != 0)
            {
                SummaLunch -= 50;
            }
        }
        private void BasketFifth_Click(object sender, RoutedEventArgs e)
        {
            
            if ((bool)BasketFifth.IsChecked)
            {
                SummaLunch += 20;
            }
            else if (SummaLunch != 0)
            {
                SummaLunch -= 20;
            }
        }
        private void BasketSixth_Click(object sender, RoutedEventArgs e)
        {           
            if ((bool)BasketSixth.IsChecked)
            {
                SummaLunch += 80;
            }
            else if (SummaLunch != 0)
            {
                SummaLunch -= 80;
            }
        }
        private void Button_Click_Pay(object sender, RoutedEventArgs e)
        {          
            if (SummaLunch != 0)
            {
                WindowPay windowPay = new WindowPay();
                windowPay.Result.Content = this.SummaLunch.ToString();
                windowPay.ShowDialog();
                
            }
        }
    }
}
