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
    public partial class StartPage : UserControl
    {
        public event EventHandler ChildrenPanelClicked;
        public event EventHandler AdultsPanelClicked;
        public event EventHandler AdultsChildrenPanelClicked;
        public event EventHandler PreferentialPanelClicked;
        public StartPage()
        {
            InitializeComponent();

        }

        private void childrenPanel_Click(object sender, EventArgs e)
        {
            ChildrenPanelClicked?.Invoke(this, EventArgs.Empty);
        }

        private void adultsPanel_Click(object sender, EventArgs e)
        {
            AdultsPanelClicked?.Invoke(this, EventArgs.Empty);
        }
        private void adultsChildrenPanel_Click(object sender, EventArgs e)
        {
            AdultsChildrenPanelClicked?.Invoke(this, EventArgs.Empty);
        }
        private void preferentialPanel_Click(object sender, EventArgs e)
        {
            PreferentialPanelClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
