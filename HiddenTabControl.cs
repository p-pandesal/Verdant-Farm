using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace VerdantFarm
{
    public class HiddenTabControl : TabControl
    {
        protected override void WndProc(ref Message m)
        {
            // 0x1328 is the Windows Message for TCM_ADJUSTRECT. 
            // We intercept it to hide the tabs completely at runtime.
            if (m.Msg == 0x1328 && !DesignMode)
            {
                m.Result = (IntPtr)1;
            }
            else
            {
                base.WndProc(ref m);
            }
        }
    }
}
