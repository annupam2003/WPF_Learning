using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
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
using Image = System.Drawing.Image;

namespace ResourceDictionaryInWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private const string resxFile = @".\Resources.resx";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void checkBoxChecked_Checked(object sender, RoutedEventArgs e)
        {
          var img =  Properties.Resources.ResourceManager.GetObject("check");
            //var img = new Bitmap(global::ResourceDictionaryInWpf.Properties.Resources.check);
            var MyImage = (Bitmap)img;
            Image image = MyImage;
            ImgCongrol.Source =new BitmapImage( new Uri(@".\Resources.uncheck.png", UriKind.Relative));
        }


    }
}
