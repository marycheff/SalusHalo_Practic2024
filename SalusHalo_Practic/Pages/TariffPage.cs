using System;
using System.Windows.Forms;

namespace SalusHalo_Practic
{
    public partial class TariffPage : UserControl
    {
        public event EventHandler ArrangeClicked;

        private readonly int priceSingle;
        private readonly int priceTen;
        private readonly int priceFifteen;
        private readonly int priceTwenty;
        private readonly int priceUnlimited;

        private readonly int tariffSingle = 1;
        private readonly int tariffTen = 2;
        private readonly int tariffFifteen = 3;
        private readonly int tariffTwenty = 4;
        private readonly int tariffUnlimited = 5;

        private readonly int categoryId;
        public TariffPage(int categoryId)
        {
            InitializeComponent();
            this.categoryId = categoryId;

            priceSingle = DB.GetPriceByTariffAndCategory(tariffSingle, categoryId);
            priceTen = DB.GetPriceByTariffAndCategory(tariffTen, categoryId);
            priceFifteen = DB.GetPriceByTariffAndCategory(tariffFifteen, categoryId);
            priceTwenty = DB.GetPriceByTariffAndCategory(tariffTwenty, categoryId);
            priceUnlimited = DB.GetPriceByTariffAndCategory(tariffUnlimited, categoryId);

            labelSingle.Text = priceSingle.ToString();
            labelTen.Text = priceTen.ToString();
            labelFifteen.Text = priceFifteen.ToString();
            labelTwenty.Text = priceTwenty.ToString();
            labelUnlimited.Text = priceUnlimited.ToString();

        }

        private void btnSingle_Click(object sender, EventArgs e)
        {
            MainForm.currentSubscription.PriceId = DB.GetPriceId(tariffSingle, categoryId);
            MainForm.currentSubscription.TariffId = tariffSingle;
            ArrangeClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnTen_Click(object sender, EventArgs e)
        {

            MainForm.currentSubscription.PriceId = DB.GetPriceId(tariffTen, categoryId);
            MainForm.currentSubscription.TariffId = tariffTen;
            ArrangeClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnFifteen_Click(object sender, EventArgs e)
        {

            MainForm.currentSubscription.PriceId = DB.GetPriceId(tariffFifteen, categoryId);
            MainForm.currentSubscription.TariffId = tariffFifteen;
            ArrangeClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnTwenty_Click(object sender, EventArgs e)
        {
            MainForm.currentSubscription.PriceId = DB.GetPriceId(tariffTwenty, categoryId);
            MainForm.currentSubscription.TariffId = tariffTwenty;
            ArrangeClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnUnlimited_Click(object sender, EventArgs e)
        {
            MainForm.currentSubscription.PriceId = DB.GetPriceId(tariffUnlimited, categoryId);
            MainForm.currentSubscription.TariffId = tariffUnlimited;
            ArrangeClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
