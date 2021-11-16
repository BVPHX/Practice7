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
using Triad;

namespace Practice5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Triads firstTriad = new Triads();
        Triads secondTriad = new Triads();
        public MainWindow()
        {
            InitializeComponent();
            firstTriadBox.Text = firstTriad.First.ToString() + " " + firstTriad.Second.ToString() + " " + firstTriad.Third.ToString();
            secondTriadBox.Text = secondTriad.First.ToString() + " " + secondTriad.Second.ToString() + " " + secondTriad.Third.ToString();

        }

        private void FirstTriadIncrease(object sender, RoutedEventArgs e)
        {
            firstTriad.IncreaseTriadValuesTo10();
            firstTriadBox.Text = firstTriad.First.ToString() + " " + firstTriad.Second.ToString() + " " + firstTriad.Third.ToString();
        }

        private void SecondTriadIncrease(object sender, RoutedEventArgs e)
        {
            secondTriad.IncreaseTriadValuesTo10();
            secondTriadBox.Text = secondTriad.First.ToString() + " " + secondTriad.Second.ToString() + " " + secondTriad.Third.ToString();
        }

        private void CompareButton(object sender, RoutedEventArgs e)
        {
            if (firstTriad > secondTriad) MessageBox.Show("Значения первой триады больше значению второй");
            else MessageBox.Show("Некоторые значения первой триады меньше значений второй триады");
        }

        private void FirstDateFill(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(firstDateDayBox.Text) < 32 && Convert.ToInt32(firstDateDayBox.Text) > 0)
            {
                if (Convert.ToInt32(firstDateMonthBox.Text) > 0 && Convert.ToInt32(firstDateMonthBox.Text) < 13)
                {
                    Date firstDate = new Date(Convert.ToInt32(firstDateDayBox.Text), Convert.ToInt32(firstDateMonthBox.Text), Convert.ToInt32(firstDateYearBox.Text));
                    firstDateOutputBox.Text = firstDate.Day.ToString() + "." + firstDate.Month.ToString() + "." + firstDate.Year.ToString();
                }


            }
            else MessageBox.Show("Дата указана некорректно");
        }

        private void SecondDatFill(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(secondDateDayBox.Text) < 32 && Convert.ToInt32(secondDateDayBox.Text) > 0)
            {
                if (Convert.ToInt32(secondDateMonthBox.Text) > 0 && Convert.ToInt32(secondDateMonthBox.Text) < 13)
                {
                    Date secondDate = new Date(Convert.ToInt32(secondDateDayBox.Text), Convert.ToInt32(secondDateMonthBox.Text), Convert.ToInt32(secondDateYearBox.Text));
                    secondDateOutputBox.Text = secondDate.Day.ToString() + "." + secondDate.Month.ToString() + "." + secondDate.Year.ToString();
                }
            }
            else MessageBox.Show("Дата указана некорректно");
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

