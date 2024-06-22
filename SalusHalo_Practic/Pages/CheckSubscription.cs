using Google.Protobuf.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalusHalo_Practic
{
    public partial class CheckSubscription : UserControl
    {
        public CheckSubscription(int subscriptionId)
        {
            InitializeComponent();

            HistorySubscriptions subcriptionHistory = DB.GetSubscriptionHistory(subscriptionId);
            lbSubId.Text = subscriptionId.ToString();
            lbVisitor.Text = DB.GetVisitorName(subcriptionHistory.VisitorId);
            lbEndDate.Text = subcriptionHistory.EndTime.ToShortDateString();
            lbNumOfSessions.Text = subcriptionHistory.NumOfSessions.ToString();
            lbNumOfVisits.Text = subcriptionHistory.NumOfVisits.ToString();
            lbRemainingVisits.Text = subcriptionHistory.RemainingVisits.ToString();
            lbStatus.Text = subcriptionHistory.Status.ToString();


            var allVisits = DB.GetAllVisits(subscriptionId);
            dataGridView1.Rows.Clear();
            foreach (var visit in allVisits)
            {
                string date = visit.Key.ToString("dd.MM.yyyy"); 
                string time = visit.Value.ToString(@"hh\:mm");
                dataGridView1.Rows.Add(date, time);
            }


        }
        

    }
}
