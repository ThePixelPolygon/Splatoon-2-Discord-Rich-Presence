namespace Splatoon2ManualRichPresence
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.srRad = new System.Windows.Forms.RadioButton();
            this.leRad = new System.Windows.Forms.RadioButton();
            this.raRad = new System.Windows.Forms.RadioButton();
            this.reRad = new System.Windows.Forms.RadioButton();
            this.stage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.startbtn = new System.Windows.Forms.Button();
            this.endbtn = new System.Windows.Forms.Button();
            this.idlebtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbRad = new System.Windows.Forms.RadioButton();
            this.szRad = new System.Windows.Forms.RadioButton();
            this.rmRad = new System.Windows.Forms.RadioButton();
            this.tcRad = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.srRad);
            this.groupBox1.Controls.Add(this.leRad);
            this.groupBox1.Controls.Add(this.raRad);
            this.groupBox1.Controls.Add(this.reRad);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multiplayer Mode";
            // 
            // srRad
            // 
            this.srRad.AutoSize = true;
            this.srRad.Location = new System.Drawing.Point(306, 19);
            this.srRad.Name = "srRad";
            this.srRad.Size = new System.Drawing.Size(83, 17);
            this.srRad.TabIndex = 4;
            this.srRad.Text = "Salmon Run";
            this.srRad.UseVisualStyleBackColor = true;
            // 
            // leRad
            // 
            this.leRad.AutoSize = true;
            this.leRad.Location = new System.Drawing.Point(208, 19);
            this.leRad.Name = "leRad";
            this.leRad.Size = new System.Drawing.Size(91, 17);
            this.leRad.TabIndex = 3;
            this.leRad.Text = "League Battle";
            this.leRad.UseVisualStyleBackColor = true;
            // 
            // raRad
            // 
            this.raRad.AutoSize = true;
            this.raRad.Location = new System.Drawing.Point(109, 19);
            this.raRad.Name = "raRad";
            this.raRad.Size = new System.Drawing.Size(93, 17);
            this.raRad.TabIndex = 2;
            this.raRad.Text = "Ranked Battle";
            this.raRad.UseVisualStyleBackColor = true;
            // 
            // reRad
            // 
            this.reRad.AutoSize = true;
            this.reRad.Checked = true;
            this.reRad.Location = new System.Drawing.Point(11, 19);
            this.reRad.Name = "reRad";
            this.reRad.Size = new System.Drawing.Size(92, 17);
            this.reRad.TabIndex = 1;
            this.reRad.TabStop = true;
            this.reRad.Text = "Regular Battle";
            this.reRad.UseVisualStyleBackColor = true;
            // 
            // stage
            // 
            this.stage.Location = new System.Drawing.Point(61, 159);
            this.stage.Name = "stage";
            this.stage.Size = new System.Drawing.Size(286, 20);
            this.stage.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Stage";
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(107, 185);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(117, 23);
            this.searchbtn.TabIndex = 4;
            this.searchbtn.Text = "Searching State";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(107, 214);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(117, 23);
            this.startbtn.TabIndex = 5;
            this.startbtn.Text = "Match Start";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // endbtn
            // 
            this.endbtn.Location = new System.Drawing.Point(230, 214);
            this.endbtn.Name = "endbtn";
            this.endbtn.Size = new System.Drawing.Size(117, 23);
            this.endbtn.TabIndex = 6;
            this.endbtn.Text = "Match/Wave End";
            this.endbtn.UseVisualStyleBackColor = true;
            this.endbtn.Click += new System.EventHandler(this.endbtn_Click);
            // 
            // idlebtn
            // 
            this.idlebtn.Location = new System.Drawing.Point(230, 185);
            this.idlebtn.Name = "idlebtn";
            this.idlebtn.Size = new System.Drawing.Size(117, 23);
            this.idlebtn.TabIndex = 7;
            this.idlebtn.Text = "Idle (In Lobby)";
            this.idlebtn.UseVisualStyleBackColor = true;
            this.idlebtn.Click += new System.EventHandler(this.idlebtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbRad);
            this.groupBox2.Controls.Add(this.szRad);
            this.groupBox2.Controls.Add(this.rmRad);
            this.groupBox2.Controls.Add(this.tcRad);
            this.groupBox2.Location = new System.Drawing.Point(12, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 54);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ranked/League Mode";
            // 
            // cbRad
            // 
            this.cbRad.AutoSize = true;
            this.cbRad.Location = new System.Drawing.Point(306, 19);
            this.cbRad.Name = "cbRad";
            this.cbRad.Size = new System.Drawing.Size(70, 17);
            this.cbRad.TabIndex = 4;
            this.cbRad.Text = "Clam Blitz";
            this.cbRad.UseVisualStyleBackColor = true;
            // 
            // szRad
            // 
            this.szRad.AutoSize = true;
            this.szRad.Checked = true;
            this.szRad.Location = new System.Drawing.Point(11, 19);
            this.szRad.Name = "szRad";
            this.szRad.Size = new System.Drawing.Size(82, 17);
            this.szRad.TabIndex = 1;
            this.szRad.TabStop = true;
            this.szRad.Text = "Splat Zones";
            this.szRad.UseVisualStyleBackColor = true;
            // 
            // rmRad
            // 
            this.rmRad.AutoSize = true;
            this.rmRad.Location = new System.Drawing.Point(208, 19);
            this.rmRad.Name = "rmRad";
            this.rmRad.Size = new System.Drawing.Size(76, 17);
            this.rmRad.TabIndex = 3;
            this.rmRad.Text = "Rainmaker";
            this.rmRad.UseVisualStyleBackColor = true;
            // 
            // tcRad
            // 
            this.tcRad.AutoSize = true;
            this.tcRad.Location = new System.Drawing.Point(109, 19);
            this.tcRad.Name = "tcRad";
            this.tcRad.Size = new System.Drawing.Size(91, 17);
            this.tcRad.TabIndex = 2;
            this.tcRad.Text = "Tower Control";
            this.tcRad.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 284);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.idlebtn);
            this.Controls.Add(this.endbtn);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stage);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Splatoon 2 Rich Presence";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton srRad;
        private System.Windows.Forms.RadioButton leRad;
        private System.Windows.Forms.RadioButton raRad;
        private System.Windows.Forms.RadioButton reRad;
        private System.Windows.Forms.TextBox stage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Button endbtn;
        private System.Windows.Forms.Button idlebtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton cbRad;
        private System.Windows.Forms.RadioButton szRad;
        private System.Windows.Forms.RadioButton rmRad;
        private System.Windows.Forms.RadioButton tcRad;
    }
}

