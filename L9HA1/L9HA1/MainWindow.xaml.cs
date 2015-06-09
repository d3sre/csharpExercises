using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace L9HA1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// http://stackoverflow.com/questions/20350886/wpf-fill-data-on-data-grid
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            using (var db = new SchoolContext())
            {
                ObservableCollection<Person> users = new ObservableCollection<Person>();



                var dbinput = from p in db.People
                              orderby p.PersonId
                              select p;

                //foreach (var item in dbinput)
                //{
                //    users.Add(new Person{PersonId = item.PersonId,EnrollmentDate = item.EnrollmentDate, FirstName = item.FirstName, HireDate = item.HireDate, LastName = item.LastName});
                //}

                int i = dbinput.Count();


                DataGrid1.ItemsSource = dbinput.ToList();
            }
        }

        private void Button_Search(object sender, RoutedEventArgs e)
        {
            using (var db = new SchoolContext())
            {

                string firstName = FirstNameBox.Text;
                string lastName = LastNameBox.Text;

                if (firstName == "" && lastName == "")
                {
                    var dbinput = from p in db.People
                        orderby p.PersonId
                        select p;

                    DataGrid1.ItemsSource = dbinput.ToList();
                }
                else if (firstName == "" && lastName != "")
                {
                    string searchquery = lastName;

                    var dbinput = from p in db.People
                        where p.LastName == searchquery
                        orderby p.PersonId
                        select p;

                    DataGrid1.ItemsSource = dbinput.ToList();
                }
                else if (firstName != "" && lastName == "")
                {
                    string searchquery = firstName;

                    var dbinput = from p in db.People
                        where p.FirstName == searchquery
                        orderby p.PersonId
                        select p;

                    DataGrid1.ItemsSource = dbinput.ToList();
                }
                else
                {
                    string searchquery1 = firstName;
                    string searchquery2 = lastName;

                    var dbinput = from p in db.People
                                  where p.FirstName == searchquery1 && p.LastName == searchquery2
                                  orderby p.PersonId
                                  select p;

                    DataGrid1.ItemsSource = dbinput.ToList();
                }

                
            }
        }

        //public event EventHandler<AddingNewItemEventArgs> AddingNewItem;

        public void DataGrid1_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            if (e.EditAction == DataGridEditAction.Commit)
            {
                Action action = delegate
                {
                    Person newPerson = e.Row.Item as Person;

                    using (var db = new SchoolContext())
                    {
                        db.People.Add(newPerson);
                        db.SaveChanges();
                    }
                };
                
                Dispatcher.BeginInvoke(action, System.Windows.Threading.DispatcherPriority.Background);

            }


        }

    }


}
