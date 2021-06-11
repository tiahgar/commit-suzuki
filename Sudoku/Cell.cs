using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Sudoku {
    class Cell : INotifyPropertyChanged {
        private int cellValue = 0;
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int Value {
            get { return cellValue; }
            set {
                cellValue = value;
                NotifyPropertyChanged();
            }
        }
    }
}
