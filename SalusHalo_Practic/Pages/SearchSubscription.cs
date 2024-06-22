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
    public partial class SearchSubscription : UserControl
    {
        public event EventHandler SubscriptionSearched;
        public SearchSubscription()
        {
            InitializeComponent();
            
        }

        private void btnSearchSub_Click(object sender, EventArgs e)
        {
            int subscriptionId;
            if (!int.TryParse(textSubNum.Text.Trim(), out subscriptionId))
            {
                MessageBox.Show("Введите корректный номер абонемента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DB.SubscriptionExists(subscriptionId))
            {
                MainForm.searchedSubscription.Id = subscriptionId;
                SubscriptionSearched?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Абонемент не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
