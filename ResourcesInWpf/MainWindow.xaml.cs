using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;

namespace ResourcesInWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ScreenDetails.ScreenHandler();
            if (ScreenDetails.NoOfScreen == 1)
            {
                if (ScreenDetails.ScreenInfo[0].Primary)
                {
                    this.Top = 0;
                    this.Left = 0;
                    this.Height = ScreenDetails.ScreenInfo[0].Bounds.Height;
                    this.Width= ScreenDetails.ScreenInfo[0].Bounds.Width;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var lev = new AppLevel();
            lev.Show();
        }

        private void Button_Click02(object sender, RoutedEventArgs e)
        {
            var lev = new PageLevel();
            lev.Show();
        }

        private void Button_Click03(object sender, RoutedEventArgs e)
        {
            var lev = new ControlLevel();
            lev.Show();
        }
    }
}
