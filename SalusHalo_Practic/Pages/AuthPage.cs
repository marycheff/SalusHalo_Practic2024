using System;
using System.Windows.Forms;

namespace SalusHalo_Practic
{
    public partial class AuthPage : UserControl
    {
        public event EventHandler SubscriptionAdded;
        public AuthPage()
        {
            InitializeComponent();

        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            string login = textLogin.Text.Trim();
            string password = textPassword.Text.Trim();

            if (login == string.Empty || password == string.Empty)
            {
                MessageBox.Show("Введите логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DB.LoginExists(login))
                {
                    if (DB.LoginMatchesWithPassword(login, password))
                    {
                        MainForm.currentSubscription.VisitorId = DB.GetVisitorIdByLogin(login);
                        int activeSubscriptionId = DB.ActiveSubscriptionId(MainForm.currentSubscription.VisitorId);
                        if (activeSubscriptionId != -1)
                        {
                            DB.UnactiveSubscriptionStatus(activeSubscriptionId);
                        }

                        int numberOfDays = DB.GetNumberOfDaysByTariffId(MainForm.currentSubscription.TariffId);
                        DateTime startDate = DateTime.Now;
                        DateTime endDate = startDate.AddDays(numberOfDays);

                        int addedSubscriptionID = DB.AddSubscription(startDate, endDate, "действует", MainForm.currentSubscription.VisitorId, MainForm.currentSubscription.PriceId);
                        if (addedSubscriptionID != -1)
                        {
                            MessageBox.Show($"Абонемент оформлен\nНомер абонемента: {addedSubscriptionID}");
                            SubscriptionAdded?.Invoke(this, EventArgs.Empty);
                        }


                    }
                    else
                    {
                        MessageBox.Show("Введен неверный пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textPassword.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("Такого логина не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textLogin.Text = string.Empty;
                    textPassword.Text = string.Empty;
                }
            }



        }
    }
}
