using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTournaments
{
    public partial class Form1 : Form
    {
        Tournament model = new Tournament();
        
        public Form1()
        {
            InitializeComponent();
        }

       

       
        private void Clear()
        {
            txtTourn.Text = "";
            btnAdd.Text = "Add New";
        }

        private ApplicationDBContext db = new ApplicationDBContext();

        void LoadDgv()
        {
            var t = new List<TournamentDTO>();

            foreach (var item in db.Tournaments)

                t.Add(new TournamentDTO
                {
                    TournamentID = item.TournamentID,
                    TournamentName = item.TournamentName
                });

            dgvTournaments.DataSource = t;

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            model.TournamentName = txtTourn.Text.Trim();
            using (ApplicationDBContext db = new ApplicationDBContext())
            {
                if (model.TournamentID == 0)//Insert
                    db.Tournaments.Add(model);
                else
                    db.Entry(model).State = EntityState.Modified;//Update                
                db.SaveChanges();

            }
            Clear();
            MessageBox.Show("Added Successfully");
            LoadDgv();
        }

        private void btnDetails_Click_1(object sender, EventArgs e)
        {
            int tournamentID = Convert.ToInt32(dgvTournaments.CurrentRow.Cells["TournamentID"].Value);

            model = db.Tournaments
                .FirstOrDefault(x => x.TournamentID == tournamentID);
            txtTourn.Text = model.TournamentName;
            frmEvents f = new frmEvents(model);
            f.ShowDialog();
        }

        private void btnDel_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Tournament and linked Events?", "Tournament", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (ApplicationDBContext db = new ApplicationDBContext())
                {
                    //var result = db.DeleteTournamentHistory();

                }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {

            Clear();
            LoadDgv();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Clear();
            LoadDgv();
        }

        private void dgvTournaments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //populate data in textbox
            if (dgvTournaments.CurrentRow.Index != 1)
            {
                int tournamentID = Convert.ToInt32(dgvTournaments.CurrentRow.Cells["TournamentID"].Value);

                using (ApplicationDBContext db = new ApplicationDBContext())
                {
                    model = db.Tournaments
                        .FirstOrDefault(x => x.TournamentID == tournamentID);
                    txtTourn.Text = model.TournamentName;
                }
                btnAdd.Text = "Update";
            }
        }
    }
}
