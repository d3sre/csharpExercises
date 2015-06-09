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

namespace ClientApplikation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            try
            {
                var calcClient = new ServiceReference1.CalculatorClient();
                var myParameter = new ServiceReference1.MyCalculator { param1 = 5, param2 = 4 };

                var add = calcClient.Addition(myParameter);
                Console.WriteLine("{0} = {1}", "Addition: ", add);

                var sub = calcClient.Subtraction(myParameter);
                Console.WriteLine("{0} = {1}", "Subtraction: ", sub);

                var multi = calcClient.Multiply(myParameter);
                Console.WriteLine("{0} = {1}", "Multiply: ", multi);

                var div = calcClient.Divide(myParameter);
                Console.WriteLine("{0} = {1}", "Division: ", div);

                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error has happened with Calculator Service Test\n: {0}", e);

                throw;
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
