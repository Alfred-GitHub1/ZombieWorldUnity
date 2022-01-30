using System;
using System.IO;
using System.Windows.Forms;

namespace ZombieWorld3 {

    public partial class challengesScreen : UserControl {

        public challengesScreen() {
            InitializeComponent();
        }

        public string filePath = string.Empty;

        public void InsertStuff() {
            Methods.InsertLine(filePath,@"    </Section>",2);
            Methods.InsertLine(filePath,@"        </Key>",2);
            Methods.InsertLine(filePath,@"            <Value flag=""1""/>",2);
            Methods.InsertLine(filePath,@"        <Key name=""CLShieldProblems"">",2);
            Methods.InsertLine(filePath,@"        </Key>",2);
            Methods.InsertLine(filePath,@"            <Value flag=""1""/>",2);
            Methods.InsertLine(filePath,@"        <Key name=""CLTorture1"">",2);
            Methods.InsertLine(filePath,@"        </Key>",2);
            Methods.InsertLine(filePath,@"            <Value flag=""1""/>",2);
            Methods.InsertLine(filePath,@"        <Key name=""CLInfantry"">",2);
            Methods.InsertLine(filePath,@"        </Key>",2);
            Methods.InsertLine(filePath,@"            <Value flag=""1""/>",2);
            Methods.InsertLine(filePath,@"        <Key name=""CLEvasive"">",2);
            Methods.InsertLine(filePath,@"        </Key>",2);
            Methods.InsertLine(filePath,@"            <Value flag=""1""/>",2);
            Methods.InsertLine(filePath,@"        <Key name=""CLConstructor"">",2);
            Methods.InsertLine(filePath,@"        </Key>",2);
            Methods.InsertLine(filePath,@"            <Value flag=""1""/>",2);
            Methods.InsertLine(filePath,@"        <Key name=""CLWarpspeed"">",2);
            Methods.InsertLine(filePath,@"        </Key>",2);
            Methods.InsertLine(filePath,@"            <Value flag=""1""/>",2);
            Methods.InsertLine(filePath,@"        <Key name=""CLNextToDead"">",2);
            Methods.InsertLine(filePath,@"        </Key>",2);
            Methods.InsertLine(filePath,@"            <Value flag=""1""/>",2);
            Methods.InsertLine(filePath,@"        <Key name=""CLTeamGame"">",2);
            Methods.InsertLine(filePath,@"    <Section name=""Challenges"">",2);
        }

        private void button1_Click(object sender,EventArgs e) {
            rTB.Clear();
            if (Main.playerHandle.StartsWith("1-")) {
                string[] accountNumbers = Directory.GetDirectories(Main.path,Main.playerHandle,SearchOption.AllDirectories);
                filePath = accountNumbers[0] + @"\Banks\" + Main.USBankFile;
                Methods.RemoveChallenges(filePath);
                InsertStuff();
                string[] array = File.ReadAllLines(filePath);
                rTB.AppendText("Writing Values to Bankfile..." + Environment.NewLine);
                rTB.AppendText("Writing Done." + Environment.NewLine);
                rTB.AppendText(" " + Environment.NewLine);
                for (int y = 0;y < array.Length;y++) {
                    string line = array[y];
                    if (line.Contains("Signature value")) {
                        BankSign.Sign("1-S2-1-8298616",Main.playerHandle,"zombieworldu",filePath);
                        Methods.lineChanger("    <Signature value=\"" + BankSign.signString + "\"/>",filePath,y);
                    }
                }
                rTB.AppendText("Writing Signature..." + Environment.NewLine);
                rTB.AppendText("Signature Done." + Environment.NewLine);
                rTB.AppendText(" " + Environment.NewLine);
                rTB.AppendText("Ready to Play!" + Environment.NewLine);
            }
            if (Main.playerHandle.StartsWith("2-")) {
                string[] accountNumbers = Directory.GetDirectories(Main.path,Main.playerHandle,SearchOption.AllDirectories);
                filePath = accountNumbers[0] + @"\Banks\" + Main.EUBankFile;
                Methods.RemoveChallenges(filePath);
                InsertStuff();
                string[] array = File.ReadAllLines(filePath);
                rTB.AppendText("Writing Values to Bankfile..." + Environment.NewLine);
                rTB.AppendText("Writing Done." + Environment.NewLine);
                rTB.AppendText(" " + Environment.NewLine);
                for (int y = 0;y < array.Length;y++) {
                    string line = array[y];
                    if (line.Contains("Signature value")) {
                        BankSign.Sign("2-S2-1-7593740",Main.playerHandle,"zombieworldu",filePath);
                        Methods.lineChanger("    <Signature value=\"" + BankSign.signString + "\"/>",filePath,y);
                    }
                }
                rTB.AppendText("Writing Signature..." + Environment.NewLine);
                rTB.AppendText("Signature Done." + Environment.NewLine);
                rTB.AppendText(" " + Environment.NewLine);
                rTB.AppendText("Ready to Play!" + Environment.NewLine);
            }
        }
    }
}