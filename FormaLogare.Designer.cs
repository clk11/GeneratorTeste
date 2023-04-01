namespace TestGenerator
{
    partial class FormaLogare
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
            this.label3 = new System.Windows.Forms.Label();
            this.ButonInregistrare = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButonLogare = new LollipopButton();
            this.lollipopLabel3 = new LollipopLabel();
            this.lollipopLabel2 = new LollipopLabel();
            this.parolaTB = new LollipopTextBox();
            this.numeTB = new LollipopTextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 4;
            // 
            // ButonInregistrare
            // 
            this.ButonInregistrare.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ButonInregistrare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonInregistrare.Location = new System.Drawing.Point(11, 557);
            this.ButonInregistrare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButonInregistrare.Name = "ButonInregistrare";
            this.ButonInregistrare.Size = new System.Drawing.Size(125, 32);
            this.ButonInregistrare.TabIndex = 4;
            this.ButonInregistrare.Text = "Inregistrare";
            this.ButonInregistrare.UseVisualStyleBackColor = false;
            this.ButonInregistrare.Click += new System.EventHandler(this.ButonInregistrare_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::TestGenerator.Properties.Resources.images;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(152, 94);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 165);
            this.panel1.TabIndex = 8;
            // 
            // ButonLogare
            // 
            this.ButonLogare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonLogare.Location = new System.Drawing.Point(384, 538);
            this.ButonLogare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButonLogare.Name = "ButonLogare";
            this.ButonLogare.Size = new System.Drawing.Size(170, 40);
            this.ButonLogare.TabIndex = 3;
            this.ButonLogare.Text = "Logare";
            this.ButonLogare.UseVisualStyleBackColor = true;
            this.ButonLogare.Click += new System.EventHandler(this.ButonLogare_Click);
            // 
            // lollipopLabel3
            // 
            this.lollipopLabel3.AutoSize = true;
            this.lollipopLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lollipopLabel3.Location = new System.Drawing.Point(64, 424);
            this.lollipopLabel3.Name = "lollipopLabel3";
            this.lollipopLabel3.Size = new System.Drawing.Size(78, 24);
            this.lollipopLabel3.TabIndex = 6;
            this.lollipopLabel3.Text = "Parola : ";
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(64, 345);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(149, 24);
            this.lollipopLabel2.TabIndex = 6;
            this.lollipopLabel2.Text = "Nume utilizator : ";
            // 
            // parolaTB
            // 
            this.parolaTB.FocusedColor = "#508ef5";
            this.parolaTB.FontColor = "#999999";
            this.parolaTB.IsEnabled = true;
            this.parolaTB.Location = new System.Drawing.Point(249, 424);
            this.parolaTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parolaTB.MaxLength = 32767;
            this.parolaTB.Multiline = false;
            this.parolaTB.Name = "parolaTB";
            this.parolaTB.ReadOnly = false;
            this.parolaTB.Size = new System.Drawing.Size(282, 24);
            this.parolaTB.TabIndex = 2;
            this.parolaTB.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.parolaTB.UseSystemPasswordChar = true;
            // 
            // numeTB
            // 
            this.numeTB.FocusedColor = "#508ef5";
            this.numeTB.FontColor = "#999999";
            this.numeTB.IsEnabled = true;
            this.numeTB.Location = new System.Drawing.Point(249, 345);
            this.numeTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numeTB.MaxLength = 32767;
            this.numeTB.Multiline = false;
            this.numeTB.Name = "numeTB";
            this.numeTB.ReadOnly = false;
            this.numeTB.Size = new System.Drawing.Size(282, 24);
            this.numeTB.TabIndex = 1;
            this.numeTB.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.numeTB.UseSystemPasswordChar = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FormaLogare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(564, 598);
            this.Controls.Add(this.ButonInregistrare);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButonLogare);
            this.Controls.Add(this.lollipopLabel3);
            this.Controls.Add(this.lollipopLabel2);
            this.Controls.Add(this.parolaTB);
            this.Controls.Add(this.numeTB);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormaLogare";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormaLogare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private LollipopTextBox numeTB;
        private LollipopTextBox parolaTB;
        private LollipopLabel lollipopLabel2;
        private LollipopLabel lollipopLabel3;
        private LollipopButton ButonLogare;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButonInregistrare;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

