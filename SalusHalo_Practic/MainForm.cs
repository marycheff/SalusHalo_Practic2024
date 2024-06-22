using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;




namespace SalusHalo_Practic
{
    public partial class MainForm : Form
    {
        internal static Subscription currentSubscription = new Subscription();
        internal static HistorySubscriptions searchedSubscription = new HistorySubscriptions();
        public MainForm()
        {
            InitializeComponent();
            ShowStartPage();
        }

        private void btnStartPage_Click(object sender, EventArgs e)
        {
            ShowStartPage();
        }
        private void btnCheckSubscribtion_Click(object sender, EventArgs e)
        {
            ShowSearchSubscriptionPage();
        }

        //ОТОБРАЖЕНИИЕ СТРАНИЦ
        private void ShowStartPage()
        {
            btnCheckSubscribtion.Visible = true;
            btnStartPage.Visible = false;
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                Control currentControl = flowLayoutPanel1.Controls[0];
                flowLayoutPanel1.Controls.Remove(currentControl);
                flowLayoutPanel1.Controls.Clear();
                currentControl.Dispose();
            }
            StartPage startPage = new StartPage();
            flowLayoutPanel1.Controls.Add(startPage);
            startPage.Focus();
            startPage.ChildrenPanelClicked += StartPage_ChildrenPanelClicked;
            startPage.AdultsPanelClicked += StartPage_AdultsPanelClicked;
            startPage.AdultsChildrenPanelClicked += StartPage_AdultsChildrenPanelClicked;
            startPage.PreferentialPanelClicked += StartPage_PreferentialPanelClicked;
            
            
        }
        private void OpenTariffPage(int categoryId)
        {
            btnCheckSubscribtion.Visible = false;
            btnStartPage.Visible = true;
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                Control currentControl = flowLayoutPanel1.Controls[0];
                flowLayoutPanel1.Controls.Remove(currentControl);
                currentControl.Dispose();
            }
            TariffPage tariffPage = new TariffPage(categoryId);
            flowLayoutPanel1.Controls.Add(tariffPage);
            tariffPage.Focus();
            tariffPage.ArrangeClicked += TariffPage_ArrangeClicked;
        }
        private void ShowCheckSubscriptionPage()
        {
            btnCheckSubscribtion.Visible = false;
            btnStartPage.Visible = true;
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                Control currentControl = flowLayoutPanel1.Controls[0];
                flowLayoutPanel1.Controls.Remove(currentControl);
                flowLayoutPanel1.Controls.Clear();
                currentControl.Dispose();
            }
            CheckSubscription checkSubscription = new CheckSubscription(searchedSubscription.Id);
            flowLayoutPanel1.Controls.Add(checkSubscription);
            checkSubscription.Focus();
           
        }
        private void ShowSearchSubscriptionPage()
        {
            btnCheckSubscribtion.Visible = false;
            btnStartPage.Visible = true;
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                Control currentControl = flowLayoutPanel1.Controls[0];
                flowLayoutPanel1.Controls.Remove(currentControl);
                flowLayoutPanel1.Controls.Clear();
                currentControl.Dispose();
            }
            SearchSubscription searchSubscriptionPage = new SearchSubscription();
            flowLayoutPanel1.Controls.Add(searchSubscriptionPage);
            searchSubscriptionPage.Focus();
            searchSubscriptionPage.SubscriptionSearched += SearchSubscriptionPage_SubscriptionSearched;
        }
        private void SearchSubscriptionPage_SubscriptionSearched(object sender, EventArgs e)
        {
           ShowCheckSubscriptionPage();
        }
        private void ShowAuthPage()
        {
            btnCheckSubscribtion.Visible = false;
            btnStartPage.Visible = true;
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                Control currentControl = flowLayoutPanel1.Controls[0];
                flowLayoutPanel1.Controls.Remove(currentControl);
                flowLayoutPanel1.Controls.Clear();
                currentControl.Dispose();
            }
            AuthPage authPage = new AuthPage();
            flowLayoutPanel1.Controls.Add(authPage);
            authPage.Focus();
            authPage.SubscriptionAdded += AuthPage_SubscriptionAdded;
        }


        //ОБРАБОТЧИКИ СОБЫТИЙ
        private void StartPage_ChildrenPanelClicked(object sender, EventArgs e)
        {
            OpenTariffPage(1);
        }
        private void StartPage_AdultsPanelClicked(object sender, EventArgs e)
        {
            OpenTariffPage(2);
        }
        private void StartPage_PreferentialPanelClicked(object sender, EventArgs e)
        {
            OpenTariffPage(3);
        }
        private void StartPage_AdultsChildrenPanelClicked(object sender, EventArgs e)
        {
            OpenTariffPage(4);
        }
        private void TariffPage_ArrangeClicked(object sender, EventArgs e)
        {
            ShowAuthPage();
        }
        private void AuthPage_SubscriptionAdded(object sender, EventArgs e)
        {
            ShowStartPage();
        }


        //КНОПКА СВОРАЧИВАНИЯ 
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //КНОПКА ЗАКРЫТИЯ 
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //ПЕРЕТАСКИВАНИЕ
        protected override void OnPaint(PaintEventArgs e)
        {
            int borderWidth = 2;
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                                    Color.FromArgb(16, 123, 196), borderWidth, ButtonBorderStyle.Solid,
                                    Color.FromArgb(16, 123, 196), borderWidth, ButtonBorderStyle.Solid,
                                    Color.FromArgb(16, 123, 196), borderWidth, ButtonBorderStyle.Solid,
                                    Color.FromArgb(16, 123, 196), borderWidth, ButtonBorderStyle.Solid);
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}
