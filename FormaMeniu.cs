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
namespace TestGenerator
{
    public partial class FormaMeniu : MaterialForm
    {
        public TesteDBEntities db = new TesteDBEntities();
        public static string[] Setup;
        public static string TextDomeniu { get; set; }
        public static int NivelUltimulRezultat { get; set; }
        public static bool ModAddRezultat = false;
        public static string Dif { get; set; }
        public static string TextCapitol { get; set; }
        public FormaMeniu()
        {
            InitializeComponent();
        }
        private string ExtractTheSetupLocation()
        {
            string value = string.Empty;
            string path = Application.StartupPath;
            string[] V = path.Split('\\');
            for (int i = 0; i < V.Length - 4; i++) 
            {
                value += V[i] + "\\";
            }
            return value + "TestFormat.txt";
        }
        private void ButonIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FormaMeniu_Load(object sender, EventArgs e)
        {
            Setup = File.ReadAllLines(this.ExtractTheSetupLocation());
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);         
            this.DomeniiCB.DataSource = (db.t_Domenii.Select(x => x.Domeniu)).ToList(); this.DomeniiCB.Text = string.Empty;
            this.DomeniiCB.TextChanged += delegate { this.CapitoleCB.Enabled = true; this.CapitoleCB.DataSource = (db.t_Capitole.Where(x => x.t_Domenii.Domeniu == this.DomeniiCB.Text.Trim()).Select(y => y.Capitol)).ToList(); this.CapitoleCB.Text = string.Empty; };
        }
        private void ButonGenerareTest_Click(object sender, EventArgs e)
        {
            if (Setup[2] == "Enabled")
            {
                if (this.CapitoleCB.Text.Trim().Length != 0 && this.DomeniiCB.Text.Trim().Length != 0)
                {
                    var VerificareCapitol = this.db.t_Capitole.FirstOrDefault(x => x.Capitol == this.CapitoleCB.Text.Trim() && x.t_Domenii.Domeniu == this.DomeniiCB.Text.Trim());
                    if (VerificareCapitol != null)
                    {
                        var ExistaRez = this.db.t_InformatiiRezultate.Any(x => x.ID_Cont == FormaLogare.ValoareID &&
                            x.ID_Capitol == VerificareCapitol.ID_Capitol);
                        if (ExistaRez != true)
                        {
                            Dif = "Usor";
                            ModAddRezultat = true;
                        }
                        else
                        {
                            ModAddRezultat = false;
                            var UltimulRezultat = this.db.t_InformatiiRezultate.Where(x => x.ID_Capitol == VerificareCapitol.ID_Capitol && x.ID_Cont == FormaLogare.ValoareID).OrderByDescending(y => y.Nivel).FirstOrDefault();
                            NivelUltimulRezultat = UltimulRezultat.Nivel;
                            if (UltimulRezultat.Nivel == 1)//Rescrisa deoarece pe viitor poate aparea un update pentru DERANK
                            {
                                Dif = "Usor";
                            }
                            else if (UltimulRezultat.Nivel == 2)
                            {
                                Dif = "Medium";
                            }
                            else if (UltimulRezultat.Nivel == 3)
                            {
                                Dif = "Greu";
                            }
                            else if (UltimulRezultat.Nivel == 4)
                            {
                                Dif = "Concurs";
                            }
                        }
                        var count = this.db.t_Intrebari.Count(x => x.ID_Capitol == VerificareCapitol.ID_Capitol && x.t_Dificultati.Dificultate == Dif);
                        if (count >= int.Parse(Setup[0]))
                        {
                            TextCapitol = this.CapitoleCB.Text.Trim();
                            TextDomeniu = this.DomeniiCB.Text.Trim();
                            this.Hide();
                            FormaTest frm = new FormaTest();
                            frm.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ne pare rau dar nu avem suficiente intrebari pentru a genera un test ,va rugam reveniti la un urmator update !", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Informatiile introduse sunt gresite, va rugam sa reintroduceti !", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Trebuie sa completati tot pentru a putea continua !", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Testul nu este inca valabil , asteptati confirmarea profesorului si incercati iar .","Atentie !",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        

        private void ButonInapoiLaProfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaProfil frm = new FormaProfil();
            frm.ShowDialog();
            this.Close();
        }              
    }
}
