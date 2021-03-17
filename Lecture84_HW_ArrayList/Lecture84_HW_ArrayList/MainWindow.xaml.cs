using System;
using System.Collections;
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

namespace Lecture84_HW_ArrayList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Add(inputNumber.Text.ToString());
            MessageBox.Show($"Add Number : {inputNumber.Text} Complete");
            inputNumber.Text = "";
            showData.Text = "";
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Remove(inputNumber.Text.ToString());
            MessageBox.Show($"Remove Number : {inputNumber.Text} Complete");
            inputNumber.Text = "";
            showData.Text = "";
        }

        private void showAllButton_Click(object sender, RoutedEventArgs e)
        {
            string tmp_number = "";
            foreach(string item in arrayList)
            {
                tmp_number += item + "\n";
            }
            showData.Text = tmp_number;

        }
    }
}
