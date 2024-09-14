using ElipseToolDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Desktop.Models
{
    internal class EllipseManager
    {
        public class ElipseManager
        {
            private int _cornerRadius;

            public ElipseManager(int cornerRadius = 5)
            {
                _cornerRadius = cornerRadius;
            }

            public void ApplyElipseToAllButtons(Control parent)
            {
                foreach (Control control in parent.Controls)
                {
                    if (control is Button)
                    {
                        ElipseControl elipseControl = new ElipseControl();
                        elipseControl.TargetControl = control;
                        elipseControl.CornerRadius = _cornerRadius; // Set the desired corner radius
                    }

                    // Recursively apply to nested controls
                    if (control.HasChildren)
                    {
                        ApplyElipseToAllButtons(control);
                    }
                }
            }
        }
    }
}
