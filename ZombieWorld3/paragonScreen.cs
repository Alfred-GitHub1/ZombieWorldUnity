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

        public void WriteBank(string BankFile,string HandleOwner) {
            string[] accountNumbers = Directory.GetDirectories(Main.path,Main.playerHandle,SearchOption.AllDirectories);
            filePath = accountNumbers[0] + @"\Banks\" + BankFile;
            string[] array = File.ReadAllLines(filePath);
            for (int y = 0;y < array.Length;y++) {
                string line = array[y];
                Routine(line,y);
                SignRoutine(HandleOwner,line,y);
            }
        }

        private void WriteIntoBankfileWithSignature() {
            if (Main.playerHandle.StartsWith("1-")) { WriteBank(Main.USBankFile,"1-S2-1-8298616"); }
            if (Main.playerHandle.StartsWith("2-")) { WriteBank(Main.EUBankFile,"2-S2-1-7593740"); }
        }

        public void SignRoutine(string handle,string line,int y) {
            if (line.Contains("Signature value")) {
                BankSign.Sign(handle,Main.playerHandle,"zombieworldu",filePath);
                Methods.lineChanger("    <Signature value=\"" + BankSign.signString + "\"/>",filePath,y);
            }
        }

        public void SubRoutine(string name,int fieldname,string line,int y) {
            if (line.Contains(name) && line.Contains("Key name")) {
                Methods.lineChanger("                  <Value int=\"" + fieldname.ToString() + "\"/>",filePath,y + 1);
            }
        }

        public void Routine(string line,int y) {
            SubRoutine("PlayerID",pointsYouWant,line,y);
            SubRoutine("InfoNumber",lv_talentPoints,line,y);
            SubRoutine("DamagePoints",lv_damagePoints,line,y);
            SubRoutine("MoveSpeedPoints",lv_movespeedPoints,line,y);
            SubRoutine("LifePoints",lv_lifePoints,line,y);
            SubRoutine("ShieldPoints",lv_shieldPoints,line,y);
            SubRoutine("ShieldRegenerationPoints",lv_shieldRegenerationPoints,line,y);
            SubRoutine("MineralStartPoints",lv_mineralStart,line,y);
            SubRoutine("RespawnSpeedPoints",lv_respawnSpeedPoints,line,y);
            SubRoutine("LifeRegenPoints",lv_lifeRegenPoints,line,y);
            SubRoutine("LifeArmorBonusPoints",lv_lifeArmorBonusPoints,line,y);
            SubRoutine("LifeArmorMultiplyPoints",lv_lifeArmorMultiplyPoints,line,y);
            SubRoutine("VespeneStartPoints",lv_vespeneStartPoints,line,y);
            SubRoutine("EnergyPoints",lv_energyPoints,line,y);
            SubRoutine("EnergyRegenPoints",lv_energyRegenPoints,line,y);
            SubRoutine("YOUR KILLS WILL BE RESET IF YOU ATTEMPT TO HACK ANYTHING",lv_shieldArmorMultiplyPoints,line,y);
            SubRoutine("DamageReductionPoints",lv_damageReductionPoints,line,y);
            SubRoutine("ShieldArmorBonusPoints",lv_shieldArmorBonusPoints,line,y);
            SubRoutine("CooldownPoints",lv_cooldownPoints,line,y);
            SubRoutine("ExpPoints",lv_expPoints,line,y);
            SubRoutine("MasteryPoints",lv_mastery,line,y);
            SubRoutine("Plays",lv_prestige,line,y);
        }

        public int stupidCalc() { return 999 - (16 + value); }

        private void rjButton1_Click(object sender,EventArgs e) {
            rTB.Clear();
            getAndCalcValues();
            Main.WriteStuff(rTB);
            WriteIntoBankfileWithSignature();
            Main.WriteStuff2(rTB);
        }
    }
}