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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string A;
        Calculate Cl = new Calculate();
        char z;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (label.Content == "")
            {
                if ((sender as Button).Content == "+"|| (sender as Button).Content == "-"|| (sender as Button).Content == "-"|| (sender as Button).Content == "-")
                {
                    Cl.a = float.Parse(A);
                    Cl.ch = (char)(sender as Button).Content;
                    label.Content = A + (sender as Button).Content;
                    A = "";
                    TEXTBOX.Text = "";
                }
            }
            else
            {
                if ((sender as Button).Content=="=")
                {
                    Cl.b = float.Parse(TEXTBOX.Text);
                    label.Content+= TEXTBOX.Text;
                    TEXTBOX.Text = "=" + Cl.Return_Res();
                }

            }

            A += (sender as Button).Content;
            TEXTBOX.Text = A;


        }
    }
}
