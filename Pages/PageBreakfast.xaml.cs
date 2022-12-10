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
    /// Логика взаимодействия для PageBreakfast.xaml
    /// </summary>
    public partial class PageBreakfast : Page
    {

        int SummaBreakfast;
        public PageBreakfast()
        {
            InitializeComponent();
        }
        private void BasketFirst_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)BasketFirst.IsChecked)
            {
                SummaBreakfast += 80;
            }
            else if (SummaBreakfast != 0)
            {
                SummaBreakfast -= 80;
            }
          
        }
        private void BasketSecond_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)BasketSecond.IsChecked)
            {
                SummaBreakfast += 50;
            }
            else if (SummaBreakfast != 0)
            {
                SummaBreakfast -= 50;
            }
       
        }
        private void BasketThird_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)BasketThird.IsChecked)
            {
                SummaBreakfast += 60;
            }
            else if (SummaBreakfast != 0)
            {
                SummaBreakfast -= 60;
            }
            
        }
        private void BasketFourth_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)BasketFourth.IsChecked)
            {
                SummaBreakfast += 120;
            }
            else if (SummaBreakfast != 0)
            {
                SummaBreakfast -= 120;
            }
            
        }
        private void BasketFifth_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)BasketFifth.IsChecked)
            {
                SummaBreakfast += 40;
            }
            else if (SummaBreakfast != 0)
            {
                SummaBreakfast -= 40;
            }
            
        }
        private void BasketSixth_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)BasketSixth.IsChecked)
            {
                SummaBreakfast += 30;
            }
            else if (SummaBreakfast != 0)
            {
                SummaBreakfast -= 30;
            }
            
        }
        private void Button_Click_Pay(object sender, RoutedEventArgs e)
        {
            if (SummaBreakfast != 0)
            {
                WindowPay windowPay = new WindowPay();
                windowPay.Result.Content = this.SummaBreakfast.ToString();
                windowPay.ShowDialog();
            }
            
        }
    }
}
