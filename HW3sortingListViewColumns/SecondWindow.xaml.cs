using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.ComponentModel; //add this.

namespace HW3sortingListViewColumns
{
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {

        
        public SecondWindow()       //5
        {                           //6
            InitializeComponent();  //7

            var users = new List<Models.User>();    //8

            users.Add(new Models.User { Name = "Dave", Password = "1DavePwd" });    //9
            users.Add(new Models.User { Name = "Steve", Password = "2StevePwd" });  //10
            users.Add(new Models.User { Name = "Lisa", Password = "3LisaPwd" });    //11

            uxList.ItemsSource = users;             //12
        }
        private void uxListColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            GridViewColumnHeader column = (sender as GridViewColumnHeader);
            string sortBy = column.Tag.ToString();

            uxList.Items.SortDescriptions.Clear();


            ListSortDirection newDir = ListSortDirection.Ascending;

            uxList.Items.SortDescriptions.Add(new SortDescription(sortBy, newDir));
        }

        public class User
        {
            public string name { get; set; }
            public string password { get; set; }

        }

        public ListSortDirection Direction { get; private set; }

    }
}
