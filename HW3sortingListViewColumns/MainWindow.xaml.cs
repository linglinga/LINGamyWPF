using System.Windows;
using System.Data.Entity; // add this for EF to work
//DbSet<User> does not contain a definition for 'Load' and no extension method 'Load' accpeting a first argument of type 'DbSet<User>' could be found. Are yuou missing a using directive or an asembly reference?)


namespace HW3sortingListViewColumns
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Models.User user = new Models.User();

        public MainWindow()
        {
            InitializeComponent();

            // Exercise 1: Maximize your window using code
            WindowState = WindowState.Maximized;
        }

        public override void EndInit()
        {
            //base.EndInit();
            //uxContainer.DataContext = user;

            base.EndInit();

            var sample1 = new Sample1Entities();

            sample1.Users.Load();

            uxList.ItemsSource = sample1.Users.Local;
        }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            int x = 1;
            x = x / (x - 1); // Induce a DivideByZeroException

            MessageBox.Show("Submitting password:" + uxPassword.Password);
            var window = new SecondWindow();
            Application.Current.MainWindow = window;
            Close();
            window.Show();
        }
    }
}
