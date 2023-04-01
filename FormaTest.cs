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
    public partial class FormaTest : Form
    {
        public static int punctaj{ get; set; }
        public bool stop = false;
        public int pozitieIntrebare { get; set; }
        public t_Intrebari obj { get; set; }
        public static List<t_IntrebariRezultate> ListObj = new List<t_IntrebariRezultate>();
        public int numarIntrebari = 0;
        List<int> ListaIDuriIntrebari = new List<int>();
        public FormaTest()
        {
            InitializeComponent();
        }       
        private void FormaTest_Load(object sender, EventArgs e)
        {
            this.ButonInainte.Click += delegate { this.Stereotip(); };
            this.ButonIesire.Click += delegate
            {
                if (MessageBox.Show("Sunteti sigur(a) ? Restul de intrebari vor fi catalogate drept gresite ", "Intrebare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Timer.Stop();
                    while (this.stop!=true)
                    {
                        this.Stereotip();
                    }
                }
            };
            punctaj = 0;
            this.GenereazaIntrebarile();
            this.UrmatoareaIntreabare();
            this.MinuteRamase.Text = (int.Parse(FormaMeniu.Setup[1]) - 1).ToString();
            this.Timer.Start();
        }
        private void Stereotip()
        {
            #region Raspunsuri utilizator
            ListObj.Add(new t_IntrebariRezultate()
            {
                ID_Intrebare = obj.ID_Intrebare,
                Raspuns1 = this.varianta1CB.Checked,
                Raspuns2 = this.varianta2CB.Checked,
                Raspuns3 = this.varianta3CB.Checked,
                Raspuns4 = this.varianta4CB.Checked
            });
            #endregion
            this.VerificareIntrebare();
            this.Debifeaza();
            this.UrmatoareaIntreabare();
            int variable = numarIntrebari + 2;
            NumarIntrebareLB.Text = "#" + variable;
            if (numarIntrebari == int.Parse(FormaMeniu.Setup[0]) - 2)
            {
                this.ButonInainte.Text = "Finalizare";
            }
            if (numarIntrebari == int.Parse(FormaMeniu.Setup[0]) - 1)
            {
                this.Timer.Stop();
                this.stop = true;
                progres.Increment(100 / (int.Parse(FormaMeniu.Setup[0])));
                this.Hide(); new FormaRezultat().ShowDialog();this.Close();
            }
            else
            {
                this.numarIntrebari++;
                progres.Increment(100 / (int.Parse(FormaMeniu.Setup[0])));
            }           
        }
        private void UrmatoareaIntreabare()
        {          
            using (TesteDBEntities db = new TesteDBEntities()) 
            {               
                int id = this.ListaIDuriIntrebari[this.pozitieIntrebare];
                this.obj = db.t_Intrebari.FirstOrDefault(x => x.ID_Intrebare == id);
                this.IntrebareLB.Text = obj.EnuntIntrebare;
                this.varianta1CB.Text = obj.t_Variante.t_TexteVariante.TextVarianta;
                this.varianta2CB.Text = obj.t_Variante1.t_TexteVariante.TextVarianta;
                this.varianta3CB.Text = obj.t_Variante2.t_TexteVariante.TextVarianta;
                this.varianta4CB.Text = obj.t_Variante3.t_TexteVariante.TextVarianta;
                this.ImagineIntrebareLB.Image = FormaProfil.ConvertBinaryToImage(obj.Imagine);
                if (this.pozitieIntrebare != int.Parse(FormaMeniu.Setup[0]) - 1) 
                {
                    this.pozitieIntrebare++;
                }
            }
        }
        private void VerificareIntrebare()
        {
            this.ButonInainte.Enabled = false;
            bool Picat = false;                    
            using (TesteDBEntities db = new TesteDBEntities())
            {
                if (this.varianta1CB.Checked != this.obj.t_Variante.Corecta)
                {                    
                    Picat = true;            
                }          
                if (Picat == false)
                {
                    if (varianta2CB.Checked != this.obj.t_Variante1.Corecta)
                    {
                        Picat = true;                    
                    }
                }       
                if (Picat == false)
                {
                    if (varianta3CB.Checked != this.obj.t_Variante2.Corecta)
                    {
                        Picat = true;                      
                    }
                }              
                if (Picat == false)
                {
                    if (varianta4CB.Checked != this.obj.t_Variante3.Corecta)
                    {
                        Picat = true;                        
                    }
                }
                if (Picat == true)
                {
                    punctaj -= 100/(int.Parse(FormaMeniu.Setup[0]));
                }
                else
                {
                    punctaj += 100 / (int.Parse(FormaMeniu.Setup[0]));
                }
            }
            this.ButonInainte.Enabled = true;
        }
        private void Debifeaza()
        {
            if (this.varianta1CB.Checked == true) { this.varianta1CB.Checked = false; }
            if (this.varianta2CB.Checked == true) { this.varianta2CB.Checked = false; }
            if (this.varianta3CB.Checked == true) { this.varianta3CB.Checked = false; }
            if (this.varianta4CB.Checked == true) { this.varianta4CB.Checked = false; }
        }
        private void GenereazaIntrebarile()
        {          
            using (TesteDBEntities db = new TesteDBEntities())
            {
                var L = (db.t_Intrebari.Where
                    (x => x.t_Capitole.Capitol == FormaMeniu.TextCapitol && x.t_Capitole.t_Domenii.Domeniu == FormaMeniu.TextDomeniu && x.t_Dificultati.Dificultate == FormaMeniu.Dif)).Select
                    (y => y.ID_Intrebare).ToList();
                Random rnd = new Random();
                while (this.ListaIDuriIntrebari.Count != int.Parse(FormaMeniu.Setup[0]))
                {
                    int value = L[rnd.Next(L.Count)];
                    if (!this.ListaIDuriIntrebari.Contains(value))
                    {
                        this.ListaIDuriIntrebari.Add(value);
                    }
                }                
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (int.Parse(this.SecundeRamaseLB.Text.Trim()) == 0)
            {
                this.MinuteRamase.Text = (int.Parse(this.MinuteRamase.Text.Trim()) - 1).ToString();
                this.SecundeRamaseLB.Text = "59";
            }
            else
            {
                this.SecundeRamaseLB.Text = (int.Parse(this.SecundeRamaseLB.Text.Trim()) - 1).ToString();
            }
            if (this.MinuteRamase.Text.Trim() == "0" && this.SecundeRamaseLB.Text == "0") 
            {
                this.Timer.Stop();
                this.Timer.Stop();
                while (this.stop != true)
                {
                    this.Stereotip();
                }
            }
        }
    }
}