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

namespace PanelProject.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для TaskFirstPage.xaml
    /// </summary>
    public partial class ButtonPage : Page
    {
        string[] programmingLanguages = { "Java", "C#", "PHP", "GO", "Kotlon", "C++" };
        public ButtonPage()
        {
            InitializeComponent();
            GenerateList();

        }
        /// <summary>
        /// Формирование списка кнопок
        /// </summary>
        private void GenerateList()
        {
            foreach (var item in programmingLanguages)
            {
                Button activeButton = new Button
                {
                    Content = item,
                    FontWeight = FontWeights.Bold,
                    Background = Brushes.Blue,
                    Foreground = Brushes.White,
                    Margin = new Thickness(3),
                    Padding = new Thickness(3),
                };

                ProgrammStackPanel.Children.Add(activeButton);
                activeButton.Click += ActiveButtonClick;
            }
        }

    
        /// <summary>
        /// Вывод информации о выбранном языке      
        /// </summary>
        private void ActiveButtonClick(object sender, RoutedEventArgs e)
        {
            Button activeButton = (Button)sender;
            foreach (Button item in ProgrammStackPanel.Children)
            {
                item.Background = Brushes.Blue;
            }
            activeButton.Background = Brushes.LightBlue;
            MessageBox.Show($"Выбран язык '{activeButton.Content}'");
        }
    }
}
