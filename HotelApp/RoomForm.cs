using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelApp
{
    public partial class RoomForm : Form
    {
        private string connectionString;
        private MainForm mainForm;

        public RoomForm(MainForm form, string connString)
        {
            InitializeComponent();
            mainForm = form;
            connectionString = connString;
            LoadRooms();
            mainForm.DataUpdated += OnDataUpdated; // Subscribe to the event
        }

        public void LoadRooms()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM room", connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewRooms.DataSource = dataTable;
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

        private void AddRoom(int roomNumber, string roomType, string time, int numberOfResidents)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("INSERT INTO room (room_number, room_type, time, number_of_residents) VALUES (@RoomNumber, @RoomType, @Time, @NumberOfResidents)", connection);
                    command.Parameters.AddWithValue("@RoomNumber", roomNumber);
                    command.Parameters.AddWithValue("@RoomType", roomType);
                    command.Parameters.AddWithValue("@Time", time);
                    command.Parameters.AddWithValue("@NumberOfResidents", numberOfResidents);
                    command.ExecuteNonQuery();
                }
                LoadRooms(); // Refresh data after adding
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

        private void EditRoom(int roomId, int roomNumber, string roomType, string time, int numberOfResidents)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("UPDATE room SET room_number=@RoomNumber, room_type=@RoomType, time=@Time, number_of_residents=@NumberOfResidents WHERE id=@RoomId", connection);
                    command.Parameters.AddWithValue("@RoomId", roomId);
                    command.Parameters.AddWithValue("@RoomNumber", roomNumber);
                    command.Parameters.AddWithValue("@RoomType", roomType);
                    command.Parameters.AddWithValue("@Time", time);
                    command.Parameters.AddWithValue("@NumberOfResidents", numberOfResidents);
                    command.ExecuteNonQuery();
                }
                LoadRooms(); // Refresh data after editing
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

        private void DeleteRoom(int roomId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("DELETE FROM room WHERE id=@RoomId", connection);
                    command.Parameters.AddWithValue("@RoomId", roomId);
                    command.ExecuteNonQuery();
                }
                LoadRooms(); // Refresh data after deleting
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

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            try
            {
                int roomNumber = int.Parse(textBoxRoomNumber.Text);
                string roomType = textBoxRoomType.Text;
                string time = textBoxTime.Text;
                int numberOfResidents = int.Parse(textBoxNumberOfResidents.Text);

                if (string.IsNullOrEmpty(roomType) || string.IsNullOrEmpty(time))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                AddRoom(roomNumber, roomType, time, numberOfResidents);
            }
            catch (FormatException)
            {
                MessageBox.Show("Room Number and Number of Residents must be valid numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEditRoom_Click(object sender, EventArgs e)
        {
            if (dataGridViewRooms.SelectedRows.Count > 0)
            {
                int roomId = Convert.ToInt32(dataGridViewRooms.SelectedRows[0].Cells["id"].Value);

                if (!int.TryParse(textBoxRoomNumber.Text, out int roomNumber))
                {
                    MessageBox.Show("Room Number must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(textBoxNumberOfResidents.Text, out int numberOfResidents))
                {
                    MessageBox.Show("Number of Residents must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string roomType = textBoxRoomType.Text;
                string time = textBoxTime.Text;

                if (string.IsNullOrEmpty(roomType) || string.IsNullOrEmpty(time))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                EditRoom(roomId, roomNumber, roomType, time, numberOfResidents);
            }
            else
            {
                MessageBox.Show("Please select a room to edit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDeleteRoom_Click(object sender, EventArgs e)
        {
            if (dataGridViewRooms.SelectedRows.Count > 0)
            {
                int roomId = Convert.ToInt32(dataGridViewRooms.SelectedRows[0].Cells["id"].Value);

                var confirmResult = MessageBox.Show("Are you sure to delete this room?",
                                                     "Confirm Delete",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    DeleteRoom(roomId);
                }
            }
            else
            {
                MessageBox.Show("Please select a room to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void OnDataUpdated(object sender, EventArgs e)
        {
            LoadRooms();
        }
    }
}
