using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WordCount {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        // Initalize the bound properties
        BoundProperties _BoundProperties = new BoundProperties();

        public MainWindow() {
            InitializeComponent();
            DataContext = _BoundProperties; // Setup the data context to point to the bound properties
        }

        /// <summary>
        /// When the user hits the 'enter' key, move the cursor to the bottom of the string, and add in a newline
        /// </summary>
        private void TextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Enter) {
                _BoundProperties.Text += Environment.NewLine;

                TextBox temp = (TextBox)sender;
                temp.CaretIndex = temp.Text.Length;

                e.Handled = true;
            }
        }

        /// <summary>
        /// Reset the text to nothing, this also resets the numbers back to 0.
        /// </summary>
        private void BtnReset_Click(object sender, RoutedEventArgs e) {
            _BoundProperties.Text = "";
        }
    }
}
