using System;
using System.IO;
using System.Windows.Forms;

namespace ZombieWorld3 {

    public partial class paragonScreen : UserControl {

        public paragonScreen() {
            InitializeComponent();
            l1.Hide();
            textBox1.Text = "100";
            textBox2.Text = "2500";
            textBox3.Text = "1000";
            textBox4.Text = "100";
            textBox5.Text = "1000";
            textBox6.Text = "1000";
            textBox7.Text = "1000";
            textBox8.Text = "5000";
            textBox9.Text = "20";
            textBox10.Text = "1000";
            textBox11.Text = "100";
            textBox12.Text = "100";
            textBox14.Text = "10";
            textBox15.Text = "50";
            textBox16.Text = "500";
            textBox17.Text = "25";
            textBox18.Text = "100";
            textBox19.Text = "100";
            textBox20.Text = "100";
            textBox13.Text = "50";
            textBox21.Text = "10";
        }

        public int pointsYouWant, lv_talentPoints, lv_damagePoints, lv_movespeedPoints, lv_lifePoints, lv_shieldPoints, lv_shieldRegenerationPoints, lv_mineralStart, lv_respawnSpeedPoints,
            lv_lifeRegenPoints, lv_lifeArmorBonusPoints, lv_lifeArmorMultiplyPoints, lv_vespeneStartPoints, lv_energyPoints, lv_energyRegenPoints, lv_shieldArmorMultiplyPoints, lv_damageReductionPoints,
            lv_shieldArmorBonusPoints, lv_cooldownPoints, lv_expPoints, lv_mastery, lv_prestige;

        public string filePath = string.Empty;
        public int value;

        private void getAndCalcValues() {
            value = Convert.ToInt32(textBox2.Text);
            pointsYouWant = value * 5;
            lv_talentPoints = Convert.ToInt32(textBox2.Text) * (9999 - (16 + value));
            lv_damagePoints = Convert.ToInt32(textBox3.Text) * stupidCalc();
            lv_movespeedPoints = Convert.ToInt32(textBox4.Text) * stupidCalc();
            lv_lifePoints = Convert.ToInt32(textBox5.Text) * stupidCalc();
            lv_shieldPoints = Convert.ToInt32(textBox6.Text) * stupidCalc();
            lv_shieldRegenerationPoints = Convert.ToInt32(textBox7.Text) * stupidCalc();
            lv_mineralStart = Convert.ToInt32(textBox8.Text) * stupidCalc();
            lv_respawnSpeedPoints = Convert.ToInt32(textBox9.Text) * stupidCalc();
            lv_lifeRegenPoints = Convert.ToInt32(textBox10.Text) * stupidCalc();
            lv_lifeArmorBonusPoints = Convert.ToInt32(textBox1.Text) * stupidCalc();
            lv_lifeArmorMultiplyPoints = Convert.ToInt32(textBox11.Text) * stupidCalc();
            lv_vespeneStartPoints = Convert.ToInt32(textBox16.Text) * stupidCalc();
            lv_energyPoints = Convert.ToInt32(textBox19.Text) * stupidCalc();
            lv_energyRegenPoints = Convert.ToInt32(textBox18.Text) * stupidCalc();
            lv_shieldArmorMultiplyPoints = Convert.ToInt32(textBox12.Text) * stupidCalc();
            lv_damageReductionPoints = Convert.ToInt32(textBox14.Text) * stupidCalc();
            lv_shieldArmorBonusPoints = Convert.ToInt32(textBox15.Text) * stupidCalc();
            lv_cooldownPoints = Convert.ToInt32(textBox17.Text) * stupidCalc();
            lv_expPoints = Convert.ToInt32(textBox20.Text) * stupidCalc();
            lv_mastery = Convert.ToInt32(textBox13.Text) * stupidCalc();
            lv_prestige = Convert.ToInt32(textBox21.Text) * (505 - (16 + value));
            if (Convert.ToInt32(textBox21.Text) > 10) {
                lv_prestige = 10 * (505 - (16 + value)); // Prevents from get set to 0.
            }
        }

