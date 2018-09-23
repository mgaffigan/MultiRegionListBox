using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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

namespace MultiRegionListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly SharedLayoutCoordinator slc;

        public MainWindow()
        {
            InitializeComponent();

            this.slc = (SharedLayoutCoordinator)((Grid)this.Content).FindResource("slc");
            slc.ItemsSource = typeof(Brushes).GetProperties().Select(p => p.Name).OrderBy(a => a).ToArray();
        }
    }
}
