using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Threading;
namespace TestGenerator
{
    public partial class FormaLogare : MaterialForm
    {
        public int NivelIncrementare { get; set; }
        public FormaInregistrare frm { get; set; }
        public Thread thr { get; set; }
        public int pozitie { get; set; }
        public static int ValoareID { get; set; }
        public FormaLogare()
        {
            InitializeComponent();
        }

        private void FormaLogare_Load(object sender, EventArgs e)
        {           
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);
        }        
        private void ButonInregistrare_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            this.ButonInregistrare.Enabled = false;
            this.frm = new FormaInregistrare();
            this.frm.Show();
            this.BringToFront();
        }                       
        private void ButonLogare_Click(object sender, EventArgs e)
        {
            if (this.numeTB.Text.Trim().Length == 0 || this.parolaTB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Trebuie sa completati tot !!!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (TesteDBEntities db = new TesteDBEntities())
                {
                    bool verificare = db.t_Conturi.Any(x => x.Nume.Trim() == numeTB.Text.Trim() && x.ID_Parola == (db.t_Parole.FirstOrDefault(y => y.Parola == parolaTB.Text.Trim())).ID_Parola && x.t_DomeniiAdministratori.Count == 0);
                    if (verificare)
                    {
                        var Utilizator = db.t_Conturi.FirstOrDefault(c => c.Nume.Trim() == numeTB.Text.Trim());
                        ValoareID = Utilizator.ID_Cont;
                        MessageBox.Show("V-ati logat cu success !!!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        FormaProfil frm = new FormaProfil();
                        frm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Numele sau parola au fost introduse incorect !!!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.pozitie += 20;this.frm.Left += 20;
            if (this.pozitie >= this.Width - 25)
            {
                this.timer1.Stop();
                this.frm.BringToFront();
                this.timer2.Start();
            }
        }
        private void DeschideForma()
        {
            Application.Run(new FormaInregistrare());
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.pozitie -= 20; this.frm.Left -= 20;
            if (this.pozitie <= 0) 
            {                             
                this.timer2.Stop();
                this.Close();
                this.thr = new Thread(this.DeschideForma);
                this.thr.SetApartmentState(ApartmentState.STA);
                this.thr.Start();
            }
        }                   
    }
}