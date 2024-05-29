using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace HotelApp
{
    public partial class ClientForm : Form
    {
        private string connectionString;
        private MainForm mainForm;

        public ClientForm(MainForm form, string connString)
        {
            InitializeComponent();
            mainForm = form;
            connectionString = connString;
            LoadClients();
            mainForm.DataUpdated += OnDataUpdated; // Subscribe to the event
        }

        public void LoadClients()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM client", connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewClients.DataSource = dataTable;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddClient(string username, string password)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
                    MySqlCommand command = new MySqlCommand("INSERT INTO client (username, password) VALUES (@Username, @Password)", connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", hashedPassword);
                    command.ExecuteNonQuery();
                }
                LoadClients(); // Refresh data after adding
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditClient(int clientId, string username, string password)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
                    MySqlCommand command = new MySqlCommand("UPDATE client SET username=@Username, password=@Password WHERE id=@ClientId", connection);
                    command.Parameters.AddWithValue("@ClientId", clientId);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", hashedPassword);
                    command.ExecuteNonQuery();
                }
                LoadClients(); // Refresh data after editing
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteClient(int clientId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("DELETE FROM client WHERE id=@ClientId", connection);
                    command.Parameters.AddWithValue("@ClientId", clientId);
                    command.ExecuteNonQuery();
                }
                LoadClients(); // Refresh data after deleting
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AddClient(username, password);
        }

        private void buttonEditClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                int clientId = Convert.ToInt32(dataGridViewClients.SelectedRows[0].Cells["id"].Value);
                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                EditClient(clientId, username, password);
            }
            else
            {
                MessageBox.Show("Please select a client to edit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                int clientId = Convert.ToInt32(dataGridViewClients.SelectedRows[0].Cells["id"].Value);

                var confirmResult = MessageBox.Show("Are you sure to delete this client?",
                                                     "Confirm Delete",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    DeleteClient(clientId);
                }
            }
            else
            {
                MessageBox.Show("Please select a client to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void OnDataUpdated(object sender, EventArgs e)
        {
            LoadClients();
        }
    }
}
