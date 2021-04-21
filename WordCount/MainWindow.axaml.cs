using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace WordCount {
    public class MainWindow : Window {
        private BoundProperties _boundProperties = new BoundProperties();
        
        public MainWindow() {
            InitializeComponent();

            DataContext = _boundProperties;
            
            #if DEBUG
            this.AttachDevTools();
            #endif
        }

        private void InitializeComponent() {
            AvaloniaXamlLoader.Load(this);
        }

        private void Button_OnClick(object? sender, RoutedEventArgs e) {
            Console.WriteLine(_boundProperties.TextContent);
        }
    }
}