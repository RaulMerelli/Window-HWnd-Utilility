using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace WinHWndUtils
{
    /// <summary>
    /// Static class that lists all windows
    /// </summary>
    public static class WindowList
    {
        /// <summary>
        /// Gets all windows with basic information: caption, class and handle.
        /// The list starts with the desktop.
        /// </summary>
        /// <returns>WindowInformation list</returns>
        public static List<WindowInformation> GetAllWindows()
        {
            IntPtr desktopWindow = Win32.GetDesktopWindow();
            List<WindowInformation> winInfo = new List<WindowInformation>();
            winInfo.Add(winInfoGet(desktopWindow));
            List<IntPtr> handles = getChildWindows(desktopWindow);
            foreach (IntPtr handle in handles)
            {
                try
                {
                    winInfo.Add(winInfoGet(handle));
                }
                catch { }
            }
            return winInfo;
        }

        /// <summary>
        /// The delegate functions that is called by EnumChildWindows
        /// </summary>
        /// <param name="handle">Window handle</param>
        /// <param name="pointer">Pointer to the IntPtr list.</param>
        /// <returns>Boolean</returns>
        private static bool enumWindow(IntPtr handle, IntPtr pointer)
        {
            GCHandle gch = GCHandle.FromIntPtr(pointer);
            List<IntPtr> list = gch.Target as List<IntPtr>;
            if (list == null)
            {
                throw new InvalidCastException("GCHandle Target could not be cast as List<IntPtr>");
            }
            list.Add(handle);
            return true;
        }

        /// <summary>
        /// Called by GetAllWindows.
        /// </summary>
        /// <param name="parent">The handle of the desktop window.</param>
        /// <returns>List of window handles.</returns>
        private static List<IntPtr> getChildWindows(IntPtr parent)
        {
            List<IntPtr> result = new List<IntPtr>();
            GCHandle listHandle = GCHandle.Alloc(result);
            try
            {
                Win32.EnumWindowProc childProc = new Win32.EnumWindowProc(enumWindow);
                Win32.EnumChildWindows(parent, childProc, GCHandle.ToIntPtr(listHandle));
            }
            finally
            {
                if (listHandle.IsAllocated)
                    listHandle.Free();
            }
            return result;
        }
        
        /// <summary>
        /// Gets the basic window information from a handle.
        /// </summary>
        /// <param name="hWnd">Window handle.</param>
        /// <returns>WindowInformation object with basic information.</returns>
        private static WindowInformation winInfoGet(IntPtr hWnd)
        {
            StringBuilder caption = new StringBuilder(1024);
            StringBuilder className = new StringBuilder(1024);
            Win32.GetWindowText(hWnd, caption, caption.Capacity);
            Win32.GetClassName(hWnd, className, className.Capacity);
            WindowInformation wi = new WindowInformation();
            wi.Handle = hWnd;
            wi.Class = className.ToString();
            if (caption.ToString() != string.Empty)
            {
                wi.Caption = caption.ToString();
            }
            else
            {
                caption = new StringBuilder(Convert.ToInt32(Win32.SendMessage(wi.Handle, WM.GETTEXTLENGTH, IntPtr.Zero, IntPtr.Zero)) + 1);
                Win32.SendMessage(wi.Handle, WM.GETTEXT, caption.Capacity, caption);
                wi.Caption = caption.ToString();
            }
            return wi;
        }
    }

    /// <summary>
    /// Object that holds window specific information.
    /// </summary>
    public class WindowInformation
    {
        /// <summary>
        /// Initialize the class.
        /// </summary>
        public WindowInformation() { }

        /// <summary>
        /// The window caption.
        /// </summary>
        public string Caption = string.Empty;

        /// <summary>
        /// The window class.
        /// </summary>
        public string Class = string.Empty;
       
        /// <summary>
        /// The window handle.
        /// </summary>
        public IntPtr Handle;
    }
}
