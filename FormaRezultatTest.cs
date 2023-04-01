using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TestGenerator
{
    public partial class FormaRezultatTest : Form
    {
        public Font f { get; set; }
        public int QIndex = 0;
        public FormaRezultatTest()
        {
            InitializeComponent();
        }
        private void FormaTestRezultat_Load(object sender, EventArgs e)
        {
            this.UrmatoareaIntreabare();
            this.f = this.ButonInainte.Font;
            #region Events
            this.ButonIesire.Click += delegate { this.Close(); };
            this.ButonInainte.MouseEnter += delegate { this.ButonInainte.BackColor = Color.Yellow; };
            this.ButonInainte.MouseLeave += delegate { this.ButonInainte.BackColor = Color.LightYellow; };
            this.ButonInainte.MouseDown += delegate { this.UrmatoareaIntreabare();this.ButonInainte.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Regular); };
            this.ButonInainte.MouseUp += delegate { this.ButonInainte.Font = this.f; };
            #endregion
        }        
        private void UrmatoareaIntreabare()
        {
            if (this.QIndex == FormaRealizari.L.Count)
            {
                MessageBox.Show("Nu mai sunt intrebari !!!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                #region Atribuie valorile
                var shortcut = FormaRealizari.L[this.QIndex].t_IntrebariRezultate;
                this.IntreabareLB.Text = shortcut.t_Intrebari.EnuntIntrebare;
                this.Varianta1LB.Text = shortcut.t_Intrebari.t_Variante.t_TexteVariante.TextVarianta;
                this.Varianta2LB.Text = shortcut.t_Intrebari.t_Variante1.t_TexteVariante.TextVarianta;
                this.Varianta3LB.Text = shortcut.t_Intrebari.t_Variante2.t_TexteVariante.TextVarianta;
                this.Varianta4LB.Text = shortcut.t_Intrebari.t_Variante3.t_TexteVariante.TextVarianta;
                using (TesteDBEntities db = new TesteDBEntities())
                {
                    #region Declarare "Action"
                    Action<CheckBox, bool> act = (a, b) =>
                    {
                        if (a.Checked == b)
                        {
                            a.Text = "Corect";
                            a.ForeColor = Color.Green;
                        }
                        else
                        {
                            a.Text = "Gresit";
                            a.ForeColor = Color.Red;
                        }
                    };
                    #endregion
                    this.checkBox1.Checked = shortcut.Raspuns1;
                    act(this.checkBox1, shortcut.t_Intrebari.t_Variante.Corecta);
                    this.checkBox2.Checked = shortcut.Raspuns2;
                    act(this.checkBox2, shortcut.t_Intrebari.t_Variante1.Corecta);
                    this.checkBox3.Checked = shortcut.Raspuns3;
                    act(this.checkBox3, shortcut.t_Intrebari.t_Variante2.Corecta);
                    this.checkBox4.Checked = shortcut.Raspuns4;
                    act(this.checkBox4, shortcut.t_Intrebari.t_Variante3.Corecta);
                }
                Image img = FormaProfil.ConvertBinaryToImage(shortcut.t_Intrebari.Imagine);
                if (img != null)
                {
                    this.MesajLB.Visible = false;
                    this.pictureBox.Image = img;
                }
                else
                {
                    this.MesajLB.Visible = true;
                }
                this.QIndex++;
                #endregion
            }
        }        
    }
}
