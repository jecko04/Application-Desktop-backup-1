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
            private int _cornerRadiusPanel;
            private int _panelCornerRadius;

            public ElipseManager(int cornerRadius = 5, int cornerRadiusPanel = 15)
            {
                _cornerRadius = cornerRadius;
                _cornerRadiusPanel = cornerRadiusPanel;
                _panelCornerRadius = cornerRadiusPanel;
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

            public void ApplyElipseToAllPanel(Control parent)
            {
                foreach (Control control in parent.Controls)
                {
                    if (control is Panel)
                    {
                        ElipseControl elipseControl = new ElipseControl();
                        elipseControl.TargetControl = control;
                        elipseControl.CornerRadius = _cornerRadiusPanel; // Set the desired corner radius
                    }

                    // Recursively apply to nested controls
                    if (control.HasChildren)
                    {
                        ApplyElipseToAllPanel(control);
                    }
                }
            }

            public void ApplyElipseToPanel(Panel panel)
            {
                ElipseControl elipseControl = new ElipseControl
                {
                    TargetControl = panel,
                    CornerRadius = _panelCornerRadius
                };
            }
        }
    }
}
