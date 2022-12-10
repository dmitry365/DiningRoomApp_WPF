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
using System.Windows.Shapes;
using System.IO;

namespace DiningRoomApp
{
    /// <summary>
    /// Логика взаимодействия для WindowPay.xaml
    /// </summary>
    public partial class WindowPay : Window
    {
        //инициализируем массив строк, включающий названия способа доставки и средства платежа
        string[] Delivery =
        {"В пункте выдачи",
         "Доставка на дом"        
        };
        string[] Pay =
        {"В пункте выдачи",
         "Доставка на дом"
        };

        public WindowPay()
        {
            InitializeComponent();
            int i;
            /*сгенерировать список 
            значениями из массива */
            for (i = 0; i < 2; i++)
            {
                ComboBoxDelivery.Items.Add(Delivery[i]);
                ComboBoxPay.Items.Add(Pay[i]);
            }
        }

        /// <summary>
        /// Вызов окна помощи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_help(object sender, RoutedEventArgs e)
        {
            WindowHelp windowHelp = new WindowHelp();
            windowHelp.ShowDialog();
            
        }
        /// <summary>
        /// Вызов окна печати
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_Print(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Функция в разработке", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
