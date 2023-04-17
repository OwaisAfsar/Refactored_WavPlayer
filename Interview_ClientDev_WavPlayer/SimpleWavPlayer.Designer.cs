namespace Interview_ClientDev_WavPlayer
{
    partial class SimpleWavPlayer
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ButtonPlay = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.lblFilename = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFileDescription = new System.Windows.Forms.Label();
            this.RadioButtonDeutsch = new System.Windows.Forms.RadioButton();
            this.RadioButtonEnglish = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.Location = new System.Drawing.Point(16, 107);
            this.ButtonPlay.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(100, 28);
            this.ButtonPlay.TabIndex = 0;
            this.ButtonPlay.Text = "PLAY";
            this.ButtonPlay.UseVisualStyleBackColor = true;
            this.ButtonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.Location = new System.Drawing.Point(125, 107);
            this.ButtonStop.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(100, 28);
            this.ButtonStop.TabIndex = 1;
            this.ButtonStop.Text = "STOP";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Location = new System.Drawing.Point(16, 71);
            this.ButtonOpen.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(100, 28);
            this.ButtonOpen.TabIndex = 2;
            this.ButtonOpen.Text = "OPEN";
            this.ButtonOpen.UseVisualStyleBackColor = true;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(124, 71);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(100, 28);
            this.ButtonClose.TabIndex = 3;
            this.ButtonClose.Text = "CLOSE";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // lblFilename
            // 
            this.lblFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilename.Location = new System.Drawing.Point(16, 16);
            this.lblFilename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(337, 52);
            this.lblFilename.TabIndex = 4;
            this.lblFilename.Text = "Filename\r\n";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblFileDescription
            // 
            this.lblFileDescription.AutoSize = true;
            this.lblFileDescription.Location = new System.Drawing.Point(17, 153);
            this.lblFileDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFileDescription.Name = "lblFileDescription";
            this.lblFileDescription.Size = new System.Drawing.Size(100, 16);
            this.lblFileDescription.TabIndex = 5;
            this.lblFileDescription.Text = "File Description";
            // 
            // RadioButtonDeutsch
            // 
            this.RadioButtonDeutsch.AutoSize = true;
            this.RadioButtonDeutsch.Location = new System.Drawing.Point(249, 75);
            this.RadioButtonDeutsch.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButtonDeutsch.Name = "RadioButtonDeutsch";
            this.RadioButtonDeutsch.Size = new System.Drawing.Size(77, 20);
            this.RadioButtonDeutsch.TabIndex = 6;
            this.RadioButtonDeutsch.TabStop = true;
            this.RadioButtonDeutsch.Text = "Deutsch";
            this.RadioButtonDeutsch.UseVisualStyleBackColor = true;
            this.RadioButtonDeutsch.CheckedChanged += new System.EventHandler(this.RadioButtonDeutsch_CheckedChanged);
            // 
            // RadioButtonEnglish
            // 
            this.RadioButtonEnglish.AutoSize = true;
            this.RadioButtonEnglish.Location = new System.Drawing.Point(249, 103);
            this.RadioButtonEnglish.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButtonEnglish.Name = "RadioButtonEnglish";
            this.RadioButtonEnglish.Size = new System.Drawing.Size(79, 20);
            this.RadioButtonEnglish.TabIndex = 7;
            this.RadioButtonEnglish.TabStop = true;
            this.RadioButtonEnglish.Text = "Englisch";
            this.RadioButtonEnglish.UseVisualStyleBackColor = true;
            this.RadioButtonEnglish.CheckedChanged += new System.EventHandler(this.RadioButtonEnglish_CheckedChanged);
            // 
            // SimpleWavPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 186);
            this.Controls.Add(this.RadioButtonEnglish);
            this.Controls.Add(this.RadioButtonDeutsch);
            this.Controls.Add(this.lblFileDescription);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonOpen);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonPlay);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SimpleWavPlayer";
            this.Text = "SimpleWavPlayer";
            this.Load += new System.EventHandler(this.SimpleWavPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonPlay;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Button ButtonOpen;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFileDescription;
        private System.Windows.Forms.RadioButton RadioButtonDeutsch;
        private System.Windows.Forms.RadioButton RadioButtonEnglish;
    }
}

