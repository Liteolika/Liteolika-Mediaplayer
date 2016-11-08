namespace LiteolikaMediaplayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnRev5 = new System.Windows.Forms.Button();
            this.btnFwd5 = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRev10 = new System.Windows.Forms.Button();
            this.btnFwd10 = new System.Windows.Forms.Button();
            this.btnRev30 = new System.Windows.Forms.Button();
            this.btnFwd30 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öppnaFilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öppnaLjudfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblTimerLeft = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFilename = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 27);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(118, 40);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(142, 27);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(118, 40);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Paus";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnRev5
            // 
            this.btnRev5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRev5.Location = new System.Drawing.Point(142, 73);
            this.btnRev5.Name = "btnRev5";
            this.btnRev5.Size = new System.Drawing.Size(53, 23);
            this.btnRev5.TabIndex = 2;
            this.btnRev5.Text = "<< 5";
            this.btnRev5.UseVisualStyleBackColor = true;
            this.btnRev5.Click += new System.EventHandler(this.btnRev5_Click);
            // 
            // btnFwd5
            // 
            this.btnFwd5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFwd5.Location = new System.Drawing.Point(201, 73);
            this.btnFwd5.Name = "btnFwd5";
            this.btnFwd5.Size = new System.Drawing.Size(59, 23);
            this.btnFwd5.TabIndex = 3;
            this.btnFwd5.Text = "5 >>";
            this.btnFwd5.UseVisualStyleBackColor = true;
            this.btnFwd5.Click += new System.EventHandler(this.btnFwd5_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Red;
            this.lblTimer.Location = new System.Drawing.Point(5, 184);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(119, 43);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "00:00";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Text";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(93, 28);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "Text";
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(266, 27);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(118, 40);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRev10
            // 
            this.btnRev10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRev10.Location = new System.Drawing.Point(77, 73);
            this.btnRev10.Name = "btnRev10";
            this.btnRev10.Size = new System.Drawing.Size(53, 23);
            this.btnRev10.TabIndex = 10;
            this.btnRev10.Text = "<< 10";
            this.btnRev10.UseVisualStyleBackColor = true;
            this.btnRev10.Click += new System.EventHandler(this.btnRev10_Click);
            // 
            // btnFwd10
            // 
            this.btnFwd10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFwd10.Location = new System.Drawing.Point(266, 73);
            this.btnFwd10.Name = "btnFwd10";
            this.btnFwd10.Size = new System.Drawing.Size(53, 23);
            this.btnFwd10.TabIndex = 11;
            this.btnFwd10.Text = "10 >>";
            this.btnFwd10.UseVisualStyleBackColor = true;
            this.btnFwd10.Click += new System.EventHandler(this.btnFwd10_Click);
            // 
            // btnRev30
            // 
            this.btnRev30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRev30.Location = new System.Drawing.Point(12, 73);
            this.btnRev30.Name = "btnRev30";
            this.btnRev30.Size = new System.Drawing.Size(53, 23);
            this.btnRev30.TabIndex = 12;
            this.btnRev30.Text = "<< 30";
            this.btnRev30.UseVisualStyleBackColor = true;
            this.btnRev30.Click += new System.EventHandler(this.btnRev30_Click);
            // 
            // btnFwd30
            // 
            this.btnFwd30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFwd30.Location = new System.Drawing.Point(331, 73);
            this.btnFwd30.Name = "btnFwd30";
            this.btnFwd30.Size = new System.Drawing.Size(53, 23);
            this.btnFwd30.TabIndex = 13;
            this.btnFwd30.Text = "30 >>";
            this.btnFwd30.UseVisualStyleBackColor = true;
            this.btnFwd30.Click += new System.EventHandler(this.btnFwd30_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öppnaFilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(397, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öppnaFilToolStripMenuItem
            // 
            this.öppnaFilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öppnaLjudfilToolStripMenuItem});
            this.öppnaFilToolStripMenuItem.Name = "öppnaFilToolStripMenuItem";
            this.öppnaFilToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.öppnaFilToolStripMenuItem.Text = "Arkiv";
            // 
            // öppnaLjudfilToolStripMenuItem
            // 
            this.öppnaLjudfilToolStripMenuItem.Name = "öppnaLjudfilToolStripMenuItem";
            this.öppnaLjudfilToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.öppnaLjudfilToolStripMenuItem.Text = "Öppna ljudfil";
            this.öppnaLjudfilToolStripMenuItem.Click += new System.EventHandler(this.öppnaLjudfilToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // lblTimerLeft
            // 
            this.lblTimerLeft.AutoSize = true;
            this.lblTimerLeft.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerLeft.ForeColor = System.Drawing.Color.Red;
            this.lblTimerLeft.Location = new System.Drawing.Point(200, 184);
            this.lblTimerLeft.Name = "lblTimerLeft";
            this.lblTimerLeft.Size = new System.Drawing.Size(119, 43);
            this.lblTimerLeft.TabIndex = 15;
            this.lblTimerLeft.Text = "00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hastighet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Speltid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Kvar";
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(12, 258);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(0, 13);
            this.lblFilename.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Filnamn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 283);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTimerLeft);
            this.Controls.Add(this.btnFwd30);
            this.Controls.Add(this.btnRev30);
            this.Controls.Add(this.btnFwd10);
            this.Controls.Add(this.btnRev10);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnFwd5);
            this.Controls.Add(this.btnRev5);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Liteolika Mediaspelare";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnRev5;
        private System.Windows.Forms.Button btnFwd5;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRev10;
        private System.Windows.Forms.Button btnFwd10;
        private System.Windows.Forms.Button btnRev30;
        private System.Windows.Forms.Button btnFwd30;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öppnaFilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öppnaLjudfilToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblTimerLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

