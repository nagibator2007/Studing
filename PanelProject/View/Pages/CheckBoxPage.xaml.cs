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
    /// Логика взаимодействия для CheckAndRadioButtonPage.xaml
    /// </summary>
    public partial class CheckBoxPage : Page
    {
        string[] programmingLanguages = { "Java", "C#", "PHP", "Python", "Go", "Kotlin", "C++" };
        List<string> arrayList = new List<string>();
        public CheckBoxPage()
        {
            InitializeComponent();
            GenerateList();
        }
        /// <summary>
        /// Формирование списка переключателей
        /// </summary>
        private void GenerateList()
        {
            //Очищаем список
            ProgrammStackPanel.Children.Clear();
            //Заполняем список
            foreach (var item in programmingLanguages)
            {
                CheckBox activeCheckBox = new CheckBox
                {
                    Content = item,
                    FontWeight = FontWeights.Bold,
                    Margin = new Thickness(3),
                    Padding = new Thickness(3),
                };
                ProgrammStackPanel.Children.Add(activeCheckBox);
                activeCheckBox.Checked += ActiveCheckBox_Checked;
                activeCheckBox.Unchecked += ActiveCheckBox_Unchecked;
                
                
                
                
            }
        }
         /// <summary>
        /// Добавление элемента в массив при выборе "флажка"
        /// </summary>
        private void ActiveCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox activeElement = (CheckBox)sender;
            if (!arrayList.Contains(activeElement.Content))
            {
                arrayList.Add(activeElement.Content.ToString());
            }
        }
 
        /// <summary>
        /// Удаление элемента из массива при "Отключении" флажка
        /// </summary>

        private void ActiveCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox activeElement = (CheckBox)sender;
            if (arrayList.Contains(activeElement.Content.ToString()))
            {
                arrayList.Remove(activeElement.Content.ToString());
            }
        }

     
        /// <summary>
        /// Вывод списка выбранных языков программирования
        /// </summary>
        private void ResultButtonClick(object sender, RoutedEventArgs e)
        {
            if(arrayList.Count() == 0)
            {
                MessageBox.Show($"Вы не знаете языков программирования?");

            }
            else
            {
                string resultString = String.Empty;
                resultString = String.Join(",", arrayList);
                MessageBox.Show($"Вы выбрали языки:\n{resultString}");

            }
        }
    }
}
