using Application_Desktop.Screen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Desktop.Models
{
    public class msgAlertBox
    {
        public static void AlertBox(Color backcolor, Color color, string title, string subtitle, Image icon)
        {
            

            alertBox alertbox = new alertBox();

            alertbox.BackColor = backcolor;
            alertbox.ColorAlertBox = color;
            alertbox.TitleAlertBox = title;
            alertbox.SubTitleAlertBox = subtitle;
            alertbox.IconAlertBox = icon;
            alertbox.Show();
        }
    }
}
