using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;

namespace WinHWndUtils
{
    [Flags()]
    enum SetWindowPosFlags : uint
    {
        /// <summary>If the calling thread and the thread that owns the window are attached to different input queues, 
        /// the system posts the request to the thread that owns the window. This prevents the calling thread from 
        /// blocking its execution while other threads process the request.</summary>
        /// <remarks>SWP_ASYNCWINDOWPOS</remarks>
        AsynchronousWindowPosition = 0x4000,
        /// <summary>Prevents generation of the WM_SYNCPAINT message.</summary>
        /// <remarks>SWP_DEFERERASE</remarks>
        DeferErase = 0x2000,
        /// <summary>Draws a frame (defined in the window's class description) around the window.</summary>
        /// <remarks>SWP_DRAWFRAME</remarks>
        DrawFrame = 0x0020,
        /// <summary>Applies new frame styles set using the SetWindowLong function. Sends a WM_NCCALCSIZE message to 
        /// the window, even if the window's size is not being changed. If this flag is not specified, WM_NCCALCSIZE 
        /// is sent only when the window's size is being changed.</summary>
        /// <remarks>SWP_FRAMECHANGED</remarks>
        FrameChanged = 0x0020,
        /// <summary>Hides the window.</summary>
        /// <remarks>SWP_HIDEWINDOW</remarks>
        SWP_HIDEWINDOW = 0x0080,
        /// <summary>Does not activate the window. If this flag is not set, the window is activated and moved to the 
        /// top of either the topmost or non-topmost group (depending on the setting of the hWndInsertAfter 
        /// parameter).</summary>
        /// <remarks>SWP_NOACTIVATE</remarks>
        DoNotActivate = 0x0010,
        /// <summary>Discards the entire contents of the client area. If this flag is not specified, the valid 
        /// contents of the client area are saved and copied back into the client area after the window is sized or 
        /// repositioned.</summary>
        /// <remarks>SWP_NOCOPYBITS</remarks>
        DoNotCopyBits = 0x0100,
        /// <summary>Retains the current position (ignores X and Y parameters).</summary>
        /// <remarks>SWP_NOMOVE</remarks>
        IgnoreMove = 0x0002,
        /// <summary>Does not change the owner window's position in the Z order.</summary>
        /// <remarks>SWP_NOOWNERZORDER</remarks>
        DoNotChangeOwnerZOrder = 0x0200,
        /// <summary>Does not redraw changes. If this flag is set, no repainting of any kind occurs. This applies to 
        /// the client area, the nonclient area (including the title bar and scroll bars), and any part of the parent 
        /// window uncovered as a result of the window being moved. When this flag is set, the application must 
        /// explicitly invalidate or redraw any parts of the window and parent window that need redrawing.</summary>
        /// <remarks>SWP_NOREDRAW</remarks>
        DoNotRedraw = 0x0008,
        /// <summary>Same as the SWP_NOOWNERZORDER flag.</summary>
        /// <remarks>SWP_NOREPOSITION</remarks>
        DoNotReposition = 0x0200,
        /// <summary>Prevents the window from receiving the WM_WINDOWPOSCHANGING message.</summary>
        /// <remarks>SWP_NOSENDCHANGING</remarks>
        DoNotSendChangingEvent = 0x0400,
        /// <summary>Retains the current size (ignores the cx and cy parameters).</summary>
        /// <remarks>SWP_NOSIZE</remarks>
        IgnoreResize = 0x0001,
        /// <summary>Retains the current Z order (ignores the hWndInsertAfter parameter).</summary>
        /// <remarks>SWP_NOZORDER</remarks>
        IgnoreZOrder = 0x0004,
        /// <summary>Displays the window.</summary>
        /// <remarks>SWP_SHOWWINDOW</remarks>
        SWP_SHOWWINDOW = 0x0040,
    }

    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        /*
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, IntPtr windowTitle);
        */

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, IntPtr className, string windowTitle);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool SetWindowText(IntPtr hWnd, String lpString);

        [DllImport("user32.dll")]
        static extern IntPtr WindowFromPoint(System.Drawing.Point p);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        private IntPtr TaskbarHWnd, StartButtonHWnd, Windows10StartMenu;

        public Form1()
        {
            InitializeComponent();
        }

        public const int GWL_EXSTYLE = -20;
        public const int WS_EX_LAYERED = 0x80000;
        public const int LWA_ALPHA = 0x2;
        public const int LWA_COLORKEY = 0x1;

        private void button2_Click(object sender, EventArgs e)
        {
            SetWindowPos(TaskbarHWnd, IntPtr.Zero, 0, 0, 0, 0,
                (int)SetWindowPosFlags.SWP_SHOWWINDOW);
            SetWindowPos(StartButtonHWnd, IntPtr.Zero, 0, 0, 0, 0,
                (int)SetWindowPosFlags.SWP_SHOWWINDOW);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = (IntPtr)hwndNumeric.Value;
            SetWindowText(hWnd, TitleBox.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = (IntPtr)hwndNumeric.Value;
            SetWindowLong(hWnd, -20, GetWindowLong(GetForegroundWindow(), -20) ^ 524288);

            SetLayeredWindowAttributes(hWnd, 0u, (byte)alphaN1.Value, 2u);
        }

        void write(IntPtr hWnd)
        {
            hwndNumeric.Value = (int)hWnd;

            int nRet;
            // Pre-allocate 256 characters, since this is the maximum class name length.
            StringBuilder ClassName = new StringBuilder(256);
            //Get the window class name
            nRet = GetClassName(hWnd, ClassName, ClassName.Capacity);
            classnameBox.Text = ClassName.ToString();

            // Pre-allocate 256 characters, since this is the maximum class name length.
            StringBuilder WindowName = new StringBuilder(256);
            //Get the window class name
            nRet = GetWindowText(hWnd, WindowName, WindowName.Capacity);
            WinTextBox.Text = WindowName.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            IntPtr hWnd = IntPtr.Zero;
            if (searchBox.Text != "")
            {
                foreach (Process pList in Process.GetProcesses())
                {
                    if (pList.MainWindowTitle.Contains(searchBox.Text)) //nome finestra principale
                    {
                        hWnd = pList.MainWindowHandle;
                    }
                    else if (pList.ProcessName.Contains(searchBox.Text)) //nome proceasso
                    {
                        hWnd = pList.MainWindowHandle;
                    }
                    else //handle diretto
                    {
                        int test = 0;
                        int.TryParse(searchBox.Text, out test);
                        if (test != 0)
                        {
                            hWnd = (IntPtr)test;
                        }
                    }
                }
                write(hWnd);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int milliseconds = (int)delayN.Value;
            Thread.Sleep(milliseconds);

            IntPtr hWnd = WindowFromPoint(new Point((int)xN.Value, (int)yN.Value));
            //SetWindowLong(hWnd, -20, GetWindowLong(GetForegroundWindow(), -20) ^ 524288);

            write(hWnd);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SetWindowLong(Handle, GWL_EXSTYLE, GetWindowLong(Handle, GWL_EXSTYLE) ^ WS_EX_LAYERED);

            //SetLayeredWindowAttributes((IntPtr)1442238, 0, 128, LWA_ALPHA);
            //IntPtr ptr = 1442238;
            //SetLayeredWindowAttributes((IntPtr)1442238, 0u, 80, 2u);
            // Get the taskbar's and start button's window handles.
            TaskbarHWnd = FindWindow("Shell_traywnd", "");

            Windows10StartMenu = FindWindow("Windows.UI.Core.CoreWindow", "Start");

            StartButtonHWnd = FindWindowEx(IntPtr.Zero, IntPtr.Zero, (IntPtr)0xC017, null);

            
            SetWindowLong(TaskbarHWnd, -20, GetWindowLong(GetForegroundWindow(), -20) ^ 524288);
            SetWindowLong(Windows10StartMenu, -20, GetWindowLong(GetForegroundWindow(), -20) ^ 524288);

            // Hide the taskbar and start button.
            //SetWindowPos(TaskbarHWnd, IntPtr.Zero, 0, 0, 0, 0, (int)SetWindowPosFlags.SWP_HIDEWINDOW);
            SetLayeredWindowAttributes(TaskbarHWnd, 0u, (byte)alphaN2.Value, 2u);
            SetLayeredWindowAttributes(Windows10StartMenu, 0u, (byte)alphaN2.Value, 2u);
            //SetWindowPos(StartButtonHWnd, IntPtr.Zero, 0, 0, 0, 0, (int)SetWindowPosFlags.SWP_HIDEWINDOW);

            // Maximize.
            //this.Bounds = Screen.PrimaryScreen.Bounds;
        }
    }
}
