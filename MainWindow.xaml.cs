using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
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
using System.Threading;

namespace TaskWPF                         // Define the namespace for the application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window // Define the MainWindow class, which inherits from Window
    {
        public MainWindow()                 // Constructor for MainWindow
        {
            InitializeComponent();          // Initialize the components defined in the XAML
        }

        private void MyButton_Click(object sender, RoutedEventArgs e) // Event handler for button click
        {
            //MessageBox.Show("Hello"); // Display a message box saying "Hello" when the button is clicked

            Debug.WriteLine($"Thread Number {Thread.CurrentThread.ManagedThreadId}"); // Log the current thread ID

            HttpClient webClient = new HttpClient(); // Create a new instance of HttpClient for making HTTP requests

            // Synchronously get the HTML content from Google and store it in the 'html' variable
            string html = webClient.GetStringAsync("http://google.com").Result;

            MyButton.Content = "Nice one! Franklin"; // Change the button content to "Nice one! Franklin"
        }
    }
}

