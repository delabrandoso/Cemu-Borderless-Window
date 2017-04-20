using System;
using System.Linq;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CBW
{
    public partial class autoLauncher : Form
    {
        //Import window changing function
        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        //Import find window finding function
        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

        //Import force window draw function
        [DllImport("user32.dll")]
        static extern bool DrawMenuBar(IntPtr hWnd);

        //Import window placement function
        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);

        private const int gwlStyle = -16;
        private const int wsBorder = 0x00800000;
        private const int wsCaption = 0x00C00000;
        private const int wsSysMenu = 0x00080000;
        private const int wsMinimizeBox = 0x00020000;
        private const int wsMenuStrip = 19;
        Screen[] screens = Screen.AllScreens;
        int currentScreen = 0;
        int maxScreens = 0;
        private IntPtr window;

        public autoLauncher()
        {
            InitializeComponent();
        }

        public static bool checkIfProcessIsRunning(string nameSubstring)
        {
            return Process.GetProcessesByName(nameSubstring).Length > 0
                && Process.GetProcessesByName(nameSubstring)[0].MainWindowHandle != null;
        }

        public static IntPtr getProcess(string nameSubstring)
        {
            return Process.GetProcessesByName(nameSubstring)[0].MainWindowHandle;
        }

        public bool launchProgram(string executableName)
        {
            // Set current directory, must be located alongside executableName.exe
            String currentDir = AppDomain.CurrentDomain.BaseDirectory;

            // Try starting executableName.exe
            try
            {
                Process.Start(currentDir + "/" + executableName + ".exe");
                return true;
            }
            catch
            {
                MessageBox.Show("Failed to start " + executableName, "Cemu Borderless Window");
                return false;
            }

        }

        public void moveToNextScreen()
        {
            if (window != null)
            {
                if (currentScreen < maxScreens)
                {
                    currentScreen += 1;
                } else
                {
                    currentScreen = 0;
                }
                setWindow();
            }
        }

        public void killProgram(string executableName)
        {
            // Try killing executableName
            if (checkIfProcessIsRunning(executableName)) {
                try
                {
                    Process.GetProcessesByName(executableName)[0].CloseMainWindow();
                    if (checkIfProcessIsRunning(executableName))
                    {
                        Process.GetProcessesByName(executableName)[0].Kill();
                    }
                }
                catch
                {
                    MessageBox.Show("Failed to kill " + executableName, "Cemu Borderless Window");
                }
            }
            else
            {
                MessageBox.Show(executableName + " is not running.", "Cemu Borderless Window");
            }

        }

        private void buttonLaunchCemu_Click(object sender, EventArgs e)
        {
            if (window == null || !checkIfProcessIsRunning("Cemu"))
            {
                if (launchProgram("Cemu"))
                {
                    // Wait 2 seconds for it to launch before getting window info and setting
                    System.Threading.Thread.Sleep(2000);
                }
            }
            if (checkIfProcessIsRunning("Cemu"))
            {
                window = getProcess("Cemu");
                setWindow();
            }
            
        }

        private void buttonCloseCemu_Click(object sender, EventArgs e)
        {
            killProgram("Cemu");
            Taskbar.Show();
        }

        private void buttonSwitchScreens_Click(object sender, EventArgs e)
        {
            moveToNextScreen();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
            Process.GetCurrentProcess().Kill();
        }

        public void setWindow()
        {
            if (maxScreens == 0)
            {
                maxScreens = screens.Length - 1;
            }
            if (chkCBW.CheckState == CheckState.Checked)
            {
                if (chkShowMenuStrip.CheckState == CheckState.Checked)
                {
                    try
                    {
                        SetWindowLong(window, gwlStyle, wsSysMenu);
                        SetWindowPos(window, 0, screens[currentScreen].Bounds.X, screens[currentScreen].Bounds.Y, screens[currentScreen].Bounds.Width, screens[currentScreen].Bounds.Height + wsMenuStrip, 0x0040);
                        DrawMenuBar(window);
                    }
                    catch
                    {
                        MessageBox.Show("Failed to properly place Cemu into borderless window mode with menu.", "Cemu Borderless Window");
                    }
                }
                else
                {
                    try
                    {
                        SetWindowLong(window, gwlStyle, wsSysMenu);
                        SetWindowPos(window, 0, screens[currentScreen].Bounds.X, screens[currentScreen].Bounds.Y - wsMenuStrip, screens[currentScreen].Bounds.Width, screens[currentScreen].Bounds.Height + wsMenuStrip, 0x0040);
                        DrawMenuBar(window);
                    }
                    catch
                    {
                        MessageBox.Show("Failed to properly place Cemu into borderless window mode.", "Cemu Borderless Window");
                    }
                }

            }
            else
            {
                try
                {
                    SetWindowLong(window, gwlStyle, wsCaption | wsBorder | wsSysMenu | wsMinimizeBox);
                    SetWindowPos(window, 0, screens[currentScreen].Bounds.X, screens[currentScreen].Bounds.Y, 1280, 770, 0x0040);
                    DrawMenuBar(window);
                }
                catch
                {
                    MessageBox.Show("Failed to properly place Cemu into windowed mode.", "Cemu Borderless Window");
                }
            }

        }

        private void chkCBW_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCBW.CheckState == CheckState.Unchecked)
            {
                chkShowMenuStrip.CheckState = CheckState.Unchecked;
                chkShowMenuStrip.AutoCheck = false;
                chkShowMenuStrip.Enabled = false;
            }
            else
            {
                chkShowMenuStrip.AutoCheck = true;
                chkShowMenuStrip.Enabled = true;
            }
            if (checkIfProcessIsRunning("Cemu"))
            {
                setWindow();
            }

        }

        private void chkShowMenuStrip_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIfProcessIsRunning("Cemu"))
            {
                setWindow();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Taskbar.Show();
            this.Icon = Properties.Resources.CBW;

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Taskbar.Show();
        }
    }
}
