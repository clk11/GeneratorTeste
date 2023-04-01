namespace TestGenerator
{
    partial class FormaMeniu
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
            this.DomeniiCB = new System.Windows.Forms.ComboBox();
            this.CapitoleCB = new System.Windows.Forms.ComboBox();
            this.ButonGenerareTest = new LollipopButton();
            this.ButonInapoiLaProfil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DomeniiCB
            // 
            this.DomeniiCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DomeniiCB.FormattingEnabled = true;
            this.DomeniiCB.Location = new System.Drawing.Point(192, 118);
            this.DomeniiCB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DomeniiCB.Name = "DomeniiCB";
            this.DomeniiCB.Size = new System.Drawing.Size(262, 38);
            this.DomeniiCB.TabIndex = 0;
            // 
            // CapitoleCB
            // 
            this.CapitoleCB.Enabled = false;
            this.CapitoleCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapitoleCB.FormattingEnabled = true;
            this.CapitoleCB.Location = new System.Drawing.Point(192, 188);
            this.CapitoleCB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CapitoleCB.Name = "CapitoleCB";
            this.CapitoleCB.Size = new System.Drawing.Size(262, 38);
            this.CapitoleCB.TabIndex = 0;
            // 
            // ButonGenerareTest
            // 
            this.ButonGenerareTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonGenerareTest.Location = new System.Drawing.Point(446, 277);
            this.ButonGenerareTest.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButonGenerareTest.Name = "ButonGenerareTest";
            this.ButonGenerareTest.Size = new System.Drawing.Size(217, 57);
            this.ButonGenerareTest.TabIndex = 2;
            this.ButonGenerareTest.Text = "Genereaza Test";
            this.ButonGenerareTest.UseVisualStyleBackColor = true;
            this.ButonGenerareTest.Click += new System.EventHandler(this.ButonGenerareTest_Click);
            // 
            // ButonInapoiLaProfil
            // 
            this.ButonInapoiLaProfil.AutoSize = true;
            this.ButonInapoiLaProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ButonInapoiLaProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonInapoiLaProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonInapoiLaProfil.Location = new System.Drawing.Point(12, 309);
            this.ButonInapoiLaProfil.Name = "ButonInapoiLaProfil";
            this.ButonInapoiLaProfil.Size = new System.Drawing.Size(147, 25);
            this.ButonInapoiLaProfil.TabIndex = 3;
            this.ButonInapoiLaProfil.Text = "Inapoi la profil ?\r\n";
            this.ButonInapoiLaProfil.Click += new System.EventHandler(this.ButonInapoiLaProfil_Click);
            // 
            // FormaMeniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(675, 342);
            this.Controls.Add(this.ButonInapoiLaProfil);
            this.Controls.Add(this.ButonGenerareTest);
            this.Controls.Add(this.CapitoleCB);
            this.Controls.Add(this.DomeniiCB);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormaMeniu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meniu";
            this.Load += new System.EventHandler(this.FormaMeniu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DomeniiCB;
        private System.Windows.Forms.ComboBox CapitoleCB;
        private LollipopButton ButonGenerareTest;
        private System.Windows.Forms.Label ButonInapoiLaProfil;
    }
}