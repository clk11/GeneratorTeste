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
    public partial class FormaRealizari : Form
    {
        public static List<t_Rezultate> L { get; set; }
        public FormaRealizari()
        {
            InitializeComponent();            
        }
        private void ButonIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        
        private void FormaRezultate_Button_Load(object sender, EventArgs e)
        {
            L = new List<t_Rezultate>();
            using (TesteDBEntities db = new TesteDBEntities())
            {                
                #region Fill the datagridview               
                int count = 0;
                foreach (var item in db.t_InformatiiRezultate)
                {
                    if (item.ID_Cont == FormaLogare.ValoareID)
                    {
                        this.dataGridView.Rows.Add();
                        this.dataGridView.Rows[count].Cells[0].Value = item.ID_InformatiiRezultat;
                        this.dataGridView.Rows[count].Cells[1].Value = item.t_Capitole.t_Domenii.Domeniu;
                        this.dataGridView.Rows[count].Cells[2].Value = item.t_Capitole.Capitol;
                        this.dataGridView.Rows[count].Cells[3].Value = item.Punctaj;
                        this.dataGridView.Rows[count].Cells[4].Value = item.Nivel;
                        this.dataGridView.Rows[count].Cells[5].Value = item.Data;
                        count++;
                    }
                }
                #endregion
            }
        }
        private void ButonInapoiProfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaProfil frm = new FormaProfil();
            frm.ShowDialog();
            this.Close();
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex >= 0) 
            {                
                using (TesteDBEntities db = new TesteDBEntities())
                {
                    int value=int.Parse(this.dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());                   
                    L = (db.t_Rezultate.Where(x => x.ID_InformatiiRezultat == value)).ToList();
                    new FormaRezultatTest().ShowDialog();                    
                }
            }
        }            
    }
}
