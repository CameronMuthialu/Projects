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
    public partial class frmEventDetail : Form
    {
        Event eventModels;
        EventDetail eventDetailModel = new EventDetail();


        public frmEventDetail(Event eventModel)
        {
            InitializeComponent();

            eventModels = eventModel;

        }

        private void EventDetailClear()
        {
            txtEvntDetName.Text = "";
            txtEvntDetNo.Text = "";
            txtEvntDetOdd.Text = "";
            txtFinPos.Text = "";
            
        }

        public void LoadEventsDetails()
        {

            var db = new ApplicationDBContext();

            var EventsDetails = db.EventDetails
                .Where(x => x.FK_EventID == eventModels.EventID)
                .ToList();

            dgvEventDets.DataSource = EventsDetails;
            txtEventID.Text = eventModels.EventID.ToString();
            txtEventID.Enabled = false;
            txtEvDetID.Enabled = false;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            eventDetailModel.FK_EventID = Convert.ToInt32(txtEventID.Text);
            eventDetailModel.FK_EventDetailStatusID = Convert.ToInt16(cbxEvntDetStID.SelectedItem);
            eventDetailModel.EventDetailName = txtEvntDetName.Text;
            eventDetailModel.EventDetailNumber = Convert.ToInt16(txtEvntDetNo.Text);
            eventDetailModel.EventDetailOdd = Convert.ToDecimal(txtEvntDetOdd.Text);
            eventDetailModel.FinishingPostion = Convert.ToInt16(txtFinPos.Text);
            eventDetailModel.FirstTimer = Convert.ToBoolean(txtFirstTime.Text);

            using (ApplicationDBContext db = new ApplicationDBContext())
            {
                if (eventDetailModel.EventDetailID == 0)//Insert
                    db.EventDetails.Add(eventDetailModel);
                else
                    db.Entry(eventDetailModel).State = EntityState.Modified;//Update                
                db.SaveChanges();

            }
            EventDetailClear();
            MessageBox.Show("Added Successfully");
            LoadEventsDetails();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to continue?", "Tournament", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (ApplicationDBContext db = new ApplicationDBContext())
                {
                    var entry = db.Entry(eventDetailModel);
                    if (entry.State == EntityState.Detached)
                        db.EventDetails.Attach(eventDetailModel);
                    db.EventDetails.Remove(eventDetailModel);

                    db.SaveChanges();
                    EventDetailClear();
                    LoadEventsDetails();

                    MessageBox.Show("Deleted Successfully");
                    btnAdd.Text = "Add New";
                }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            EventDetailClear();
            LoadEventsDetails();
        }
    }
}
