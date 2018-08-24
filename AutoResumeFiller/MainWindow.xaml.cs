using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AutoResumeFiller
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string path = @"C:\Users\kraig\Desktop\Input.txt";
        public string resume = System.IO.File.ReadAllText(path);

        public MainWindow()
        {
            InitializeComponent();
        }

        //Company name
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox1 != null)
            {
                textBox1.Text = this.resume.Replace("companyName", textBox.Text);
                if (textBox2 != null)
                {
                    textBox1.Text = textBox1.Text.Replace("positionName", textBox2.Text);
                }
            }
        }

        //output, do nothing when text changes
        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //position applying for
        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox1 != null)
            {
                textBox1.Text = this.resume.Replace("positionName", textBox2.Text);
                if (textBox != null)
                {
                    textBox1.Text = textBox1.Text.Replace("companyName", textBox.Text);
                }
            }
        }
    }
}
