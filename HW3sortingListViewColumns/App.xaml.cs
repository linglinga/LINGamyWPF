using System;
using System.Windows;

namespace HW3sortingListViewColumns
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()    //1
        {               //2
            Application.Current.DispatcherUnhandledException += Current_DispatcherUnhandledException;   //3
        }               //4
        // Global application level exception handling method
        private void Current_DispatcherUnhandledException(object sender,
                               System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {               //13
            Exception ex = (Exception)e.Exception;                          //14
            MessageBox.Show(ex.Message, "Unhandled Exception");             //15    Line6, position9
            e.Handled = true; // let the application to continue to run     //16
        }               //17
    }
}
