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
using Microsoft.Win32;
using System.IO;
namespace WPFApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the button click event to process form data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            // Retriving the submitted form data.
            string email = EmailTextBox.Text;
            string name = FullName.Text;
            var validFormValues = ValidateFormfields(email, name);

            if (string.IsNullOrEmpty(validFormValues))
            {
                MessageBox.Show($"Email Entered: {email} and name is: {name} ", "Button Clicked");
            } else
            {
                MessageBox.Show(validFormValues, "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        /// <summary>
        /// Validates the form fields to ensure they are not empty.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        private string ValidateFormfields(string email, string name)
        {
            if (string.IsNullOrEmpty(email))
            {
                return "Email cannot be empty";
            }

            if (string.IsNullOrEmpty(name))
            {
                return "Name canot be empty";
            }

            return string.Empty;
        }

        /// <summary>
        /// Handles file selection and displays the content of the selected file in a text block.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileHandling(object sender, RoutedEventArgs e)
        {
            // Open file dialog to select a file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    // Read file content
                    string fileContent = File.ReadAllText(filePath);

                    // Display content in the TextBlock
                    FileContentTextBlock.Text = fileContent;
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}