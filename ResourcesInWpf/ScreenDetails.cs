using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResourcesInWpf
{
    public static class ScreenDetails
    {
        public static int NoOfScreen { get; set; }
        public static List<Screen> ScreenInfo { get; set; }
        public static void ScreenHandler()
        {
            if (ScreenInfo == null) ScreenInfo = new List<Screen>();
            NoOfScreen = Screen.AllScreens.Count();
            Screen[] TotalScreen = new Screen[NoOfScreen];
            foreach (var sc in Screen.AllScreens)
            {
                ScreenInfo.Add(sc);
            }
        }
    }
}
