namespace TestGenerator
{
    partial class FormaInregistrare
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
            this.ButonInapoiLogare = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ImagineProfilPB = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lollipopLabel4 = new LollipopLabel();
            this.ButonInregistrare = new LollipopButton();
            this.lollipopLabel1 = new LollipopLabel();
            this.lollipopLabel3 = new LollipopLabel();
            this.parolaReintrodusaTB = new LollipopTextBox();
            this.lollipopLabel2 = new LollipopLabel();
            this.parolaTB = new LollipopTextBox();
            this.numeTB = new LollipopTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagineProfilPB)).BeginInit();
            this.SuspendLayout();
            // 
            // ButonInapoiLogare
            // 
            this.ButonInapoiLogare.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButonInapoiLogare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.ButonInapoiLogare.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ButonInapoiLogare.Location = new System.Drawing.Point(11, 552);
            this.ButonInapoiLogare.Name = "ButonInapoiLogare";
            this.ButonInapoiLogare.Size = new System.Drawing.Size(216, 36);
            this.ButonInapoiLogare.TabIndex = 4;
            this.ButonInapoiLogare.Text = "Inapoi la logare";
            this.ButonInapoiLogare.UseVisualStyleBackColor = false;
            this.ButonInapoiLogare.Click += new System.EventHandler(this.ButonInapoiLogare_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ImagineProfilPB
            // 
            this.ImagineProfilPB.BackColor = System.Drawing.Color.Blue;
            this.ImagineProfilPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImagineProfilPB.Image = global::TestGenerator.Properties.Resources.AddAnImage;
            this.ImagineProfilPB.Location = new System.Drawing.Point(222, 462);
            this.ImagineProfilPB.Name = "ImagineProfilPB";
            this.ImagineProfilPB.Size = new System.Drawing.Size(76, 61);
            this.ImagineProfilPB.TabIndex = 12;
            this.ImagineProfilPB.TabStop = false;
            this.ImagineProfilPB.Click += new System.EventHandler(this.ImagineProfil_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::TestGenerator.Properties.Resources.add_user;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(160, 94);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 159);
            this.panel1.TabIndex = 11;
            // 
            // lollipopLabel4
            // 
            this.lollipopLabel4.AutoSize = true;
            this.lollipopLabel4.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lollipopLabel4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lollipopLabel4.Location = new System.Drawing.Point(24, 482);
            this.lollipopLabel4.Name = "lollipopLabel4";
            this.lollipopLabel4.Size = new System.Drawing.Size(171, 24);
            this.lollipopLabel4.TabIndex = 13;
            this.lollipopLabel4.Text = "*Imagine de profil : ";
            // 
            // ButonInregistrare
            // 
            this.ButonInregistrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ButonInregistrare.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ButonInregistrare.Location = new System.Drawing.Point(354, 538);
            this.ButonInregistrare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButonInregistrare.Name = "ButonInregistrare";
            this.ButonInregistrare.Size = new System.Drawing.Size(200, 50);
            this.ButonInregistrare.TabIndex = 3;
            this.ButonInregistrare.Text = "INREGISTREAZA";
            this.ButonInregistrare.UseVisualStyleBackColor = true;
            this.ButonInregistrare.Click += new System.EventHandler(this.ButonInregistrare_Click);
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lollipopLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lollipopLabel1.Location = new System.Drawing.Point(46, 422);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(164, 24);
            this.lollipopLabel1.TabIndex = 9;
            this.lollipopLabel1.Text = "Reintrodu parola : ";
            // 
            // lollipopLabel3
            // 
            this.lollipopLabel3.AutoSize = true;
            this.lollipopLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lollipopLabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lollipopLabel3.Location = new System.Drawing.Point(110, 354);
            this.lollipopLabel3.Name = "lollipopLabel3";
            this.lollipopLabel3.Size = new System.Drawing.Size(78, 24);
            this.lollipopLabel3.TabIndex = 9;
            this.lollipopLabel3.Text = "Parola : ";
            // 
            // parolaReintrodusaTB
            // 
            this.parolaReintrodusaTB.FocusedColor = "#508ef5";
            this.parolaReintrodusaTB.FontColor = "#999999";
            this.parolaReintrodusaTB.IsEnabled = true;
            this.parolaReintrodusaTB.Location = new System.Drawing.Point(231, 422);
            this.parolaReintrodusaTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parolaReintrodusaTB.MaxLength = 32767;
            this.parolaReintrodusaTB.Multiline = false;
            this.parolaReintrodusaTB.Name = "parolaReintrodusaTB";
            this.parolaReintrodusaTB.ReadOnly = false;
            this.parolaReintrodusaTB.Size = new System.Drawing.Size(287, 24);
            this.parolaReintrodusaTB.TabIndex = 2;
            this.parolaReintrodusaTB.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.parolaReintrodusaTB.UseSystemPasswordChar = true;
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lollipopLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lollipopLabel2.Location = new System.Drawing.Point(46, 286);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(149, 24);
            this.lollipopLabel2.TabIndex = 10;
            this.lollipopLabel2.Text = "Nume utilizator : ";
            // 
            // parolaTB
            // 
            this.parolaTB.FocusedColor = "#508ef5";
            this.parolaTB.FontColor = "#999999";
            this.parolaTB.IsEnabled = true;
            this.parolaTB.Location = new System.Drawing.Point(231, 354);
            this.parolaTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parolaTB.MaxLength = 32767;
            this.parolaTB.Multiline = false;
            this.parolaTB.Name = "parolaTB";
            this.parolaTB.ReadOnly = false;
            this.parolaTB.Size = new System.Drawing.Size(287, 24);
            this.parolaTB.TabIndex = 1;
            this.parolaTB.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.parolaTB.UseSystemPasswordChar = true;
            // 
            // numeTB
            // 
            this.numeTB.FocusedColor = "#508ef5";
            this.numeTB.FontColor = "#999999";
            this.numeTB.IsEnabled = true;
            this.numeTB.Location = new System.Drawing.Point(231, 286);
            this.numeTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numeTB.MaxLength = 32767;
            this.numeTB.Multiline = false;
            this.numeTB.Name = "numeTB";
            this.numeTB.ReadOnly = false;
            this.numeTB.Size = new System.Drawing.Size(287, 24);
            this.numeTB.TabIndex = 0;
            this.numeTB.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.numeTB.UseSystemPasswordChar = false;
            // 
            // FormaInregistrare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(564, 598);
            this.Controls.Add(this.lollipopLabel4);
            this.Controls.Add(this.ImagineProfilPB);
            this.Controls.Add(this.ButonInregistrare);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lollipopLabel1);
            this.Controls.Add(this.lollipopLabel3);
            this.Controls.Add(this.parolaReintrodusaTB);
            this.Controls.Add(this.lollipopLabel2);
            this.Controls.Add(this.parolaTB);
            this.Controls.Add(this.numeTB);
            this.Controls.Add(this.ButonInapoiLogare);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormaInregistrare";
            this.ShowIcon = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inregistrare";
            this.Load += new System.EventHandler(this.FormaInregistrare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagineProfilPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButonInapoiLogare;
        private LollipopLabel lollipopLabel3;
        private LollipopLabel lollipopLabel2;
        private LollipopTextBox parolaTB;
        private LollipopTextBox numeTB;
        private LollipopTextBox parolaReintrodusaTB;
        private LollipopLabel lollipopLabel1;
        private System.Windows.Forms.Panel panel1;
        private LollipopButton ButonInregistrare;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox ImagineProfilPB;
        private LollipopLabel lollipopLabel4;
    }
}