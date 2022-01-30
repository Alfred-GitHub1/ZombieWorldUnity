namespace ZombieWorld3 {
    partial class challengesScreen {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.rTB = new System.Windows.Forms.RichTextBox();
            this.rjButton1 = new ZombieWorld3.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // rTB
            // 
            this.rTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTB.Location = new System.Drawing.Point(292, 12);
            this.rTB.Name = "rTB";
            this.rTB.ReadOnly = true;
            this.rTB.Size = new System.Drawing.Size(359, 475);
            this.rTB.TabIndex = 90;
            this.rTB.Text = "";
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(3, 225);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(283, 40);
            this.rjButton1.TabIndex = 93;
            this.rjButton1.Text = "Give me all Challenges";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // challengesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.rTB);
            this.Name = "challengesScreen";
            this.Size = new System.Drawing.Size(666, 500);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rTB;
        private RJControls.RJButton rjButton1;
    }
}
