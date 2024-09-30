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
using System.Windows.Shapes;

namespace Example13Project
{
    /// <summary>
    /// Interaction logic for SquareCalcWindow.xaml
    /// </summary>
    public partial class SquareCalcWindow : Window
    {
        public SquareCalcWindow()
        {
            InitializeComponent();
        }
        private bool IsNum(string numstr)
        {
            try
            {
                int.Parse(numstr);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnSquare_Click(object sender, RoutedEventArgs e)
        {
            if (!IsNum(txtEnterNumber.Text))
            {
                MessageBox.Show("Please enter number");
                txtEnterNumber.Focus();
                txtEnterNumber.SelectAll();

                return;
            }
            int enternumber = int.Parse(txtEnterNumber.Text);
           
            int square = enternumber * enternumber;
            txtResult.Text = square.ToString();
            lblResult.Text = "square";
            



        }

        private void btnCube_Click(object sender, RoutedEventArgs e)
        {
            if (!IsNum(txtEnterNumber.Text))
            {
                MessageBox.Show("Please enter number");
                txtEnterNumber.Focus();
                txtEnterNumber.SelectAll();

                return;
            }
            int enternumber = int.Parse(txtEnterNumber.Text);
           
            int cube = enternumber * enternumber * enternumber;
            txtResult.Text = cube.ToString();
            lblResult.Text = "Cube";
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
