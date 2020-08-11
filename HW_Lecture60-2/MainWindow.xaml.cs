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

namespace HW_Lecture60_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            Calculate(double.Parse(txtIncome.Text), double.Parse(txtExpenditure.Text), double.Parse(txtPrice.Text));
        }
        private void Calculate(double Income, double Expenditure, double price)
        {
            double savings = Income - Expenditure;
            double result = price / savings;

            if(result>0)
            {
                txtResult.Text = result.ToString();
            }
        }
    }
}
