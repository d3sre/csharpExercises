using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.Win32;
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

namespace L13U1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textbox.Focus();
        }

        private void buttonLoad_Click(object sender, RoutedEventArgs e)
        {
            var file = exportFile(new OpenFileDialog());
            if (file != null)
            {
                textbox.Text = File.ReadAllText(file, Encoding.UTF8);
            }
            textbox.Focus();
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            var file = exportFile(new SaveFileDialog());
            if (file != null)
            {
                File.WriteAllText(file, textbox.Text, Encoding.UTF8);
            }
            textbox.Focus();
        }

        private string exportFile(FileDialog dialog)
        {
            dialog.Filter = "Text Files (.txt)|*.txt";
            if (dialog.ShowDialog() == true)
            {
                return dialog.FileName;
            }
            else
            {
                return null;
            }
        }
    }
}
