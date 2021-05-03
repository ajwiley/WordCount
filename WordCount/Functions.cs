using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WordCount {
    static class Functions {
        public static int NumberOfWords(string para) {
            Regex reg = new Regex("[^a-zA-Z]+");

            int num = 1;
            char lastValue = ' ';

            // Find all the places where there is a space, tab or newline, these mean new words
            foreach (char c in para) {
                if (c == ' ' || c == '\t' || c == '\n') {
                    num += 1;
                }
                else if (reg.IsMatch(c.ToString()) && lastValue == ' ') { // Words must be valid (aka only a-zA-Z), but only if there is a space afterwards 
                    num -= 1;
                }

                lastValue = c;
            }

            // Don't add another word if the string just ends with a space, tab or new line.
            if (para.EndsWith(' ') || para.EndsWith('\t') || para.EndsWith('\n')) {
                num -= 1;
            }

            // Nothing is in the string
            if (para.Length < 1) {
                num = 0;
            }

            // If the user has one char that and it is a space, tab, or newline, set the count to 0.
            if (para.Length == 1 && para.Contains(' ') || para.Contains('\t')) {
                num = 0;
            }
            
            return num;
        }
    }
}
