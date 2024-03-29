﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FilmFileNumber
{
    class WindowWrapper : System.Windows.Forms.IWin32Window
    {
        public WindowWrapper(IntPtr handle)
        {
            hwndThis = handle;
        }

        public IntPtr Handle
        {
            get { return hwndThis; }
        }

        private IntPtr hwndThis;
    }
}


//class WindowWrapper : System.Windows.Forms.IWin32Window
//{
//    public WindowWrapper(IntPtr handle)
//    {
//        _hwnd = handle;
//    }

//    public IntPtr Handle
//    {
//        get { return _hwnd; }
//    }

//    private IntPtr _hwnd;
//}