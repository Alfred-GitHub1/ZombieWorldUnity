using System;
using System.Windows.Forms;

namespace ZombieWorld3 {

    public partial class paragonScreen : UserControl {

        public paragonScreen() {
            InitializeComponent();
            Assign(this);
            l1.Hide();
            button2.Enabled = true;

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

        }

        private void Assign(Control control) {
            foreach (Control ctrl in control.Controls) {
                if (ctrl is TextBox) {
                    TextBox tb = (TextBox)ctrl;
                    tb.TextChanged += new EventHandler(tb_TextChanged);
                } else { Assign(ctrl); }
            }
        }

        private void tb_TextChanged(object sender, EventArgs e) {
            TextBox tb = (TextBox)sender;
            string objname = ((TextBox)sender).Name;
            var tbText = int.TryParse(tb.Text, out int n);
            if (tbText) {
                if (objname == "textBox20" || objname == "textBox19" || objname == "textBox18"
                   || objname == "textBox17" || objname == "textBox16" || objname == "textBox15"
                   || objname == "textBox14" || objname == "textBox13" || objname == "textBox12"
                   || objname == "textBox11") { return; }
                if (n > 999999) { tb.Text = "999999"; }
                if (n < 0) { tb.Text = "0"; }
            } else {
                tb.Text = "0";
            }
        }

        private void doYourJob() {
            button2.Enabled = false;
            l1.Hide();
            rTB.Clear();
            int lv_talentPoints = Convert.ToInt32(textBox2.Text);
            int lv_damagePoints = Convert.ToInt32(textBox3.Text);
            int lv_movespeedPoints = Convert.ToInt32(textBox4.Text); 
            int lv_lifePoints = Convert.ToInt32(textBox5.Text);
            int lv_shieldPoints = Convert.ToInt32(textBox6.Text);
            int lv_shieldRegenerationPoints = Convert.ToInt32(textBox7.Text);
            int lv_mineralStart = Convert.ToInt32(textBox8.Text);
            int lv_respawnSpeedPoints = Convert.ToInt32(textBox9.Text);
            int lv_lifeRegenPoints = Convert.ToInt32(textBox10.Text); 
            int pointsYouWant = Convert.ToInt32(textBox2.Text);
            int lv_lifeArmorBonusPoints = Convert.ToInt32(textBox1.Text);
            int lv_lifeArmorMultiplyPoints = Convert.ToInt32(textBox11.Text);
            int lv_vespeneStartPoints = Convert.ToInt32(textBox16.Text);
            int lv_energyPoints = Convert.ToInt32(textBox19.Text);
            int lv_energyRegenPoints = Convert.ToInt32(textBox18.Text);
            int lv_shieldArmorMultiplyPoints = Convert.ToInt32(textBox12.Text);
            int lv_damageReductionPoints = Convert.ToInt32(textBox14.Text);
            int lv_shieldArmorBonusPoints = Convert.ToInt32(textBox15.Text);
            int lv_cooldownPoints = Convert.ToInt32(textBox17.Text);
            int lv_mastery = Convert.ToInt32(textBox20.Text);
            int lv_prestige = Convert.ToInt32(textBox13.Text);

            lv_talentPoints = pointsYouWant;
            lv_talentPoints *= (9999 - (16 + lv_talentPoints));
            lv_damagePoints *= stupidCalc(lv_talentPoints);
            lv_movespeedPoints *= stupidCalc(lv_talentPoints); 
            lv_lifePoints      *= stupidCalc(lv_talentPoints);
            lv_shieldPoints    *= stupidCalc(lv_talentPoints); 
            lv_shieldRegenerationPoints *= stupidCalc(lv_talentPoints);
            lv_mineralStart *= stupidCalc(lv_talentPoints); 
            lv_respawnSpeedPoints *= stupidCalc(lv_talentPoints);
            lv_lifeRegenPoints *= stupidCalc(lv_talentPoints);
            lv_lifeArmorBonusPoints *= stupidCalc(lv_talentPoints);
            lv_lifeArmorMultiplyPoints *= stupidCalc(lv_talentPoints);
            lv_vespeneStartPoints *= stupidCalc(lv_talentPoints);
            lv_energyPoints *= stupidCalc(lv_talentPoints);
            lv_energyRegenPoints *= stupidCalc(lv_talentPoints);
            lv_shieldArmorMultiplyPoints *= stupidCalc(lv_talentPoints);
            lv_damageReductionPoints *= stupidCalc(lv_talentPoints);
            lv_shieldArmorBonusPoints *= stupidCalc(lv_talentPoints);
            lv_cooldownPoints *= stupidCalc(lv_talentPoints);
            lv_mastery *= stupidCalc(lv_talentPoints);
            lv_prestige *= (505 - (16 + lv_talentPoints));


        }

        public int stupidCalc(int a) {
            return (9999 - (16 + a));
        }

        public void wait(int milliseconds) {
            Timer t1 = new Timer();
            if (milliseconds == 0 || milliseconds < 0) { return; }
            t1.Interval = milliseconds; t1.Enabled = true; t1.Start();
            t1.Tick += (s, e) => {
                t1.Enabled = false; t1.Stop();
            };
            while (t1.Enabled) { Application.DoEvents(); }
        }

        private static readonly Random r = new Random();

        public static int RandomNumber(int min, int max) {
            lock (r) { return r.Next(min, max); }
        }

        private void button2_Click(object sender, EventArgs e) {
            foreach (var control in Controls) {
                var textBox = control as TextBox;
                if (textBox != null) {
                    if (string.IsNullOrEmpty(textBox.Text)) { textBox.Text = 0.ToString(); }
                    if (Convert.ToUInt32(textBox.Text) >= 999999) { textBox.Text = 999999.ToString(); }
                }
            }
            doYourJob();
        }

        private void button1_Click(object sender, EventArgs e) {
            foreach (var control in Controls) {
                var textBox = control as TextBox;
                if (textBox != null) {
                    textBox.Text = RandomNumber(0, 1000).ToString();
                }
            }
            doYourJob();
        }

        private void button1_Click_1(object sender, EventArgs e) {

        }
    }
}