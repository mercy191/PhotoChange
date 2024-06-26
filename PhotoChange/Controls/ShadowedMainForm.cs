﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PhotoChange.Forms
{
    public class ShadowedMainForm : Form
    {
        public class ShadowedForm : Form
        {
            private bool m_aeroEnabled = false;

            private const int CS_DROPSHADOW = 0x00020000;
            private const int WM_NCPAINT = 0x0085;

            [DllImport("dwmapi.dll")]
            public static extern int DwmExtendFrameIntoClientArea(nint hWnd, ref MARGINS pMarInset);

            [DllImport("dwmapi.dll")]
            public static extern int DwmSetWindowAttribute(nint hwnd, int attr, ref int attrValue, int attrSize);

            [DllImport("dwmapi.dll")]
            public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

            public struct MARGINS
            {
                public int leftWidth;
                public int rightWidth;
                public int topHeight;
                public int bottomHeight;
            }
            protected override CreateParams CreateParams
            {
                get
                {
                    m_aeroEnabled = CheckAeroEnabled();
                    CreateParams cp = base.CreateParams;
                    if (!m_aeroEnabled)
                        cp.ClassStyle |= CS_DROPSHADOW; return cp;
                }
            }
            private bool CheckAeroEnabled()
            {
                if (Environment.OSVersion.Version.Major >= 6)
                {
                    int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                    return enabled == 1 ? true : false;
                }
                return false;
            }
            protected override void WndProc(ref Message m)
            {
                switch (m.Msg)
                {
                    case WM_NCPAINT:
                        if (m_aeroEnabled)
                        {
                            var v = 2;
                            DwmSetWindowAttribute(Handle, 2, ref v, 4);

                            MARGINS margins = new MARGINS()
                            {
                                bottomHeight = 1,
                                leftWidth = 0,
                                rightWidth = 0,
                                topHeight = 0
                            };

                            DwmExtendFrameIntoClientArea(Handle, ref margins);
                        }
                        break;
                    default: break;
                }
                base.WndProc(ref m);
            }
        }
    }
}
