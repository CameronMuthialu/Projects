using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTournaments
{
    public partial class frmEvents : Form
    {
        Tournament model;
        Event eventModel = new Event();

        public frmEvents(Tournament tournament)
        {
            InitializeComponent();

            model = tournament;

            LoadTournamentEvents();
        }
        public void LoadTournamentEvents()
        {

            var db = new ApplicationDBContext();

            var tournamentEvents = db.Events
                .Where(x => x.FK_TournamentID == model.TournamentID)
                .ToList();

            dgvEvents.DataSource = tournamentEvents;
            txtTournId.Text = model.TournamentID.ToString();
            txtTournId.Enabled = false;

        }
        private void dgvEvents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEvents.CurrentRow.Index != 1)
            {
                int eventID = Convert.ToInt32(dgvEvents.CurrentRow.Cells["EventID"].Value);

                using (ApplicationDBContext db = new ApplicationDBContext())
                {
                    eventModel = db.Events
                        .FirstOrDefault(x => x.EventID == eventID);

                    txtTournId.Text = eventModel.FK_TournamentID.ToString();
                    txtEventName.Text = eventModel.EventName;
                    txtEventNo.Text = eventModel.EventNumber.ToString();
                    dtStart.Value = eventModel.EventDateTime;
                    dtEnd.Value = eventModel.EventEndDateTime.Value;

                }
                btnAdd.Text = "Update";

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            eventModel.FK_TournamentID = Convert.ToInt32(txtTournId.Text);
            eventModel.EventName = txtEventName.Text;
            eventModel.EventNumber = Convert.ToInt16(txtEventNo.Text);
            eventModel.EventDateTime = dtEnd.Value;
            eventModel.EventEndDateTime = dtEnd.Value;
            // eventModel.AutoClose = Convert.ToBoolean(txtAutClose.Text);
            using (ApplicationDBContext db = new ApplicationDBContext())
            {
                if (eventModel.EventID == 0)//Insert
                    db.Events.Add(eventModel);
                else
                    db.Entry(eventModel).State = EntityState.Modified;//Update                
                db.SaveChanges();

            }
            EventClear();
            MessageBox.Show("Added Successfully");
            LoadTournamentEvents();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            ApplicationDBContext db = new ApplicationDBContext();
            int eventID = Convert.ToInt32(dgvEvents.CurrentRow.Cells["EventID"].Value);

            eventModel = db.Events
                .FirstOrDefault(x => x.EventID == eventID);
          
            frmEventDetail fd = new frmEventDetail(eventModel);
            fd.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to continue?", "Tournament", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (ApplicationDBContext db = new ApplicationDBContext())
                {
                    var entry = db.Entry(eventModel);
                    if (entry.State == EntityState.Detached)
                        db.Events.Attach(eventModel);
                    db.Events.Remove(eventModel);

                    db.SaveChanges();
                    EventClear();
                    LoadTournamentEvents();

                    MessageBox.Show("Deleted Successfully");
                    btnAdd.Text = "Add New";
                }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            EventClear();
            LoadTournamentEvents();
        }

        private void EventClear()
        {
            txtAutClose.Text = "";
            txtEventName.Text = "";
            txtEventNo.Text = "";

        }
    }
}
