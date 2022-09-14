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
    /// Логика взаимодействия для TaskSecondPage.xaml
    /// </summary>
    public partial class RadioButtonPage : Page
    {
        RadioButton activeElement;
        List<string> programmingLanguages = new
            List<string>()
        { "Java", "C#", "PHP", "Go", "Kotlon", "C++"};
        
        public RadioButtonPage()
        {
            InitializeComponent();
            GenerateList();
        }
        /// <summary>
        /// Формирование списка элементов
        /// </summary>
        private void GenerateList() 
        {
            //Очищаем список
            ProgrammStackPanel.Children.Clear();
            //Заполняем список
            foreach (var item in programmingLanguages)
            {
                RadioButton activeRadio = new RadioButton
                {
                    Content = item,
                    FontWeight = FontWeights.Bold,
                    Margin = new Thickness(3),
                    Padding = new Thickness(3),
                };
                ProgrammStackPanel.Children.Add(activeRadio);
                activeRadio.Click += ActiveButtonClick;
            }
        }
        /// <summary>
        /// Определяем элемент для удаления
        /// </summary>
        private void ActiveButtonClick(object sender, RoutedEventArgs e)
        {
            activeElement = (RadioButton)sender;
            MessageBox.Show($"Выбран язык '{activeElement.Content}'");
        }
        /// <summary>
        /// Удаление
        /// </summary>
        private void DeleteButtonClick(object sender, RoutedEventArgs e)
        {
            //Удаляем выбранный элемент
            if (activeElement == null)
            {
                MessageBox.Show("Вы не выбрали элемент");
            }
            else 
            {
                programmingLanguages.Remove(activeElement.Content.ToString());

                //Снова формируется список из массива
                GenerateList();

                //Если список полностью очищен, то выводится сообщение
                //и кнопка "Удалить элемент" прячется
                DeleteButtonVisibility();
            }
        }
        /// <summary>
        /// Поведение кнопки "Удалить элемент"
        /// </summary>
        private void DeleteButtonVisibility()
        {
            if (programmingLanguages.Count == 0)
            {
                ProgrammStackPanel.Children.Add(
                    new TextBlock
                    {
                        Text = "Список пуст"
                    }
                    );
                DeleteButton.Visibility = Visibility.Collapsed;
            }
            else {
                GenerateList();
                DeleteButton.Visibility = Visibility.Visible;

            }
        }
        /// <summary>
        /// Добавление элемента в массив
        /// </summary>
        private void AddButtonClick(object sender, RoutedEventArgs e)
        {
            if (AdditingTextBox.Text == String.Empty)
            {
                MessageBox.Show("Вы не ввели элемент");
            }
            else {
                RadioButton newRadio = new RadioButton
                {
                    Content = AdditingTextBox.Text.ToString(),
                    FontWeight = FontWeights.Bold,
                    Margin = new Thickness(3),
                    Padding = new Thickness(3),
                };
                newRadio.Click += ActiveButtonClick;
                ProgrammStackPanel.Children.Add(newRadio);
                programmingLanguages.Add(AdditingTextBox.Text.ToString());
                DeleteButtonVisibility();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void AdditingCheckBoxClick(object sender, RoutedEventArgs e)
        {
            if (AdditingCheckBox.IsChecked == true)
            {
                AdditingGroupBox.Visibility = Visibility.Visible;
            }
            else {
                AdditingGroupBox.Visibility = Visibility.Collapsed;
            }
        }
    }
}
