namespace gsU2_Priezvisko_Meno
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.renderTimer = new System.Windows.Forms.Timer(this.components);
            this.panelVykresli = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnVykresli = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnVycisti = new System.Windows.Forms.Button();
            this.cbFarbaPozadia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chXOb = new System.Windows.Forms.CheckBox();
            this.chYOb = new System.Windows.Forms.CheckBox();
            this.chZOb = new System.Windows.Forms.CheckBox();
            this.chX = new System.Windows.Forms.CheckBox();
            this.chY = new System.Windows.Forms.CheckBox();
            this.chZ = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCw = new System.Windows.Forms.ComboBox();
            this.cbObject = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Nastavenia = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // renderTimer
            // 
            this.renderTimer.Tick += new System.EventHandler(this.renderTimer_Tick_1);
            // 
            // panelVykresli
            // 
            this.panelVykresli.BackColor = System.Drawing.SystemColors.Desktop;
            this.panelVykresli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVykresli.Location = new System.Drawing.Point(3, 215);
            this.panelVykresli.Name = "panelVykresli";
            this.panelVykresli.Size = new System.Drawing.Size(932, 330);
            this.panelVykresli.TabIndex = 0;
            this.panelVykresli.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelVykresli_MouseMove);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(714, 91);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(85, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Štart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnVykresli
            // 
            this.btnVykresli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVykresli.Location = new System.Drawing.Point(394, 576);
            this.btnVykresli.Name = "btnVykresli";
            this.btnVykresli.Size = new System.Drawing.Size(134, 41);
            this.btnVykresli.TabIndex = 2;
            this.btnVykresli.Text = "Vykresliť";
            this.btnVykresli.UseVisualStyleBackColor = true;
            this.btnVykresli.Click += new System.EventHandler(this.btnVykresli_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(714, 118);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(85, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnVycisti
            // 
            this.btnVycisti.Location = new System.Drawing.Point(714, 147);
            this.btnVycisti.Name = "btnVycisti";
            this.btnVycisti.Size = new System.Drawing.Size(85, 23);
            this.btnVycisti.TabIndex = 4;
            this.btnVycisti.Text = "Vyčisti";
            this.btnVycisti.UseVisualStyleBackColor = true;
            this.btnVycisti.Click += new System.EventHandler(this.btnVycisti_Click);
            // 
            // cbFarbaPozadia
            // 
            this.cbFarbaPozadia.FormattingEnabled = true;
            this.cbFarbaPozadia.Items.AddRange(new object[] {
            "Biela",
            "Červená",
            "Modrá",
            "Zelená",
            "Žltá",
            "Čierna"});
            this.cbFarbaPozadia.Location = new System.Drawing.Point(114, 93);
            this.cbFarbaPozadia.Name = "cbFarbaPozadia";
            this.cbFarbaPozadia.Size = new System.Drawing.Size(165, 21);
            this.cbFarbaPozadia.TabIndex = 5;
            this.cbFarbaPozadia.Text = "Ćierna";
            this.cbFarbaPozadia.SelectedIndexChanged += new System.EventHandler(this.cbFarbaPozadia_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Farba pozadia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(416, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rotácia:";
            // 
            // chXOb
            // 
            this.chXOb.AutoSize = true;
            this.chXOb.Location = new System.Drawing.Point(362, 105);
            this.chXOb.Name = "chXOb";
            this.chXOb.Size = new System.Drawing.Size(118, 17);
            this.chXOb.TabIndex = 9;
            this.chXOb.Text = "Okolo osi X objektu";
            this.chXOb.UseVisualStyleBackColor = true;
            this.chXOb.CheckedChanged += new System.EventHandler(this.chXOb_CheckedChanged);
            // 
            // chYOb
            // 
            this.chYOb.AutoSize = true;
            this.chYOb.Location = new System.Drawing.Point(362, 128);
            this.chYOb.Name = "chYOb";
            this.chYOb.Size = new System.Drawing.Size(118, 17);
            this.chYOb.TabIndex = 10;
            this.chYOb.Text = "Okolo osi Y objektu";
            this.chYOb.UseVisualStyleBackColor = true;
            this.chYOb.CheckedChanged += new System.EventHandler(this.chYOb_CheckedChanged);
            // 
            // chZOb
            // 
            this.chZOb.AutoSize = true;
            this.chZOb.Location = new System.Drawing.Point(362, 151);
            this.chZOb.Name = "chZOb";
            this.chZOb.Size = new System.Drawing.Size(118, 17);
            this.chZOb.TabIndex = 11;
            this.chZOb.Text = "Okolo osi Z objektu";
            this.chZOb.UseVisualStyleBackColor = true;
            this.chZOb.CheckedChanged += new System.EventHandler(this.chZOb_CheckedChanged);
            // 
            // chX
            // 
            this.chX.AutoSize = true;
            this.chX.Location = new System.Drawing.Point(486, 105);
            this.chX.Name = "chX";
            this.chX.Size = new System.Drawing.Size(80, 17);
            this.chX.TabIndex = 12;
            this.chX.Text = "Okolo osi X";
            this.chX.UseVisualStyleBackColor = true;
            this.chX.CheckedChanged += new System.EventHandler(this.chX_CheckedChanged);
            // 
            // chY
            // 
            this.chY.AutoSize = true;
            this.chY.Location = new System.Drawing.Point(486, 128);
            this.chY.Name = "chY";
            this.chY.Size = new System.Drawing.Size(80, 17);
            this.chY.TabIndex = 0;
            this.chY.Text = "Okolo osi Y";
            this.chY.UseVisualStyleBackColor = true;
            this.chY.CheckedChanged += new System.EventHandler(this.chY_CheckedChanged);
            // 
            // chZ
            // 
            this.chZ.AutoSize = true;
            this.chZ.Location = new System.Drawing.Point(486, 151);
            this.chZ.Name = "chZ";
            this.chZ.Size = new System.Drawing.Size(80, 17);
            this.chZ.TabIndex = 1;
            this.chZ.Text = "Okolo osi Z";
            this.chZ.UseVisualStyleBackColor = true;
            this.chZ.CheckedChanged += new System.EventHandler(this.chZ_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Smer rotácie:";
            // 
            // cbCw
            // 
            this.cbCw.FormattingEnabled = true;
            this.cbCw.Items.AddRange(new object[] {
            "CW - V smere hodinových ručičiek",
            "CCW - Proti smeru hodinových ručičiek "});
            this.cbCw.Location = new System.Drawing.Point(114, 124);
            this.cbCw.Name = "cbCw";
            this.cbCw.Size = new System.Drawing.Size(165, 21);
            this.cbCw.TabIndex = 14;
            // 
            // cbObject
            // 
            this.cbObject.FormattingEnabled = true;
            this.cbObject.Items.AddRange(new object[] {
            "Ihlan",
            "Kocka"});
            this.cbObject.Location = new System.Drawing.Point(114, 155);
            this.cbObject.Name = "cbObject";
            this.cbObject.Size = new System.Drawing.Size(165, 21);
            this.cbObject.TabIndex = 15;
            this.cbObject.SelectedIndexChanged += new System.EventHandler(this.cbObject_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Typ objektu:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.chXOb);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.Nastavenia);
            this.panel1.Controls.Add(this.btnVycisti);
            this.panel1.Controls.Add(this.chX);
            this.panel1.Controls.Add(this.cbFarbaPozadia);
            this.panel1.Controls.Add(this.chYOb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.chY);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chZ);
            this.panel1.Controls.Add(this.cbObject);
            this.panel1.Controls.Add(this.chZOb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbCw);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 203);
            this.panel1.TabIndex = 17;
            // 
            // Nastavenia
            // 
            this.Nastavenia.AutoSize = true;
            this.Nastavenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Nastavenia.Location = new System.Drawing.Point(96, 37);
            this.Nastavenia.Name = "Nastavenia";
            this.Nastavenia.Size = new System.Drawing.Size(130, 25);
            this.Nastavenia.TabIndex = 17;
            this.Nastavenia.Text = "Nastavenia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(699, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Animácia:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(945, 571);
            this.tabControl1.TabIndex = 18;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panelVykresli);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(937, 545);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Program";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(937, 545);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Návod";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(937, 545);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Autor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(564, 234);
            this.label6.TabIndex = 0;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(34, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 31);
            this.label7.TabIndex = 1;
            this.label7.Text = "Návod";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(25, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(487, 96);
            this.label8.TabIndex = 2;
            this.label8.Text = "Postup:\r\n1. Krok - Nastavenie objektu a rotácie\r\n2. Krok - Vykreslenie objektu po" +
    "mocou tlačidla \"Vykresliť\"\r\n3. Krok - Spustenie animácie";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(39, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 340);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(39, 359);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(840, 140);
            this.panel3.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(30, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 150);
            this.label9.TabIndex = 0;
            this.label9.Text = "Meno:\r\nPriezvisko:\r\nRočník:\r\nPredmet:\r\nŠkolský rok:\r\n\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(200, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 175);
            this.label10.TabIndex = 1;
            this.label10.Text = "Ján\r\nFábry\r\n1. Ing.\r\nGrafické systémy\r\n2016/2017\r\n\r\n\r\n";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(6, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(371, 194);
            this.panel4.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(948, 619);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnVykresli);
            this.MinimumSize = new System.Drawing.Size(964, 657);
            this.Name = "Form1";
            this.Text = "Ján Fábry - Grafické systémy - Úloha 2";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer renderTimer;
        private System.Windows.Forms.Panel panelVykresli;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnVykresli;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnVycisti;
        private System.Windows.Forms.ComboBox cbFarbaPozadia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chXOb;
        private System.Windows.Forms.CheckBox chYOb;
        private System.Windows.Forms.CheckBox chZ;
        private System.Windows.Forms.CheckBox chY;
        private System.Windows.Forms.CheckBox chZOb;
        private System.Windows.Forms.CheckBox chX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCw;
        private System.Windows.Forms.ComboBox cbObject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Nastavenia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

