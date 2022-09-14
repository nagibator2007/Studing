using PanelProject.View.Pages;
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

namespace PanelProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new ButtonPage());       
        }

       /// <summary>
       /// Открытие страницы "О кнопках"
       /// </summary>
        private void InfoButtonClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ButtonPage());
        }
        /// <summary>
        /// Открытие страницы "О переключателях"
        /// </summary>
        private void RadioInfoButtonClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new RadioButtonPage());
        }
        /// <summary>
        /// Открытие страницы "О флажках"
        /// </summary>
        private void CheckBoxButtonClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CheckBoxPage());
        }
        /// <summary>
        /// Открытие страницы "О текстовых блоках"
        /// </summary>
        private void TextBlockButtonClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TextBlockPage());
        }
        /// <summary>
        /// Открытие страницы "О полях для ввода текста и пароля"
        /// </summary>
        private void TextBoxAndPasswordButtonClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TextAndPasswordPage());
        }
        /// <summary>
        /// Открытие страницы "О выпадающих списках"
        /// </summary>
        private void ComboBoxButtonClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ComboBoxPage());
        }
        /// <summary>
        /// Открытие страницы "О списках"
        /// </summary>
        private void ListBoxButtonClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListBoxPage());
        }
        /// <summary>
        /// Открытие страницы "О ползунках"
        /// </summary>
        private void SliderButtonClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SliderPage());
        }
        /// <summary>
        /// Открытие страницы "Об элементах управления для работы с датой"
        /// </summary>
        private void CalendarAndDatePickerButtonClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CalendarAndDatePickerPage());
        }
        /// <summary>
        /// Открытие страницы "Об изображениях"
        /// </summary>
        private void ImageButtonClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ImagePage());
        }
        /// <summary>
        /// Изменение внешнего вида приложения при загрузке страницы во фрейм
        /// </summary>
        private void MainFrameNavigated(object sender, NavigationEventArgs e)
        {

        }
        /// <summary>
        /// Закрытие окна
        /// </summary>
        private void ExitButtonClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


    }
}
