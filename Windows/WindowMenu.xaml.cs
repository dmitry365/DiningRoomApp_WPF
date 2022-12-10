﻿using System;
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

namespace DiningRoomApp
{
    /// <summary>
    /// Логика взаимодействия для WindowMenu.xaml
    /// </summary>
    public partial class WindowMenu : Window
    {
        /// <summary>
        /// Инициализация окна
        /// </summary>
        public WindowMenu()
        {
            InitializeComponent();
            MainFrame.Navigate(new PageBreakfast());
            Manager.MainFrame = MainFrame;
            BtnBack.Visibility = Visibility.Hidden;
        }
        /// <summary>
        /// Скрытие кнопки Назад
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                BtnBack.Visibility = Visibility.Visible;
            }
            else
            {
                BtnBack.Visibility = Visibility.Hidden;
            }
        }
        /// <summary>
        /// Переход на страницу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Button_Click_Breakfast(object sender, RoutedEventArgs e)
        {          
            Manager.MainFrame.Navigate(new PageBreakfast());
        }
        /// <summary>
        /// Переход на страницу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Button_Click_Lunch(object sender, RoutedEventArgs e)
        {            
            Manager.MainFrame.Navigate(new PageLunch());           
        }
        /// <summary>
        /// Переход на страницу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Button_Click_Dinner(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PageDinner());
        }/// <summary>
         /// Кнопка, позволяющая перейти на предыдущую страницу
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
             Manager.MainFrame.GoBack();
        }
    }
}
