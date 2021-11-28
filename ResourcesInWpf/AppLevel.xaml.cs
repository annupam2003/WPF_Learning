using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace ResourcesInWpf
{
    /// <summary>
    /// Interaction logic for AppLevel.xaml
    /// </summary>
    public partial class AppLevel : Window
    {
        public AppLevel()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Resources["myColor"] = Brushes.White;
        }
    }
}
