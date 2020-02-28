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
        private IntPtr TaskbarHWnd, StartButtonHWnd, Windows10StartMenu;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Win32.SetWindowPos(TaskbarHWnd, IntPtr.Zero, 0, 0, 0, 0,
                (int)SetWindowPosFlags.SWP_SHOWWINDOW);
            Win32.SetWindowPos(StartButtonHWnd, IntPtr.Zero, 0, 0, 0, 0,
                (int)SetWindowPosFlags.SWP_SHOWWINDOW);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = (IntPtr)hwndNumeric.Value;
            Win32.SetWindowText(hWnd, TitleBox.Text);
        }

        void write(IntPtr hWnd)
        {
            hwndNumeric.Value = (int)hWnd;

            int nRet;
            // Pre-allocate 256 characters, since this is the maximum class name length.
            StringBuilder ClassName = new StringBuilder(256);
            //Get the window class name
            nRet = Win32.GetClassName(hWnd, ClassName, ClassName.Capacity);
            classnameBox.Text = ClassName.ToString();

            // Pre-allocate 256 characters, since this is the maximum class name length.
            StringBuilder WindowName = new StringBuilder(256);
            //Get the window class name
            nRet = Win32.GetWindowText(hWnd, WindowName, WindowName.Capacity);
            WinTextBox.Text = WindowName.ToString();
        }

        void remove(IntPtr hWnd)
        {
            searchresults.Items.Remove(hWnd);
            clean();
        }

        void clean()
        {
            searchresults.Items.Remove(searchresults.SelectedItem);
            pictureBox1.Image = null;
            pid_lbl.Text = "PID: -";
            Pname_lbl.Text = "Process name: -";
            write(IntPtr.Zero);
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = (IntPtr)hwndNumeric.Value;
            Win32.SendMessage(hWnd, force_close.Checked ? WM.DESTROY : WM.CLOSE, IntPtr.Zero, IntPtr.Zero);
            if (!Win32.IsWindow(hWnd))
            {
                if (searchresults.Items.Contains(hWnd))
                {
                    remove(hWnd);
                }
            }
            else
            {
                uint processId;
                Win32.GetWindowThreadProcessId(hWnd, out processId);
                Process process = Process.GetProcessById((int)processId);
                if (!force_close.Checked)
                {
                    MessageBox.Show("Not able to close the hWnd. Try to force the closure or close the whole "+ process .ProcessName+ " process.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Not able to close the hWnd. Try to close the whole " + process.ProcessName + " process.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void maximize_btn_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = (IntPtr)hwndNumeric.Value;
            Win32.ShowWindow(hWnd, ShowWindowCommands.Maximize);
        }

        private void window_btn_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = (IntPtr)hwndNumeric.Value;
            Win32.ShowWindow(hWnd, ShowWindowCommands.Normal);
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = (IntPtr)hwndNumeric.Value;
            Win32.ShowWindow(hWnd, ShowWindowCommands.Minimize);
        }

        private void close_btn_MouseEnter(object sender, EventArgs e)
        {
            close_btn.Image = Properties.Resources.close2;
        }

        private void close_btn_MouseLeave(object sender, EventArgs e)
        {
            close_btn.Image = Properties.Resources.close1;
        }

        private void alphaN2_Scroll(object sender, EventArgs e)
        {
            TaskbarHWnd = Win32.FindWindow("Shell_traywnd", "");
            Windows10StartMenu = Win32.FindWindow("Windows.UI.Core.CoreWindow", "Start");
            StartButtonHWnd = Win32.FindWindowEx(IntPtr.Zero, IntPtr.Zero, (IntPtr)0xC017, null);

            Win32.SetWindowLong(TaskbarHWnd, -20, Win32.GetWindowLong(Win32.GetForegroundWindow(), -20) ^ 524288);
            Win32.SetWindowLong(Windows10StartMenu, -20, Win32.GetWindowLong(Win32.GetForegroundWindow(), -20) ^ 524288);

            Win32.SetLayeredWindowAttributes(TaskbarHWnd, 0u, (byte)alphaN2.Value, 2u);
            Win32.SetLayeredWindowAttributes(Windows10StartMenu, 0u, (byte)alphaN2.Value, 2u);
            alphaN2_value.Text = alphaN2.Value.ToString();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            List<IntPtr> hWnds = new List<IntPtr>();
            if (searchBox.Text != "")
            {
                foreach (Process pList in Process.GetProcesses())
                {
                    if (pList.ProcessName.ToLower().Contains(searchBox.Text.ToLower()) && pList.MainWindowHandle!=IntPtr.Zero) //process name
                    {
                        hWnds.Add(pList.MainWindowHandle);
                    }
                }
                int test = 0;
                int.TryParse(searchBox.Text, out test);
                if (test != 0)
                {
                    hWnds.Add((IntPtr)test);
                }
                searchresults.Items.Clear();
                List<WindowInformation> wi = WindowList.GetAllWindows(); 
                hWnds.AddRange(wi.Where(list => (list.Class.ToLower().Contains(searchBox.Text.ToLower()) || list.Caption.ToLower().Contains(searchBox.Text.ToLower()))).Select(valid => valid.Handle).ToList());
                int currentPID = Process.GetCurrentProcess().Id;

                hWnds = hWnds.Distinct().ToList();
                uint processId;
                foreach (IntPtr hWnd in hWnds)
                {
                    if (hWnd != IntPtr.Zero)
                    {
                        Win32.GetWindowThreadProcessId(hWnd, out processId);
                        if (processId != currentPID)
                        {
                            searchresults.Items.Add(hWnd);
                        }
                    }
                }
                if (searchresults.Items.Count == 0)
                {
                    clean();
                    MessageBox.Show("No results found.");
                }
                else
                {
                    searchresults.SelectedIndex = 0;
                    searchresults.Focus();
                }
            }
        }

        private void searchresults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchresults.SelectedIndex != -1)
            {
                IntPtr hWnd = (IntPtr)searchresults.SelectedItem;
                if (Win32.IsWindow(hWnd))
                {
                    IntPtr Hicon = Win32.GetClassLongPtr(hWnd, /*GCL_HICON*/ClassLongFlags.GCLP_HICON);

                    uint processId;
                    Win32.GetWindowThreadProcessId(hWnd, out processId);
                    Process process = Process.GetProcessById((int)processId);
                    pid_lbl.Text = "PID:\n" + processId;
                    Pname_lbl.Text = "Process name:\n" + process.ProcessName;
                    try
                    {
                        pictureBox1.Image = Hicon != IntPtr.Zero ? Bitmap.FromHicon(Hicon) : Icon.ExtractAssociatedIcon(process.MainModule.FileName).ToBitmap();
                    }
                    catch (Win32Exception error)
                    {
                        Debug.WriteLine(error.Message);
                    }
                    write(hWnd);
                }
                else
                {
                    int i = searchresults.SelectedIndex;
                    clean();
                    if (searchresults.Items.Count > 0)
                    {
                        searchresults.SelectedIndex = i;
                    }
                }
            }
        }

        private void alphaN1_Scroll(object sender, EventArgs e)
        {
            IntPtr hWnd = (IntPtr)hwndNumeric.Value;
            Win32.SetWindowLong(hWnd, -20, Win32.GetWindowLong(Win32.GetForegroundWindow(), -20) ^ 524288);

            Win32.SetLayeredWindowAttributes(hWnd, 0u, (byte)alphaN1.Value, 2u);
            alphaN1_value.Text = alphaN1.Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int milliseconds = (int)delayN.Value;
            Thread.Sleep(milliseconds);
            IntPtr hWnd = Win32.WindowFromPoint(new Point((int)xN.Value, (int)yN.Value));
            write(hWnd);
        }
    }
}