        private void WriteIntoBankfileWithSignature() {
            if (Main.playerHandle.StartsWith("1-")) {
                string[] accountNumbers = Directory.GetDirectories(Main.path,Main.playerHandle,SearchOption.AllDirectories);
                filePath = accountNumbers[0] + @"\Banks\" + Main.USBankFile;
                string[] array = File.ReadAllLines(filePath);
                for (int y = 0;y < array.Length;y++) {
                    string line = array[y];
                    if (line.Contains("PlayerID") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + pointsYouWant.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("InfoNumber") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_talentPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("DamagePoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_damagePoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("MoveSpeedPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_movespeedPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("LifePoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_lifePoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("ShieldPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_shieldPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("ShieldRegenerationPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_shieldRegenerationPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("MineralStartPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_mineralStart.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("RespawnSpeedPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_respawnSpeedPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("LifeRegenPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_lifeRegenPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("LifeArmorBonusPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_lifeArmorBonusPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("LifeArmorMultiplyPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_lifeArmorMultiplyPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("VespeneStartPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_vespeneStartPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("EnergyPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_energyPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("EnergyRegenPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_energyRegenPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("YOUR KILLS WILL BE RESET IF YOU ATTEMPT TO HACK ANYTHING") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_shieldArmorMultiplyPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("DamageReductionPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_damageReductionPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("ShieldArmorBonusPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_shieldArmorBonusPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("CooldownPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_cooldownPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("ExpPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_expPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("MasteryPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_mastery.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("Plays") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_prestige.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("Signature value")) {
                        BankSign.Sign("1-S2-1-8298616",Main.playerHandle,"zombieworldu",filePath);
                        Methods.lineChanger("    <Signature value=\"" + BankSign.signString + "\"/>",filePath,y);
                        //successLabel();
                    }
                }
            }
            if (Main.playerHandle.StartsWith("2-")) {
                string[] accountNumbers = Directory.GetDirectories(Main.path,Main.playerHandle,SearchOption.AllDirectories);
                filePath = accountNumbers[0] + @"\Banks\" + Main.EUBankFile;
                string[] array = File.ReadAllLines(filePath);
                for (int y = 0;y < array.Length;y++) {
                    string line = array[y];
                    if (line.Contains("PlayerID") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + pointsYouWant.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("InfoNumber") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_talentPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("DamagePoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_damagePoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("MoveSpeedPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_movespeedPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("LifePoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_lifePoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("ShieldPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_shieldPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("ShieldRegenerationPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_shieldRegenerationPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("MineralStartPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_mineralStart.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("RespawnSpeedPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_respawnSpeedPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("LifeRegenPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_lifeRegenPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("LifeArmorBonusPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_lifeArmorBonusPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("LifeArmorMultiplyPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_lifeArmorMultiplyPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("VespeneStartPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_vespeneStartPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("EnergyPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_energyPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("EnergyRegenPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_energyRegenPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("YOUR KILLS WILL BE RESET IF YOU ATTEMPT TO HACK ANYTHING") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_shieldArmorMultiplyPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("DamageReductionPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_damageReductionPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("ShieldArmorBonusPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_shieldArmorBonusPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("CooldownPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_cooldownPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("ExpPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_expPoints.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("MasteryPoints") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_mastery.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("Plays") && line.Contains("Key name")) {
                        Methods.lineChanger("                  <Value int=\"" + lv_prestige.ToString() + "\"/>",filePath,y + 1);
                    }
                    if (line.Contains("Signature value")) {
                        BankSign.Sign("2-S2-1-7593740",Main.playerHandle,"zombieworldu",filePath);
                        Methods.lineChanger("    <Signature value=\"" + BankSign.signString + "\"/>",filePath,y);
                        //successLabel();
                    }
                }
            }
        }

        public int stupidCalc() {
            return (999 - (16 + value));
        }

        private void rjButton1_Click(object sender,EventArgs e) {
            rTB.Clear();
            getAndCalcValues();
            rTB.AppendText("Writing Values to Bankfile..." + Environment.NewLine);
            rTB.AppendText("Writing Done." + Environment.NewLine);
            rTB.AppendText(" " + Environment.NewLine);
            WriteIntoBankfileWithSignature();
            rTB.AppendText("Writing Signature..." + Environment.NewLine);
            rTB.AppendText("Signature Done." + Environment.NewLine);
            rTB.AppendText(" " + Environment.NewLine);
            rTB.AppendText("Ready to Play!" + Environment.NewLine);
        }
    }
}