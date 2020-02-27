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

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool ShowWindow(IntPtr hWnd, ShowWindowCommands nCmdShow);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, IntPtr className, string windowTitle);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool SetWindowText(IntPtr hWnd, String lpString);

        [DllImport("user32.dll")]
        static extern IntPtr WindowFromPoint(System.Drawing.Point p);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        /// <summary>
        /// Find window by Caption only. Note you must pass IntPtr.Zero as the first parameter.
        /// </summary>
        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

        /// <summary>
        /// <para>The DestroyWindow function destroys the specified window. The function sends WM_DESTROY and WM_NCDESTROY messages to the window to deactivate it and remove the keyboard focus from it. The function also destroys the window's menu, flushes the thread message queue, destroys timers, removes clipboard ownership, and breaks the clipboard viewer chain (if the window is at the top of the viewer chain).</para>
        /// <para>If the specified window is a parent or owner window, DestroyWindow automatically destroys the associated child or owned windows when it destroys the parent or owner window. The function first destroys child or owned windows, and then it destroys the parent or owner window.</para>
        /// <para>DestroyWindow also destroys modeless dialog boxes created by the CreateDialog function.</para>
        /// </summary>
        /// <param name="hwnd">Handle to the window to be destroyed.</param>
        /// <returns>If the function succeeds, the return value is nonzero. If the function fails, the return value is zero. To get extended error information, call GetLastError.</returns>
        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool DestroyWindow(IntPtr hwnd);
        private IntPtr TaskbarHWnd, StartButtonHWnd, Windows10StartMenu;

        public Form1()
        {
            InitializeComponent();
        }

        const int GWL_EXSTYLE = -20;
        const int WS_EX_LAYERED = 0x80000;
        const int LWA_ALPHA = 0x2;
        const int LWA_COLORKEY = 0x1;
        const uint WM_CLOSE = 0x10;
        const uint WM_QUIT = 0x12;
        const uint WM_DESTROY = 0x02;
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_CLOSE = 0xF060;


        private void button2_Click(object sender, EventArgs e)
        {
            SetWindowPos(TaskbarHWnd, IntPtr.Zero, 0, 0, 0, 0,
                (int)SetWindowPosFlags.SWP_SHOWWINDOW);
            SetWindowPos(StartButtonHWnd, IntPtr.Zero, 0, 0, 0, 0,
                (int)SetWindowPosFlags.SWP_SHOWWINDOW);
        }

        public void CloseWindow(IntPtr hWindow)
        {

            SendMessage(hWindow, force_close.Checked ? WM_DESTROY : WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            if (force_close.Checked)
            {
                SendMessage(hWindow, WM_DESTROY, IntPtr.Zero, IntPtr.Zero);
            }
            else
            {
                SendMessage(hWindow, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            }
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
                    if (pList.MainWindowTitle.ToLower().Contains(searchBox.Text.ToLower())) //name of the main window
                    {
                        hWnd = pList.MainWindowHandle;
                    }
                    else if (pList.ProcessName.ToLower().Contains(searchBox.Text.ToLower())) //process name
                    {
                        hWnd = pList.MainWindowHandle;
                    }
                    else if (hWnd == IntPtr.Zero)
                    {
                        hWnd = FindWindowByCaption(IntPtr.Zero, searchBox.Text);
                        if (hWnd == IntPtr.Zero) //direct handle
                        {
                            int test = 0;
                            int.TryParse(searchBox.Text, out test);
                            if (test != 0)
                            {
                                hWnd = (IntPtr)test;
                            }
                        }
                    }
                }
                write(hWnd);
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = (IntPtr)hwndNumeric.Value;
            SendMessage(hWnd, force_close.Checked ? WM_DESTROY : WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
        }

        private void maximize_btn_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = (IntPtr)hwndNumeric.Value;
            ShowWindow(hWnd, ShowWindowCommands.Maximize);
        }

        private void window_btn_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = (IntPtr)hwndNumeric.Value;
            ShowWindow(hWnd, ShowWindowCommands.Normal);
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = (IntPtr)hwndNumeric.Value;
            ShowWindow(hWnd, ShowWindowCommands.Minimize);
        }

        private void close_btn_MouseEnter(object sender, EventArgs e)
        {
            close_btn.Image = Properties.Resources.close2;
        }

        private void close_btn_MouseLeave(object sender, EventArgs e)
        {
            close_btn.Image = Properties.Resources.close1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int milliseconds = (int)delayN.Value;
            Thread.Sleep(milliseconds);
            IntPtr hWnd = WindowFromPoint(new Point((int)xN.Value, (int)yN.Value));
            write(hWnd);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaskbarHWnd = FindWindow("Shell_traywnd", "");
            Windows10StartMenu = FindWindow("Windows.UI.Core.CoreWindow", "Start");
            StartButtonHWnd = FindWindowEx(IntPtr.Zero, IntPtr.Zero, (IntPtr)0xC017, null);
            
            SetWindowLong(TaskbarHWnd, -20, GetWindowLong(GetForegroundWindow(), -20) ^ 524288);
            SetWindowLong(Windows10StartMenu, -20, GetWindowLong(GetForegroundWindow(), -20) ^ 524288);

            SetLayeredWindowAttributes(TaskbarHWnd, 0u, (byte)alphaN2.Value, 2u);
            SetLayeredWindowAttributes(Windows10StartMenu, 0u, (byte)alphaN2.Value, 2u);
        }
    }
}
