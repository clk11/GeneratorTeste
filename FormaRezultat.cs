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
    public partial class FormaRezultat : Form
    {       
        public FormaRezultat()
        {
            InitializeComponent();           
        }
        private void ButonIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FormaRezultat_Load(object sender, EventArgs e)
        {
            float value = (100 / 2) + (100 / (int.Parse(FormaMeniu.Setup[0])));
            if (FormaTest.punctaj < 0)
            {
                FormaTest.punctaj = 0;
            }            
            using (TesteDBEntities db = new TesteDBEntities())
            {
                #region Adauga informatiile rezultatului
                var info = new t_InformatiiRezultate()
                {
                    Data = DateTime.Now,
                    ID_Cont = FormaLogare.ValoareID,
                    ID_Capitol = (db.t_Capitole.FirstOrDefault(x => x.Capitol == FormaMeniu.TextCapitol && x.t_Domenii.Domeniu == FormaMeniu.TextDomeniu)).ID_Capitol,
                    Punctaj = FormaTest.punctaj
                };
                if (FormaMeniu.ModAddRezultat)
                {
                    if (FormaTest.punctaj >= value)
                    {
                        info.Nivel = 2;
                    }
                    else
                    {
                        info.Nivel = 1;
                    }
                }
                else
                {
                    if (FormaTest.punctaj >= value)
                    {
                        info.Nivel = FormaMeniu.NivelUltimulRezultat + 1;
                    }
                    else
                    {
                        info.Nivel = FormaMeniu.NivelUltimulRezultat;
                    }
                }
                db.t_InformatiiRezultate.Add(info);
                db.SaveChanges();
                #endregion
                #region Adauga Raspunsurile pe care le-a data utilizatorul
                List<t_IntrebariRezultate> Values = db.t_IntrebariRezultate.ToList();
                for (int i = 0; i < FormaTest.ListObj.Count; i++)
                {
                    if (Values.Contains(FormaTest.ListObj[i]) == false)
                    {
                        db.t_IntrebariRezultate.Add(FormaTest.ListObj[i]);
                    }
                    db.SaveChanges();
                }
                #endregion
                #region Adauga rezultatul
                foreach (var item in FormaTest.ListObj)
                {
                    db.t_Rezultate.Add(new t_Rezultate()
                    {
                        ID_InformatiiRezultat = (db.t_InformatiiRezultate.FirstOrDefault(x => x.ID_InformatiiRezultat == info.ID_InformatiiRezultat)).ID_InformatiiRezultat,
                        ID_IntrebareRezultat = (db.t_IntrebariRezultate.FirstOrDefault(x => x.ID_IntrebareRezultat == item.ID_IntrebareRezultat)).ID_IntrebareRezultat
                    });
                    db.SaveChanges();
                }
                FormaTest.ListObj.Clear();
                Values.Clear();
                #endregion
            }
            #region Afisare
            if (FormaTest.punctaj <= 50)
            {
                this.MesajLB.Text = "Din pacate nu ai trecut testul :(";
                this.RealizariLB.Text = "Ati obtinut doar ";
                this.RealizariLB.Text += FormaTest.punctaj + " puncte ";
                this.GlowingPanEditMethod(Color.Red);
            }
            else
            {
                this.MesajLB.Text = "Felicitari , ai trecut testul :)";
                this.RealizariLB.Text = "Ati crescut in nivel , obtinand  ";
                this.RealizariLB.Text += FormaTest.punctaj + " puncte !!!";
                this.GlowingPanEditMethod(Color.Green);
            }
            this.glowingPanel1.StartAnimation(); this.glowingPanel2.StartAnimation();
            this.glowingPanel3.StartAnimation(); this.glowingPanel4.StartAnimation();
            #endregion
        }
        private void GlowingPanEditMethod(Color c)
        {
            this.glowingPanel1.CuloareAnimatiePanel = c;
            this.glowingPanel2.CuloareAnimatiePanel = c;
            this.glowingPanel3.CuloareAnimatiePanel = c;
            this.glowingPanel4.CuloareAnimatiePanel = c;
        }
        private void InapoiLaProfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaProfil frm = new FormaProfil();
            frm.ShowDialog();
            this.Close();
        }
    }
}
