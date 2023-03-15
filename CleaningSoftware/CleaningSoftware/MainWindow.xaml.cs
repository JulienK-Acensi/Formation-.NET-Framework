using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

namespace CleaningSoftware
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DirectoryInfo winTemp;
        public DirectoryInfo appTemp;

        public MainWindow()
        {
            InitializeComponent();
            winTemp = new DirectoryInfo(@"C:\Windows\Temp");
            appTemp = new DirectoryInfo(System.IO.Path.GetTempPath());
        }

        public long GetDirectorySize(DirectoryInfo dir)
        {
            return dir.GetFiles().Sum(fi => fi.Length) + dir.GetDirectories().Sum(di => GetDirectorySize(di));
        }

        public void ClearTempData(DirectoryInfo dir)
        {
            foreach (var fi in dir.GetFiles())
            {
                try
                {
                    fi.Delete();
                    Console.WriteLine(fi.FullName);
                } catch (Exception ex) { Console.WriteLine(ex.Message); } 
            }

            foreach (var di in dir.GetDirectories())
            {
                try
                {
                    di.Delete(true);
                    Console.WriteLine(di.FullName);
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
        }

        private void OnCleanClicked(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Start Cleaning ...");
            StatusIndicator.Content = "Cleaning ...";
            CleanBTN.Content = "Cleaning ...";
            CleanBTN.IsHitTestVisible = false;

            Clipboard.Clear();
            try
            {
                ClearTempData(winTemp);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            try
            {
                ClearTempData(appTemp);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }


            CleanBTN.Content = "Done !";
            StatusIndicator.Content = "Everything has been cleaned";
            CleaningAmountValue.Content = string.Format("{0} Mo", 0);
            CleanBTN.IsHitTestVisible = true;
        }

        private void OnUpdateClicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You are Up To Date !", "Update", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void OnHistoryClicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("We are working on this feature :)", "History", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void OnAboutClicked(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("www.acensi.fr"));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please Visit us at : www.acensi.fr", "About", MessageBoxButton.OK, MessageBoxImage.Information);
                Console.Error.WriteLine(ex.Message);
            }
        }

        private void OnAnalyzeClicked(object sender, RoutedEventArgs e)
        {
            AnalyzeFolders();
        }

        public void AnalyzeFolders()
        {
            Console.WriteLine("Analyzing ...");
            StatusIndicator.Content = "Analyzing ...";
            long totalSize = 0;

            try
            {
                totalSize += GetDirectorySize(winTemp) / 1000000;
                totalSize += GetDirectorySize(appTemp) / 1000000;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            CleaningAmountValue.Content = string.Format("{0} Mo", totalSize);
            LastCleaningValue.Content = DateTime.Today;
            StatusIndicator.Content = "Ready To Clean";
        }
    }
}
