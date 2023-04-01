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
using System.IO;
using System.Data.Entity;
using System.Threading;
namespace TestGenerator
{
    public partial class FormaProfil : MaterialForm
    {
        public FormaProfil()
        {
            InitializeComponent();
            //====================
        }        
        private void FormaProfil_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);
            //====================================================
            using (TesteDBEntities db = new TesteDBEntities())
            {
                t_Conturi contUser=db.t_Conturi.FirstOrDefault(x => x.ID_Cont == FormaLogare.ValoareID);
                this.NumeUtilizatorLB.Text = contUser.Nume;
                if (contUser.ImagineProfil != null)
                {
                    this.ImagineProfilPB.Image = ConvertBinaryToImage(contUser.ImagineProfil);
                }
                else
                {
                    this.DefaultLB.Text = "no image \n here :(";
                    this.DefaultLB.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                }
            }
            this.ID_UtilizatorLB.Text = FormaLogare.ValoareID.ToString();
            this.QuestionMarkLB.MouseEnter += delegate { this.MesajQuestionMarkLB.Visible = true; };
            this.QuestionMarkLB.MouseLeave += delegate { this.MesajQuestionMarkLB.Visible = false; };
        }
        public static Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        private void FormaMeniuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaMeniu frm = new FormaMeniu();
            frm.ShowDialog();
            this.Close();
        }
        private void ButonRealizari_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaRealizari frm = new FormaRealizari();
            frm.ShowDialog();
            this.Close();
        }
        private void ButtonIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ButonLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sunteti sigur(a) ca doriti sa va delogati ?", "Atentie ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
        private byte[] ConvertImageToByte(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);//Switch pentru formate , sau conditie stricta pentru png
                return ms.ToArray();
            }
        }
        private void ImagineProfilPB_Click(object sender, EventArgs e)
        {
            using (TesteDBEntities db = new TesteDBEntities())
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        this.ImagineProfilPB.ImageLocation = ofd.FileName;
                        var contUser = db.t_Conturi.FirstOrDefault(x => x.ID_Cont == FormaLogare.ValoareID);
                        this.DefaultLB.Hide();
                        MessageBox.Show("Ti-ai schimbat imaginea de profil !!!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.t_Conturi.Attach(contUser);
                        contUser.ImagineProfil = this.ConvertImageToByte(this.ImagineProfilPB.Image);
                        db.SaveChanges();
                    }
                }
            }
        }                                           
    }
}
