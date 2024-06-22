using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SalusHalo_Practic
{
    internal class DB
    {
        private static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;Username=root;password=;database=salus_halo;";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySqlConnection" + ex.Message, "Error", MessageBoxButtons.OK);
            }
            return conn;
        }
        public static int GetPriceByTariffAndCategory(int tariffId, int categoryId)
        {
            int price = 0;

            MySqlConnection conn = GetConnection();
            try
            {
                string query = "SELECT price FROM prices WHERE tariff_id = @tariffId AND category_id = @categoryId";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@tariffId", tariffId);
                command.Parameters.AddWithValue("@categoryId", categoryId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        price = reader.GetInt32("price");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return price;
        }
        public static int GetPriceId(int tariffId, int categoryId)
        {
            int priceId = 0;

            MySqlConnection conn = GetConnection();
            try
            {
                string query = "SELECT id FROM prices WHERE tariff_id = @tariffId AND category_id = @categoryId";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@tariffId", tariffId);
                command.Parameters.AddWithValue("@categoryId", categoryId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        priceId = reader.GetInt32("id");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return priceId;
        }
        public static int GetNumberOfDaysByTariffId(int tariffId)
        {
            int numberOfDays = 0;

            MySqlConnection conn = GetConnection();
            try
            {
                string query = "SELECT number_of_days FROM tariffs WHERE id = @tariffId";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@tariffId", tariffId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        numberOfDays = reader.GetInt32("number_of_days");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return numberOfDays;
        }
        public static int GetVisitorIdByLogin(string login)
        {
            int visitorId = 0;

            MySqlConnection conn = GetConnection();
            try
            {
                string query = "SELECT id FROM visitors WHERE login = @login";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@login", login);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        visitorId = reader.GetInt32("id");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return visitorId;
        }
        public static HistorySubscriptions GetSubscriptionHistory(int subscriptionId)
        {
            HistorySubscriptions history = null;
            MySqlConnection conn = GetConnection();
            try
            {
                string query = @"
                SELECT s.id, s.visitor_id, s.end_date, s.status, 
                       t.number_of_days AS num_of_sessions,
                       (SELECT COUNT(*) FROM visits v WHERE v.subscription_id = s.id) AS num_of_visits
                FROM subscriptions s
                JOIN prices p ON s.price_id = p.id
                JOIN tariffs t ON p.tariff_id = t.id
                WHERE s.id = @subscriptionId";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@subscriptionId", subscriptionId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int numOfSessions = reader.GetInt32("num_of_sessions");
                        int numOfVisits = reader.GetInt32("num_of_visits");

                        history = new HistorySubscriptions
                        {
                            Id = reader.GetInt32("id"),
                            VisitorId = reader.GetInt32("visitor_id"),
                            EndTime = reader.GetDateTime("end_date"),
                            Status = reader.GetString("status"),
                            NumOfSessions = numOfSessions,
                            NumOfVisits = numOfVisits,
                            RemainingVisits = numOfSessions - numOfVisits
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return history;
        }
        public static string GetVisitorName(int visitorId)
        {
            string visitorName = "";
            MySqlConnection conn = GetConnection();
            try
            {
                string query = "SELECT last_name, first_name, middle_name FROM visitors WHERE id = @visitorId";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@visitorId", visitorId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string lastName = reader.GetString("last_name");
                        string firstName = reader.GetString("first_name");
                        string middleName = reader.GetString("middle_name");

                        visitorName = $"{lastName} {firstName} {middleName}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return visitorName;
        }
        public static List<KeyValuePair<DateTime, TimeSpan>> GetAllVisits(int subscriptionId)
        {
            List<KeyValuePair<DateTime, TimeSpan>> visits = new List<KeyValuePair<DateTime, TimeSpan>>();
            MySqlConnection conn = GetConnection();
            try
            {
                string query = @"
            SELECT v.visit_date, s.starting_time 
            FROM visits v
            JOIN sessions s ON v.session_id = s.id
            WHERE v.subscription_id = @subscriptionId";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@subscriptionId", subscriptionId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime visitDate = reader.GetDateTime("visit_date");
                        TimeSpan startingTime = reader.GetTimeSpan("starting_time");

                        visits.Add(new KeyValuePair<DateTime, TimeSpan>(visitDate, startingTime));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return visits;
        }



        public static bool LoginExists(string login)
        {
            bool exists = false;

            MySqlConnection conn = GetConnection();
            try
            {
                string query = "SELECT COUNT(*) FROM visitors WHERE login = @login";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@login", login);

                int count = Convert.ToInt32(command.ExecuteScalar());
                exists = (count > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return exists;
        }
        public static bool LoginMatchesWithPassword(string login, string password)
        {
            bool matches = false;

            MySqlConnection conn = GetConnection();
            try
            {
                string query = "SELECT COUNT(*) FROM visitors WHERE login = @login AND password = @password";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(command.ExecuteScalar());
                matches = (count > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return matches;
        } 
        public static int ActiveSubscriptionId(int userId)
        {
            int subscriptionId = -1;

            MySqlConnection conn = GetConnection();
            try
            {
                string query = "SELECT id FROM subscriptions WHERE visitor_id = @userId AND status = 'действует'";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@userId", userId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        subscriptionId = reader.GetInt32("id");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return subscriptionId;
        }
        public static void UnactiveSubscriptionStatus(int subscriptionId)
        {
            MySqlConnection conn = GetConnection();
            try
            {
                string query = "UPDATE subscriptions SET status = 'не действует' WHERE id = @subscriptionId";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@subscriptionId", subscriptionId);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        public static int AddSubscription(DateTime startDate, DateTime endDate, string status, int visitorId, int priceId)
        {
            MySqlConnection conn = GetConnection();
            try
            {
                string query = "INSERT INTO subscriptions (start_date, end_date, status, visitor_id, price_id) " +
                               "VALUES (@startDate, @endDate, @status, @visitorId, @priceId)";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@startDate", startDate);
                command.Parameters.AddWithValue("@endDate", endDate);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@visitorId", visitorId);
                command.Parameters.AddWithValue("@priceId", priceId);

                command.ExecuteNonQuery();


                int insertedId = (int)command.LastInsertedId;
                return insertedId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool SubscriptionExists(int subscriptionId)
        {
            bool exists = false;

            MySqlConnection conn = GetConnection();
            try
            {
                string query = "SELECT COUNT(*) FROM subscriptions WHERE id = @subscriptionId";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@subscriptionId", subscriptionId);

                int count = Convert.ToInt32(command.ExecuteScalar());
                exists = count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return exists;
        }
       

    }
}
