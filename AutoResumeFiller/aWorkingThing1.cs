using System;
using System.IO;
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
        public string path;
        public string cover_letter;

        public MainWindow()
        {
            InitializeComponent();
        }

        //Company name
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox1 != null && path != null)
            {
                //path = @"C:\Users\kraig\Desktop\Input.txt";
                if (path != null)
                {
                    cover_letter = System.IO.File.ReadAllText(path);
                    textBox1.Text = this.cover_letter.Replace("companyName", textBox.Text);
                    if (textBox2 != null)
                    {
                        textBox1.Text = textBox1.Text.Replace("positionName", textBox2.Text);
                    }
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
            if (textBox1 != null && path != null) { 
                    textBox1.Text = this.cover_letter.Replace("positionName", textBox2.Text);
                    if (textBox != null)
                    {
                        textBox1.Text = textBox1.Text.Replace("companyName", textBox.Text);
                    }
            }
        }

        //https://stackoverflow.com/questions/10315188/open-file-dialog-and-select-a-file-using-wpf-controls-and-c-sharp
        private void OpenFileOnClick(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog fileDlg = new Microsoft.Win32.OpenFileDialog();
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = fileDlg.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = fileDlg.FileName;
                textBox1.Text = filename;
                path = filename;
            }
        }
    }
}
