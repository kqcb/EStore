using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace EStore.Utils
{
    static class Common
    {

        public static void ChangeContorl(ControlCollection controls, UserControl control)
        {

            controls.Clear();
            control.Focus();
            control.BringToFront();
            control.Dock = DockStyle.Fill;
            controls.Add(control);
        }

        public static void AddControl(ControlCollection controls, UserControl control)
        {

            controls.Add(control);

            if (controls.Count > 0)
            {
                var temp = controls[0];
                controls.SetChildIndex(controls[controls.Count - 1], 0);
                controls.Add(temp);
            }
        }

        public static void RemoveControl(ControlCollection controls)
        {
            if(controls.Count > 0) 
                controls.RemoveAt(0);
        }

        internal static void RemoveControl(ControlCollection controls, int index)
        {
            throw new NotImplementedException();
        }
    }
}
