using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ZombieWorld3 {

    public partial class Main : Form {

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse);

        public static string SLDHandle;
        public static string pathN = Path.GetPathRoot(Environment.SystemDirectory);
        public static string winUserName = Environment.UserName;
        public static string finalPath;
        public static string bankFile = "|||||.SC2Bank";
        public static bool error = true;

        private void move_window(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public Main() {
            try {
                InitializeComponent();
                FormBorderStyle = FormBorderStyle.None;
                Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
                Assign(this);

                hideAllandShow(homeScreen1);
                /*
                pathN = pathN + @"Users\" + winUserName + @"\Documents\StarCraft II\Accounts\";
                string[] accountNumbers = Directory.GetDirectories(pathN, "*", SearchOption.TopDirectoryOnly);
                if (accountNumbers != null) {
                    for (int i = 0; i < accountNumbers.Length; i++) {
                        string[] handleNamesNA = Directory.GetDirectories(accountNumbers[i], "*1-S2*", SearchOption.TopDirectoryOnly);
                        if (handleNamesNA != null) {
                            for (int a = 0; a < handleNamesNA.Length; a++) {
                                string[] handleNamesEU = Directory.GetDirectories(accountNumbers[i], "*2-S2*", SearchOption.TopDirectoryOnly);
                                if (handleNamesEU != null) {
                                    for (int b = 0; b < handleNamesEU.Length; b++) {
                                        if (!handleNamesEU[b].StartsWith("3-S2")) {
                                            comboBox1.Items.Add(new DirectoryInfo(handleNamesEU[b]).Name);
                                        }
                                    }
                                }
                                if (!handleNamesNA[a].StartsWith("3-S2")) {
                                    comboBox1.Items.Add(new DirectoryInfo(handleNamesNA[a]).Name);
                                }
                            }
                        }
                    }
                } else { comboBox1.Text = "No Accounts found"; }
            */
            } catch { comboBox1.Text = "No Accounts found"; }
        }

        private void button1_Click(object sender, EventArgs e) {
            Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e) {
            button1.ForeColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e) {
            button1.ForeColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e) {
            // System.Diagnostics.Process.Start("http://www.d3scene.com/forum/members/sterillium.html");
        }

        private void comboBox1_Enter(object sender, EventArgs e) {
            comboBox1.BackColor = Color.White;
        }

        private void comboBox1_Leave(object sender, EventArgs e) {
            string t = comboBox1.Text;
            if (!string.IsNullOrEmpty(comboBox1.Text) &&
              !string.IsNullOrWhiteSpace(comboBox1.Text) &&
              comboBox1.Text != "1-S2-1-717232" &&
              comboBox1.Text != "2-S2-1-4013551" &&
              comboBox1.Text != "x-S2-x-xxxxxxx" &&
              t.Substring(1, 1) == "-" &&
              t.Substring(4, 1) == "-" &&
              t.Substring(6, 1) == "-" &&
              t.Substring(2, 1).ToLower() == "s" &&
              Regex.IsMatch(t, "[A-Ra-rT-Zt-z]") == false) {
                SLDHandle = comboBox1.Text;
                error = false;
            } else {
                comboBox1.Text = "Wrong Handle";
                comboBox1.BackColor = Color.Red;

                error = true;
            }
            SLDHandle = comboBox1.Text;
        }

        private void Assign(Control control) {
            foreach (Control ctrl in control.Controls) {
                if (ctrl is ComboBox) {
                    ComboBox tb = (ComboBox)ctrl;
                    tb.TextChanged += new EventHandler(tb_TextChanged);
                } else { Assign(ctrl); }
            }
        }

        private void tb_TextChanged(object sender, EventArgs e) {
            ComboBox tb = (ComboBox)sender; string n = tb.Text;
            if (n.StartsWith("3-")) { tb.Text = "Nope"; }
        }

        private void button2_Click(object sender, EventArgs e) {
            hideAllandShow(killsScore1);
        }

        private void button6_Click(object sender, EventArgs e) {
            hideAllandShow(homeScreen1);
        }

        public void hideAllandShow(Control s) {
            homeScreen1.Hide();
            killsScore1.Hide();
            s.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e) {
        }

        private void button7_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        private void button7_MouseEnter(object sender, EventArgs e) {
            button7.ForeColor = Color.Red;
        }

        private void button7_MouseLeave(object sender, EventArgs e) {
            button7.ForeColor = Color.White;
        }

        private void button5_Click(object sender,EventArgs e) {

        }
    }
}