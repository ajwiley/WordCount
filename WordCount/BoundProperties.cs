using System.ComponentModel;
using System;

namespace WordCount {
    public class BoundProperties : INotifyPropertyChanged {
        private string _Text;
        public string Text {
            get => _Text;
            set {
                _Text = value;
                NumberWords = Functions.NumberOfWords(_Text); // Get the number of words in the text
                NumberChars = _Text.Replace(Environment.NewLine, "").Length; // Don't count newlines when counting chars
                OnPropertyChanged(nameof(Text));
            }
        }

        // This is the number of words, it get's found out by using the function, 'NumberOfWords'
        private int _NumberWords;
        public int NumberWords {
            get => _NumberWords;
            set {
                _NumberWords = value;
                OnPropertyChanged(nameof(NumberWords));
            }
        }

        // This is the number of chars, not including newlines
        private int _NumberChars;
        public int NumberChars {
            get => _NumberChars;
            set {
                _NumberChars = value;
                OnPropertyChanged(nameof(NumberChars));
            }
        }


        // These are the default values
        public BoundProperties() {
            Text = ""; // Doing this sets the values of chars/words to 0
        }

        // Delegates can be used in event handling to pass values to the UI thread.
        // To implement the INotifyPropertyChanged interface, you must register the PropertyChangedEventHandler delegate as an event.
        public event PropertyChangedEventHandler PropertyChanged;

        // When the PropertyChanged event is raised, this method will instantiate an object containing the name of the property that was changed 
        // so the UI control can connect to the appropriate property.
        protected void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
