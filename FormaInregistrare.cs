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
using System.IO;
namespace TestGenerator
{
    public partial class FormaInregistrare : MaterialForm
    {
        public int NivelIncrementare { get; set; }
        public Thread thr { get; set; }
        public int pozitie { get; set; }
        public FormaLogare frm { get; set; }
        public FormaInregistrare()
        {
            InitializeComponent();
        }
        private void ButonInapoiLogare_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            this.ButonInapoiLogare.Enabled = false;
            this.frm = new FormaLogare();
            this.frm.Show();
            this.BringToFront();
        }        
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FormaInregistrare_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);
        }
        private void ButonInregistrare_Click(object sender, EventArgs e)
        {
            if (this.numeTB.Text.Trim().Length == 0 || this.parolaTB.Text.Trim().Length == 0 || this.parolaReintrodusaTB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Trebuie sa completati tot !!!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (this.parolaTB.Text.Trim() != this.parolaReintrodusaTB.Text.Trim())
                {
                    MessageBox.Show("Parola reintrodusa este gresita !!!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (TesteDBEntities db = new TesteDBEntities())
                    {
                        bool verificareNumeUtilizator = db.t_Conturi.Any(x => x.Nume.Trim() == this.numeTB.Text.Trim());
                        if (verificareNumeUtilizator)
                        {
                            MessageBox.Show("Exista deja un utilizator care detine numele pe care l-ati introdus !!!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.parolaTB.Text = string.Empty; this.parolaReintrodusaTB.Text = string.Empty; this.numeTB.Text = string.Empty; this.numeTB.Focus();
                        }
                        else
                        {
                            bool verificareParolaUtilizator = db.t_Parole.Any(x => x.Parola.Trim() == this.parolaTB.Text.Trim());
                            if (verificareParolaUtilizator == false)
                            {
                                db.t_Parole.Add(new t_Parole() { Parola = this.parolaTB.Text.Trim() });
                                db.SaveChanges();
                            }
                            if (this.ImagineProfilPB.ImageLocation==null)
                            {
                                db.t_Conturi.Add(new t_Conturi() { Nume = this.numeTB.Text.Trim(), ID_Parola = (db.t_Parole.FirstOrDefault(x => x.Parola.Trim() == this.parolaTB.Text.Trim())).ID_Parola, ImagineProfil = null });
                            }
                            else
                            {
                                db.t_Conturi.Add(new t_Conturi() { Nume = this.numeTB.Text.Trim(), ID_Parola = (db.t_Parole.FirstOrDefault(x => x.Parola.Trim() == this.parolaTB.Text.Trim())).ID_Parola, ImagineProfil = this.ConvertImageToBinary(this.ImagineProfilPB.Image) });
                            }
                            db.SaveChanges();
                            MessageBox.Show("Inregistrare realizata cu success !!!");
                        }
                        this.ButonInapoiLogare_Click(sender, e);
                    }
                }
            }
        }
        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.pozitie += 20; this.frm.Left += 20;
            if (this.pozitie >= this.Width - 25)
            {
                this.timer1.Stop();
                this.frm.BringToFront();
                this.timer2.Start();
            }
        }
        private void DeschideForma()
        {
            Application.Run(new FormaLogare());
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
        private void ImagineProfil_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    this.ImagineProfilPB.ImageLocation = ofd.FileName.ToString();
                }
            }
        }          
    }
}
