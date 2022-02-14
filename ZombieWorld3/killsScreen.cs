using System;
using System.IO;
using System.Windows.Forms;

namespace ZombieWorld3 {

    public partial class killsScreen : UserControl {

        public killsScreen() {
            InitializeComponent();
            textBox1.Text = "9999999"; textBox2.Text = "9999999"; textBox3.Text = "9999999"; textBox4.Text = "9999999";
            textBox5.Text = "9999999"; textBox6.Text = "9999999"; textBox7.Text = "9999999";
        }

        public string filePath = string.Empty;

        public void SubRoutine(string name,string fieldname,string line,int y) {
            if (line.Contains(name) && line.Contains("Key name")) {
                Methods.lineChanger("                  <Value int=\"" + fieldname + "\"/>",filePath,y + 1);
            }
        }

        public void WriteBank(string BankFile,string HandleOwner) {
            Main.WriteStuff(rTB);
            string[] accountNumbers = Directory.GetDirectories(Main.path,Main.playerHandle,SearchOption.AllDirectories);
            filePath = accountNumbers[0] + @"\Banks\" + BankFile;
            string[] array = File.ReadAllLines(filePath);
            for (int y = 0;y < array.Length;y++) {
                string line = array[y];
                SubRoutine("specialistkills",textBox1.Text,line,y);
                SubRoutine("singletargetkills",textBox2.Text,line,y);
                SubRoutine("assassinkills",textBox3.Text,line,y);
                SubRoutine("supportkills",textBox4.Text,line,y);
                SubRoutine("splashkills",textBox5.Text,line,y);
                SubRoutine("tankkills",textBox6.Text,line,y);
                SubRoutine("builderkills",textBox7.Text,line,y);
                if (line.Contains("Signature value")) {
                    BankSign.Sign(HandleOwner,Main.playerHandle,"zombieworldu",filePath);
                    Methods.lineChanger("    <Signature value=\"" + BankSign.signString + "\"/>",filePath,y);
                    Main.WriteStuff2(rTB);
                }
            }
        }

        private void rjButton1_Click(object sender,EventArgs e) {
            rTB.Clear();
            if (Main.playerHandle.StartsWith("1-")) { WriteBank(Main.USBankFile,"1-S2-1-8298616"); }
            if (Main.playerHandle.StartsWith("2-")) { WriteBank(Main.EUBankFile,"2-S2-1-7593740"); }
        }
    }
}