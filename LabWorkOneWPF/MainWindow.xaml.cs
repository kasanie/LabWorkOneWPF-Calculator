using System;
using System.Windows;
using System.Windows.Controls;

namespace LabWorkOneWPF
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
        public static double Plus(double firstCount, double secondCount)
        {
            return firstCount + secondCount;
        }
        public static double Minus(double firstCount, double secondCount)
        {
            return firstCount - secondCount;
        }
        public static double Multiply(double firstCount, double secondCount)
        {
            return firstCount * secondCount;
        }
        public static double Divide(double firstCount, double secondCount)
        {
            return firstCount / secondCount;
        }

        private void FirstInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SecondInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Convert.ToString(Plus(Convert.ToDouble(FirstInput.Text), Convert.ToDouble(SecondInput.Text)));
        }


        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Convert.ToString(Minus(Convert.ToDouble(FirstInput.Text), Convert.ToDouble(SecondInput.Text)));
        }

        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Convert.ToString(Multiply(Convert.ToDouble(FirstInput.Text), Convert.ToDouble(SecondInput.Text)));
        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Convert.ToString(Divide(Convert.ToDouble(FirstInput.Text), Convert.ToDouble(SecondInput.Text)));
        }
    }
}
