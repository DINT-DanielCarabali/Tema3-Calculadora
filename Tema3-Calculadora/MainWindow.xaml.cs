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

namespace Tema3_Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void numButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Name)
            {
                case "num1Button":
                    pantallaTextBlock.Text += "1";
                    break;
                case "num2Button":
                    pantallaTextBlock.Text += "2";
                    break;
                case "num3Button":
                    pantallaTextBlock.Text += "3";
                    break;
                case "num4Button":
                    pantallaTextBlock.Text += "4";
                    break;
                case "num5Button":
                    pantallaTextBlock.Text += "5";
                    break;
                case "num6Button":
                    pantallaTextBlock.Text += "6";
                    break;
                case "num7Button":
                    pantallaTextBlock.Text += "7";
                    break;
                case "num8Button":
                    pantallaTextBlock.Text += "8";
                    break;
                case "num9Button":
                    pantallaTextBlock.Text += "9";
                    break;
                case "num0Button":
                    pantallaTextBlock.Text += "0";
                    break;
            }
        }
    }
}