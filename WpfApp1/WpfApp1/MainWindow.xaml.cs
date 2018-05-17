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
       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (label.Text == "")
            {
                //MessageBox.Show((sender as Button).Content.ToString());
                if ((sender as Button).Content.ToString() == "+"|| (sender as Button).Content.ToString() == "-"|| (sender as Button).Content.ToString() == "*"|| (sender as Button).Content.ToString() == "/")
                {
                   // MessageBox.Show("edesf");
                    Cl.a = float.Parse(A);
                    Cl.ch = (sender as Button).Content.ToString()[0];
                    label.Text = A + (sender as Button).Content.ToString();
                    A = "";
                    TEXTBOX.Text = "";
                }
                else
                {
                    A += (sender as Button).Content;
                    TEXTBOX.Text = A;
                }
            }
            else
            {
                
                if ((sender as Button).Content.ToString() == "=")
                {
                    Cl.b = float.Parse(TEXTBOX.Text);
                    label.Text+= TEXTBOX.Text;
                    TEXTBOX.Text = "=" + Cl.Return_Res();
                }
                else
                {
                    A += (sender as Button).Content;
                    TEXTBOX.Text = A;
                }

            }

           // A += (sender as Button).Content;
            //TEXTBOX.Text = A;


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TEXTBOX.Text = "";
            label.Text = "";

        }
    }
}
