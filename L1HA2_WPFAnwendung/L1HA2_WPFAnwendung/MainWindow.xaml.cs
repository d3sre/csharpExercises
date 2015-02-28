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

namespace L1HA2_WPFAnwendung
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Hauptfensterkonstruktor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Methode Button_Click fuer Ausführung Klick auf Button
        /// </summary>
        /// <param name="sender">übergibt Sender (welche Funktion aufgerufen hat)</param>
        /// <param name="e">(Argumentübergabe)</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string currentName = nameInput.Text;
            MessageBox.Show("Hello " + currentName, "Begruessungsfenster");

        }
    }
}
