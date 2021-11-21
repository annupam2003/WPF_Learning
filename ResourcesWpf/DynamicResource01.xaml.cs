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

namespace ResourcesWpf
{
    /// <summary>
    /// Interaction logic for DynamicResource01.xaml
    /// </summary>
    public partial class DynamicResource01 : Window
    {
        public DynamicResource01()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Resources["MyColor03"] = Brushes.Red;
        }
    }
}
