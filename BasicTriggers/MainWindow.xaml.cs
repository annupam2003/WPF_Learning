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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BasicTriggers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPropertyTrigger_Click(object sender, RoutedEventArgs e)
        {
            var obj = new PropertyTrigger();
            obj.Show();
        }

        private void btnDataTrigger_Click(object sender, RoutedEventArgs e)
        {
            var obj = new DataTriggers();
            obj.Show();
        }

        private void btnMulitDataTrigger_Click(object sender, RoutedEventArgs e)
        {
            var obj = new MultiDataTriggers();
            obj.Show();
        }

        private void btnEventTrigger_Click(object sender, RoutedEventArgs e)
        {
            var obj = new EventTriggers();
            obj.Show();
        }
    }
}
