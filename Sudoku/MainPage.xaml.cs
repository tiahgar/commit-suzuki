using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Sudoku {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page {
        Grid sudoku = new Grid();
        public Cell cell = new Cell { Value = 2 };
        public ObservableCollection<ObservableCollection<Cell>> TestSudoku { get { return sudoku.SudokuGrid;  } }
        public int TestCell { get { return cell.Value;  } }
        public int TestData { get { return 5;  } }
        public MainPage() {
            this.InitializeComponent();
            this.DataContext = this;
        }
    }
}
