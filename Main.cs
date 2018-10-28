using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Net;

namespace WinTether
{
    enum WinTetherMessage
    {
        Running,
        NotRunning
    };
    
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        bool running = false;
        WinTetherMessage activity = WinTetherMessage.NotRunning;

        public static bool WifiConnected()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("https://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (activity == WinTetherMessage.NotRunning)
            {
                if (String.IsNullOrEmpty(HotspotNameField.Text.Trim()))
                    HotspotNameField.Focus();
                else if (String.IsNullOrEmpty(Passwd.Text))
                    Passwd.Focus();
                else
                {
                    string SSID = HotspotNameField.Text.Trim();
                    string passwd = Passwd.Text.Trim();

                    if (SSID.Length <= 7)
                        MessageBox.Show("SSID must be greater than 7 characters");
                    else if (passwd.Length <= 7)
                        MessageBox.Show("Password must be greater then 7 charaters");
                    else
                    {
                        try
                        {
                            string[] args = { "wlan set hostednetwork ssid=" + SSID + " key=" + passwd, "wlan start hostednetwork" };

                            var process = new ProcessStartInfo("netsh", args[0])
                            {
                                CreateNoWindow = true,
                                RedirectStandardOutput = true,
                                UseShellExecute = false,
                                WindowStyle = ProcessWindowStyle.Hidden
                            };
                            Process.Start(process);
                            var process0 = new ProcessStartInfo("netsh", args[1])
                            {
                                CreateNoWindow = true,
                                RedirectStandardOutput = true,
                                UseShellExecute = false,
                                WindowStyle = ProcessWindowStyle.Hidden
                            };
                            Process.Start(process0);

                            Controller.Text = "STOP TETHERING";
                            SSID = "";
                            passwd = "";
                            HotspotNameField.Text = "";
                            Passwd.Text = "";

                            HotspotNameField.Enabled = false;
                            Passwd.Enabled = false;

                            activity = WinTetherMessage.Running;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {

                var process0 = new ProcessStartInfo("netsh", "wlan stop hostednetwork")
                {
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    WindowStyle = ProcessWindowStyle.Hidden
                };
                Process.Start(process0);

                HotspotNameField.Enabled = true;
                Passwd.Enabled = true;
                Controller.Text = "START TETHERING";

                activity = WinTetherMessage.NotRunning;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            var action = MessageBox.Show("Do you really want to quit the application?","Alert",MessageBoxButtons.YesNo);
            if (action == DialogResult.Yes)
                Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!IsAdministrator())
            {
                MessageBox.Show("Insufficient privileges, Please run this application with admin rights.", "Warning");
                Application.Exit();
            }
            else if (WifiConnected())
            {
                MessageBox.Show("Please disconnect to the internet to start wifi tethering. Exiting...");
                Application.Exit();
            }
        }
    }
}
