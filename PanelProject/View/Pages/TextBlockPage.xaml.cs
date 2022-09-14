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
    /// Логика взаимодействия для TextBlockPage.xaml
    /// </summary>
    public partial class TextBlockPage : Page
    {
        public TextBlockPage()
        {
            InitializeComponent();
            ShowLetters();
        }
        /// <summary>
        /// Формирование списка букв
        /// </summary>
         private void ShowLetters()
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                TextBlock letter = new TextBlock
                {
                    Text = i.ToString(),
                    FontWeight = FontWeights.Bold,
                    Background = Brushes.Blue,
                    Foreground = Brushes.White,
                    Margin = new Thickness(3),
                    Padding = new Thickness(3),
                    Width = 20,
                    TextAlignment   = TextAlignment.Center
                };
                letter.MouseLeftButtonDown += Letter_MouseLeftButtonDown;
                ProgrammStackPanel.Children.Add(letter);
            }
        }

        private void Letter_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock activeElement = (TextBlock)sender;
            foreach (TextBlock letter in ProgrammStackPanel.Children)
            {
                letter.Foreground = Brushes.White;

            }
            activeElement.Foreground = Brushes.Red;
        }
    }
}
