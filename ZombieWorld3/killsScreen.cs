using System;
using System.IO;
using System.Windows.Forms;

namespace ZombieWorld3 {

    public partial class killsScreen : UserControl {

        public killsScreen() {
            InitializeComponent();
            textBox1.Text = "9999999";
            textBox2.Text = "9999999";
            textBox3.Text = "9999999";
            textBox4.Text = "9999999";
            textBox5.Text = "9999999";
            textBox6.Text = "9999999";
            textBox7.Text = "9999999";
        }

        public string filePath = string.Empty;

        private void rjButton1_Click(object sender,EventArgs e) {
            rTB.Clear();
            if (Main.playerHandle.StartsWith("1-")) {
                string[] accountNumbers = Directory.GetDirectories(Main.path,Main.playerHandle,SearchOption.AllDirectories);
                filePath = accountNumbers[0] + @"\Banks\" + Main.USBankFile;
                string[] array = File.ReadAllLines(filePath);
                for (int y = 0;y < array.Length;y++) {
                    string line = array[y];

                    if (line.Contains("specialistkills") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + textBox1.Text + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("singletargetkills") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + textBox2.Text + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("assassinkills") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + textBox3.Text + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("supportkills") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + textBox4.Text + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("splashkills") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + textBox5.Text + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("tankkills") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + textBox6.Text + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("builderkills") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + textBox7.Text + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("Signature value")) {
                        BankSign.Sign("1-S2-1-8298616",Main.playerHandle,"zombieworldu",filePath);
                        Methods.lineChanger("    <Signature value=\"" + BankSign.signString + "\"/>",filePath,y);
                    }
                }
                rTB.AppendText("Writing Values to Bankfile..." + Environment.NewLine);
                rTB.AppendText("Writing Done." + Environment.NewLine);
                rTB.AppendText(" " + Environment.NewLine);
                rTB.AppendText("Writing Signature..." + Environment.NewLine);
                rTB.AppendText("Signature Done." + Environment.NewLine);
                rTB.AppendText(" " + Environment.NewLine);
                rTB.AppendText("Ready to Play!" + Environment.NewLine);
            }
            if (Main.playerHandle.StartsWith("2-")) {
                string[] accountNumbers = Directory.GetDirectories(Main.path,Main.playerHandle,SearchOption.AllDirectories);
                filePath = accountNumbers[0] + @"\Banks\" + Main.EUBankFile;
                string[] array = File.ReadAllLines(filePath);
                for (int y = 0;y < array.Length;y++) {
                    string line = array[y];
                    if (line.Contains("specialistkills") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + textBox1.Text + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("singletargetkills") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + textBox2.Text + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("assassinkills") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + textBox3.Text + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("supportkills") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + textBox4.Text + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("splashkills") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + textBox5.Text + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("tankkills") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + textBox6.Text + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("builderkills") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + textBox7.Text + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("Signature value")) {
                        BankSign.Sign("2-S2-1-7593740",Main.playerHandle,"zombieworldu",filePath);
                        Methods.lineChanger("    <Signature value=\"" + BankSign.signString + "\"/>",filePath,y);
                    }
                }
                rTB.AppendText("Writing Values to Bankfile..." + Environment.NewLine);
                rTB.AppendText("Writing Done." + Environment.NewLine);
                rTB.AppendText(" " + Environment.NewLine);
                rTB.AppendText("Writing Signature..." + Environment.NewLine);
                rTB.AppendText("Signature Done." + Environment.NewLine);
                rTB.AppendText(" " + Environment.NewLine);
                rTB.AppendText("Ready to Play!" + Environment.NewLine);
            }
        }

    }
}