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
    /// Логика взаимодействия для ComboBoxPage.xaml
    /// </summary>
    public partial class ComboBoxPage : Page

    {
        string[] programmingLanguases = { "Java", "C#", "PHP", "GO", "Kotlin", "C+" };

        public ComboBoxPage()
        {
            InitializeComponent();
            GenerateList();
        }
        /// <summary>
        /// Формирование списка кнопок 
        /// </summary>
       private void  GenerateList()
        {
            ComboBox newCombo = new ComboBox();
            newCombo.ItemsSource = programmingLanguases;
            ProgrammStackPanel.Children.Add(newCombo);

        }
    }
}
