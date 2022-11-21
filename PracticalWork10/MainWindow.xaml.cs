using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace PracticalWork10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            list.ItemsSource = numbers;
        }

        ObservableCollection<int> numbers = new ObservableCollection<int>();
        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            
            int.TryParse(numberOf5.Text, out int valPlus);
            int.TryParse(numberOfMinus5.Text, out int valMinus);

            if (numberOf5.Text == "")
            {
                valMinus = 0;
                valPlus = 0;
            }

            int.TryParse(value.Text, out int val);
            numbers.Add(val);
            if(val == 5) valPlus++;
            else if(val == -5) valMinus++;
            numberOf5.Text = valPlus.ToString();
            numberOfMinus5.Text = valMinus.ToString();
        }

        private void Fill_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(numberOf5.Text, out int valPlus);
            int.TryParse(numberOfMinus5.Text, out int valMinus);

            if (numberOf5.Text == "")
            {
                valMinus = 0;
                valPlus = 0;
            }
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                numbers.Add(random.Next(-10, 10));
                if (i == 5) valPlus++;
                else if (i == -5) valMinus++;
            }
            numberOf5.Text = valPlus.ToString();
            numberOfMinus5.Text = valMinus.ToString();
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {

        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
