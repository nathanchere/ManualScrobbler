namespace ManualScrobble
{
    partial class frmMain
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
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtTrack = new System.Windows.Forms.TextBox();
            this.txtWhen = new System.Windows.Forms.TextBox();
            this.btnMinusHour = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkClearAfterSubmit = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnMinus10Min = new System.Windows.Forms.Button();
            this.btnMinus1Min = new System.Windows.Forms.Button();
            this.btnNow = new System.Windows.Forms.Button();
            this.btnMinusSecs = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnPlusSecs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(48, 6);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(244, 20);
            this.txtArtist.TabIndex = 0;
            // 
            // txtTrack
            // 
            this.txtTrack.Location = new System.Drawing.Point(48, 32);
            this.txtTrack.Name = "txtTrack";
            this.txtTrack.Size = new System.Drawing.Size(244, 20);
            this.txtTrack.TabIndex = 1;
            // 
            // txtWhen
            // 
            this.txtWhen.Location = new System.Drawing.Point(48, 58);
            this.txtWhen.Name = "txtWhen";
            this.txtWhen.Size = new System.Drawing.Size(194, 20);
            this.txtWhen.TabIndex = 2;
            // 
            // btnMinusHour
            // 
            this.btnMinusHour.Location = new System.Drawing.Point(48, 84);
            this.btnMinusHour.Name = "btnMinusHour";
            this.btnMinusHour.Size = new System.Drawing.Size(44, 35);
            this.btnMinusHour.TabIndex = 3;
            this.btnMinusHour.Text = "-1h";
            this.btnMinusHour.UseVisualStyleBackColor = true;
            this.btnMinusHour.Click += new System.EventHandler(this.btnMinusHour_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Artist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Track";
            // 
            // chkClearAfterSubmit
            // 
            this.chkClearAfterSubmit.AutoSize = true;
            this.chkClearAfterSubmit.Location = new System.Drawing.Point(48, 181);
            this.chkClearAfterSubmit.Name = "chkClearAfterSubmit";
            this.chkClearAfterSubmit.Size = new System.Drawing.Size(107, 17);
            this.chkClearAfterSubmit.TabIndex = 9;
            this.chkClearAfterSubmit.Text = "Clear after submit";
            this.chkClearAfterSubmit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "When";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(48, 125);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(244, 50);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Scrobble";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnMinus10Min
            // 
            this.btnMinus10Min.Location = new System.Drawing.Point(98, 84);
            this.btnMinus10Min.Name = "btnMinus10Min";
            this.btnMinus10Min.Size = new System.Drawing.Size(44, 35);
            this.btnMinus10Min.TabIndex = 12;
            this.btnMinus10Min.Text = "-10m";
            this.btnMinus10Min.UseVisualStyleBackColor = true;
            this.btnMinus10Min.Click += new System.EventHandler(this.btnMinus10Min_Click);
            // 
            // btnMinus1Min
            // 
            this.btnMinus1Min.Location = new System.Drawing.Point(148, 84);
            this.btnMinus1Min.Name = "btnMinus1Min";
            this.btnMinus1Min.Size = new System.Drawing.Size(44, 35);
            this.btnMinus1Min.TabIndex = 13;
            this.btnMinus1Min.Text = "-1m";
            this.btnMinus1Min.UseVisualStyleBackColor = true;
            this.btnMinus1Min.Click += new System.EventHandler(this.btnMinus1Min_Click);
            // 
            // btnNow
            // 
            this.btnNow.Location = new System.Drawing.Point(240, 58);
            this.btnNow.Name = "btnNow";
            this.btnNow.Size = new System.Drawing.Size(52, 20);
            this.btnNow.TabIndex = 14;
            this.btnNow.Text = "Now";
            this.btnNow.UseVisualStyleBackColor = true;
            this.btnNow.Click += new System.EventHandler(this.btnNow_Click);
            // 
            // btnMinusSecs
            // 
            this.btnMinusSecs.Location = new System.Drawing.Point(198, 84);
            this.btnMinusSecs.Name = "btnMinusSecs";
            this.btnMinusSecs.Size = new System.Drawing.Size(44, 35);
            this.btnMinusSecs.TabIndex = 15;
            this.btnMinusSecs.Text = "-?s";
            this.btnMinusSecs.UseVisualStyleBackColor = true;
            this.btnMinusSecs.Click += new System.EventHandler(this.btnMinusSecs_Click);
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLog.Location = new System.Drawing.Point(0, 204);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(305, 97);
            this.txtLog.TabIndex = 16;
            // 
            // btnPlusSecs
            // 
            this.btnPlusSecs.Location = new System.Drawing.Point(248, 84);
            this.btnPlusSecs.Name = "btnPlusSecs";
            this.btnPlusSecs.Size = new System.Drawing.Size(44, 35);
            this.btnPlusSecs.TabIndex = 17;
            this.btnPlusSecs.Text = "+?s";
            this.btnPlusSecs.UseVisualStyleBackColor = true;
            this.btnPlusSecs.Click += new System.EventHandler(this.btnPlusSecs_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 301);
            this.Controls.Add(this.txtWhen);
            this.Controls.Add(this.btnPlusSecs);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnMinusSecs);
            this.Controls.Add(this.btnNow);
            this.Controls.Add(this.btnMinus1Min);
            this.Controls.Add(this.btnMinus10Min);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkClearAfterSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMinusHour);
            this.Controls.Add(this.txtTrack);
            this.Controls.Add(this.txtArtist);
            this.Name = "frmMain";
            this.Text = "Manual Scrobbler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtTrack;
        private System.Windows.Forms.TextBox txtWhen;
        private System.Windows.Forms.Button btnMinusHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkClearAfterSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnMinus10Min;
        private System.Windows.Forms.Button btnMinus1Min;
        private System.Windows.Forms.Button btnNow;
        private System.Windows.Forms.Button btnMinusSecs;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnPlusSecs;
    }
}

