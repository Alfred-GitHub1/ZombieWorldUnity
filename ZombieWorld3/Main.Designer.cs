using System.Windows.Forms;

namespace ZombieWorld3 {
    partial class Main {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChallengeButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.KillButton = new System.Windows.Forms.Button();
            this.ParagonButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.selectHandleScreen1 = new ZombieWorld3.selectHandleScreen();
            this.killsScreen1 = new ZombieWorld3.killsScreen();
            this.challengesScreen1 = new ZombieWorld3.challengesScreen();
            this.homeScreen1 = new ZombieWorld3.HomeScreen();
            this.killsScore1 = new ZombieWorld3.paragonScreen();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ChallengeButton);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Controls.Add(this.KillButton);
            this.panel1.Controls.Add(this.ParagonButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 500);
            this.panel1.TabIndex = 3;
            // 
            // ChallengeButton
            // 
            this.ChallengeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(150)))), ((int)(((byte)(249)))));
            this.ChallengeButton.FlatAppearance.BorderSize = 0;
            this.ChallengeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChallengeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.ChallengeButton.ForeColor = System.Drawing.Color.White;
            this.ChallengeButton.Location = new System.Drawing.Point(11, 101);
            this.ChallengeButton.Name = "ChallengeButton";
            this.ChallengeButton.Size = new System.Drawing.Size(146, 42);
            this.ChallengeButton.TabIndex = 3;
            this.ChallengeButton.Text = "Challenges";
            this.ChallengeButton.UseVisualStyleBackColor = false;
            this.ChallengeButton.Click += new System.EventHandler(this.button8_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(150)))), ((int)(((byte)(249)))));
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Location = new System.Drawing.Point(11, 445);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(146, 42);
            this.HomeButton.TabIndex = 2;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // KillButton
            // 
            this.KillButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(150)))), ((int)(((byte)(249)))));
            this.KillButton.FlatAppearance.BorderSize = 0;
            this.KillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KillButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.KillButton.ForeColor = System.Drawing.Color.White;
            this.KillButton.Location = new System.Drawing.Point(11, 5);
            this.KillButton.Name = "KillButton";
            this.KillButton.Size = new System.Drawing.Size(146, 42);
            this.KillButton.TabIndex = 1;
            this.KillButton.Text = "Kills";
            this.KillButton.UseVisualStyleBackColor = false;
            this.KillButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // ParagonButton
            // 
            this.ParagonButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(150)))), ((int)(((byte)(249)))));
            this.ParagonButton.FlatAppearance.BorderSize = 0;
            this.ParagonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ParagonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.ParagonButton.ForeColor = System.Drawing.Color.White;
            this.ParagonButton.Location = new System.Drawing.Point(11, 53);
            this.ParagonButton.Name = "ParagonButton";
            this.ParagonButton.Size = new System.Drawing.Size(146, 42);
            this.ParagonButton.TabIndex = 0;
            this.ParagonButton.Text = "Paragon Points";
            this.ParagonButton.UseVisualStyleBackColor = false;
            this.ParagonButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 50);
            this.panel2.TabIndex = 2;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.move_window);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(752, 8);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(32, 32);
            this.button7.TabIndex = 2;
            this.button7.Text = "-";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            this.button7.MouseEnter += new System.EventHandler(this.button7_MouseEnter);
            this.button7.MouseLeave += new System.EventHandler(this.button7_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(790, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 550);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(834, 50);
            this.panel3.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(12, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 29);
            this.button4.TabIndex = 2;
            this.button4.Text = "Handle:";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 28);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Tag = "";
            this.comboBox1.Text = "Select Handle";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Enter += new System.EventHandler(this.comboBox1_Enter);
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.MediumOrchid;
            this.button3.Location = new System.Drawing.Point(736, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 30);
            this.button3.TabIndex = 0;
            this.button3.Text = "Sterillium";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.selectHandleScreen1);
            this.panel4.Controls.Add(this.killsScreen1);
            this.panel4.Controls.Add(this.challengesScreen1);
            this.panel4.Controls.Add(this.homeScreen1);
            this.panel4.Controls.Add(this.killsScore1);
            this.panel4.Location = new System.Drawing.Point(167, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(832, 500);
            this.panel4.TabIndex = 4;
            // 
            // selectHandleScreen1
            // 
            this.selectHandleScreen1.Location = new System.Drawing.Point(1, 0);
            this.selectHandleScreen1.Name = "selectHandleScreen1";
            this.selectHandleScreen1.Size = new System.Drawing.Size(663, 498);
            this.selectHandleScreen1.TabIndex = 6;
            // 
            // killsScreen1
            // 
            this.killsScreen1.Location = new System.Drawing.Point(0, 0);
            this.killsScreen1.Name = "killsScreen1";
            this.killsScreen1.Size = new System.Drawing.Size(666, 500);
            this.killsScreen1.TabIndex = 5;
            // 
            // challengesScreen1
            // 
            this.challengesScreen1.Location = new System.Drawing.Point(0, 0);
            this.challengesScreen1.Name = "challengesScreen1";
            this.challengesScreen1.Size = new System.Drawing.Size(666, 500);
            this.challengesScreen1.TabIndex = 4;
            // 
            // homeScreen1
            // 
            this.homeScreen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            this.homeScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeScreen1.Location = new System.Drawing.Point(0, 0);
            this.homeScreen1.Name = "homeScreen1";
            this.homeScreen1.Size = new System.Drawing.Size(830, 498);
            this.homeScreen1.TabIndex = 3;
            // 
            // killsScore1
            // 
            this.killsScore1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            this.killsScore1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.killsScore1.Location = new System.Drawing.Point(0, 0);
            this.killsScore1.Name = "killsScore1";
            this.killsScore1.Size = new System.Drawing.Size(830, 498);
            this.killsScore1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(834, 600);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Zombie World : Unity";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Button button1;
        private Button ParagonButton;
        private Panel panel4;
        private paragonScreen killsScore1;
        private Button button3;
        private Button button4;
        private ComboBox comboBox1;
        private Button KillButton;
        private Button HomeButton;
        private HomeScreen homeScreen1;
        private Button button7;
        private Button ChallengeButton;
        private killsScreen killsScreen1;
        private challengesScreen challengesScreen1;
        private selectHandleScreen selectHandleScreen1;
    }
}

