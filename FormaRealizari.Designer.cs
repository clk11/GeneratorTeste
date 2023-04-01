namespace TestGenerator
{
    partial class FormaRealizari
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ButonIesire = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ID_InformatiiRezultat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domeniu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capitol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Punctaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Button = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ButonInapoiProfil = new System.Windows.Forms.Button();
            this.tRezultateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRezultateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ButonIesire
            // 
            this.ButonIesire.AutoSize = true;
            this.ButonIesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1194F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonIesire.ForeColor = System.Drawing.Color.Red;
            this.ButonIesire.Location = new System.Drawing.Point(1054, -1);
            this.ButonIesire.Name = "ButonIesire";
            this.ButonIesire.Size = new System.Drawing.Size(32, 31);
            this.ButonIesire.TabIndex = 0;
            this.ButonIesire.Text = "&X";
            this.ButonIesire.Click += new System.EventHandler(this.ButonIesire_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18.26866F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(325, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rezultatele Dumneavoastra";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_InformatiiRezultat,
            this.Domeniu,
            this.Capitol,
            this.Punctaj,
            this.Nivel,
            this.Data,
            this.Button});
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(182)))), ((int)(((byte)(250)))));
            this.dataGridView.Location = new System.Drawing.Point(93, 139);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(900, 423);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // ID_InformatiiRezultat
            // 
            this.ID_InformatiiRezultat.HeaderText = "ID_InformatiiRezultat";
            this.ID_InformatiiRezultat.MinimumWidth = 6;
            this.ID_InformatiiRezultat.Name = "ID_InformatiiRezultat";
            this.ID_InformatiiRezultat.ReadOnly = true;
            this.ID_InformatiiRezultat.Visible = false;
            this.ID_InformatiiRezultat.Width = 125;
            // 
            // Domeniu
            // 
            this.Domeniu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Domeniu.HeaderText = "Domeniu";
            this.Domeniu.MinimumWidth = 6;
            this.Domeniu.Name = "Domeniu";
            this.Domeniu.ReadOnly = true;
            // 
            // Capitol
            // 
            this.Capitol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Capitol.HeaderText = "Capitol";
            this.Capitol.MinimumWidth = 6;
            this.Capitol.Name = "Capitol";
            this.Capitol.ReadOnly = true;
            // 
            // Punctaj
            // 
            this.Punctaj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Punctaj.HeaderText = "Punctaj";
            this.Punctaj.MinimumWidth = 6;
            this.Punctaj.Name = "Punctaj";
            this.Punctaj.ReadOnly = true;
            // 
            // Nivel
            // 
            this.Nivel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nivel.HeaderText = "Nivel";
            this.Nivel.MinimumWidth = 6;
            this.Nivel.Name = "Nivel";
            this.Nivel.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Data.HeaderText = "Data";
            this.Data.MinimumWidth = 6;
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Button
            // 
            this.Button.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Button.DefaultCellStyle = dataGridViewCellStyle1;
            this.Button.HeaderText = "Test";
            this.Button.MinimumWidth = 6;
            this.Button.Name = "Button";
            this.Button.ReadOnly = true;
            this.Button.Text = "Afisare test";
            this.Button.UseColumnTextForButtonValue = true;
            // 
            // ButonInapoiProfil
            // 
            this.ButonInapoiProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonInapoiProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonInapoiProfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButonInapoiProfil.Location = new System.Drawing.Point(0, -1);
            this.ButonInapoiProfil.Name = "ButonInapoiProfil";
            this.ButonInapoiProfil.Size = new System.Drawing.Size(157, 36);
            this.ButonInapoiProfil.TabIndex = 4;
            this.ButonInapoiProfil.Text = "Inapoi la profil";
            this.ButonInapoiProfil.UseVisualStyleBackColor = true;
            this.ButonInapoiProfil.Click += new System.EventHandler(this.ButonInapoiProfil_Click);
            // 
            // tRezultateBindingSource
            // 
            this.tRezultateBindingSource.DataSource = typeof(TestGenerator.t_Rezultate);
            // 
            // FormaRealizari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(182)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1084, 641);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.ButonInapoiProfil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButonIesire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormaRealizari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormaRezultate_Button_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRezultateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ButonIesire;
        private System.Windows.Forms.BindingSource tRezultateBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button ButonInapoiProfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_InformatiiRezultat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domeniu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capitol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Punctaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewButtonColumn Button;
    }
}