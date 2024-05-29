using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OfficeOpenXml;
using System.IO;

namespace HotelApp
{
    public partial class MainForm : Form
    {
        private string connectionString = "server=localhost;port=3306;database=hotelbd;user=root;password=15022005";
        private RoomForm roomForm;
        private ClientForm clientForm;

        public event EventHandler DataUpdated; // Create the event

        public MainForm()
        {
            InitializeComponent();
            LoadData();
            roomForm = new RoomForm(this, connectionString);
            clientForm = new ClientForm(this, connectionString);
        }

        private void LoadData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM booking", connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
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

        private void RefreshAllData()
        {
            LoadData();
            roomForm.LoadRooms();
            clientForm.LoadClients();
            DataUpdated?.Invoke(this, EventArgs.Empty); // Raise the event
        }

        private void AddBooking(int roomId, string status, string username, int clientId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("INSERT INTO booking (room_id, status, username, client_id) VALUES (@RoomId, @Status, @Username, @ClientId)", connection);
                    command.Parameters.AddWithValue("@RoomId", roomId);
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@ClientId", clientId);
                    command.ExecuteNonQuery();
                }
                RefreshAllData(); // Add this line to refresh all forms
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

        private void EditBooking(int bookingId, int roomId, string status, string username, int clientId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("UPDATE booking SET room_id=@RoomId, status=@Status, username=@Username, client_id=@ClientId WHERE id=@BookingId", connection);
                    command.Parameters.AddWithValue("@BookingId", bookingId);
                    command.Parameters.AddWithValue("@RoomId", roomId);
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@ClientId", clientId);
                    command.ExecuteNonQuery();
                }
                RefreshAllData(); // Add this line to refresh all forms
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

        private void DeleteBooking(int bookingId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("DELETE FROM booking WHERE id=@BookingId", connection);
                    command.Parameters.AddWithValue("@BookingId", bookingId);
                    command.ExecuteNonQuery();
                }
                RefreshAllData(); // Add this line to refresh all forms
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

        private void SearchBookings(string keyword)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter($"SELECT * FROM booking WHERE status LIKE '%{keyword}%' OR username LIKE '%{keyword}%'", connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
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

        private void ExportToExcel(DataTable dataTable, string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("BookingData");
                worksheet.Cells["A1"].LoadFromDataTable(dataTable, true);
                package.SaveAs(new FileInfo(filePath));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int roomId = int.Parse(textBoxRoomId.Text);
                string status = textBoxStatus.Text;
                string username = textBoxUsername.Text;
                int clientId = int.Parse(textBoxClientId.Text);

                if (string.IsNullOrEmpty(status) || string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                AddBooking(roomId, status, username, clientId);
                RefreshAllData(); // Add this line to refresh all forms
            }
            catch (FormatException)
            {
                MessageBox.Show("Room ID and Client ID must be valid numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int bookingId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                if (!int.TryParse(textBoxRoomId.Text, out int roomId))
                {
                    MessageBox.Show("Room ID must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(textBoxClientId.Text, out int clientId))
                {
                    MessageBox.Show("Client ID must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string status = textBoxStatus.Text;
                string username = textBoxUsername.Text;

                if (string.IsNullOrEmpty(status) || string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                EditBooking(bookingId, roomId, status, username, clientId);
                RefreshAllData(); // Add this line to refresh all forms
            }
            else
            {
                MessageBox.Show("Please select a booking to edit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int bookingId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                var confirmResult = MessageBox.Show("Are you sure to delete this booking?",
                                                     "Confirm Delete",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    DeleteBooking(bookingId);
                    RefreshAllData(); // Add this line to refresh all forms
                }
            }
            else
            {
                MessageBox.Show("Please select a booking to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string keyword = textBoxSearch.Text;
            SearchBookings(keyword);
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)dataGridView1.DataSource;

            if (dataTable == null || dataTable.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save an Excel File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToExcel(dataTable, saveFileDialog.FileName);
                    MessageBox.Show("Data exported successfully.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonManageRooms_Click(object sender, EventArgs e)
        {
            if (roomForm == null || roomForm.IsDisposed)
            {
                roomForm = new RoomForm(this, connectionString);
            }
            roomForm.Show();
            roomForm.LoadRooms();
        }

        private void buttonManageClients_Click(object sender, EventArgs e)
        {
            if (clientForm == null || clientForm.IsDisposed)
            {
                clientForm = new ClientForm(this, connectionString);
            }
            clientForm.Show();
            clientForm.LoadClients();
        }

        private void OnDataUpdated(object sender, EventArgs e)
        {
            roomForm.LoadRooms();
            clientForm.LoadClients();
        }
    }
}
