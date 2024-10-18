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

namespace raadspelWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        int winningNumber;
        int tries;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void endButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void newButton_Click(object sender, RoutedEventArgs e)
        {
            
            winningNumber = rnd.Next(1, 101);
            Console.WriteLine($"nummer in console: {winningNumber}");
            output1TextBox.Clear();
            output1TextBox.Foreground = Brushes.Black;
            output2TextBox.Clear();
            inputTextBox.Clear();
            inputTextBox.Focus();
            tries = 0;
            Console.WriteLine(winningNumber);

        }

        private void evaluateButton_Click(object sender, RoutedEventArgs e)
        {
            bool isValidInput = int.TryParse(inputTextBox.Text, out int inputNumber);
            Console.WriteLine(winningNumber);

            if (isValidInput && inputNumber > 0 && inputNumber <= 100)
            {
                if (inputNumber < winningNumber)
                {
                    output1TextBox.Text = "Raad hoger!";
                    tries++;
                    output2TextBox.Text = $"Aantal keren geraden {tries}";

                }
                else if (inputNumber > winningNumber)
                {
                    output1TextBox.Text = "Raad lager!";
                    tries++;
                    output2TextBox.Text = $"Aantal keren geraden {tries}";
                }
                else
                {
                    output1TextBox.Text = "Proficiat u heeft het getal geraden!";
                    tries++;
                    output2TextBox.Text = $"Aantal keren geraden {tries}";

                }

            }
            else
            {
                output1TextBox.Text = "Geef een geheel getal tussen 1 en 100";
                output1TextBox.Foreground = Brushes.Red;

            }


        }

        private void grid_Loaded(object sender, RoutedEventArgs e)
        {
            winningNumber = rnd.Next(1, 101);
            Console.WriteLine(winningNumber);
        }
    }
}
