using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Sudoku
{
    class Grid : INotifyPropertyChanged {
        private ObservableCollection<ObservableCollection<Cell>> gridCollection;
        public event PropertyChangedEventHandler PropertyChanged;

        public Grid() {
            gridCollection = new ObservableCollection<ObservableCollection<Cell>>();
            int size = 9;

            for (int i = 0; i < size; i++) {
                ObservableCollection<Cell> row = new ObservableCollection<Cell>();

                for (int j = 0; j < size; j++) {
                    Cell c = new Cell();
                    c.Value = 1;
                    row.Add(c);
                }
                gridCollection.Add(row);
            }
        }

        public ObservableCollection<ObservableCollection<Cell>> SudokuGrid {
            get {
                return gridCollection;
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
