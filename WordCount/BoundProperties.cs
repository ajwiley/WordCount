using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using JetBrains.Annotations;

namespace WordCount {
    public class BoundProperties : INotifyPropertyChanged {
        private string _TextContent;
        public string TextContent {
            get => _TextContent;
            set {
                _TextContent = value;
                OnPropertyChanged(nameof(TextContent));
            }
        }

        public BoundProperties() {
            TextContent = "";
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}