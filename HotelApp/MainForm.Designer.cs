namespace HotelApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxRoomId;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxClientId; // Новое поле ClientID
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonManageRooms;
        private System.Windows.Forms.Button buttonManageClients;
        private System.Windows.Forms.Label labelRoomId;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelClientId; // Новая метка ClientID
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button buttonExport;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxRoomId = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxClientId = new System.Windows.Forms.TextBox(); // Инициализация нового поля
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonManageRooms = new System.Windows.Forms.Button();
            this.buttonManageClients = new System.Windows.Forms.Button();
            this.labelRoomId = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelClientId = new System.Windows.Forms.Label(); // Инициализация новой метки
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.buttonExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxRoomId
            // 
            this.textBoxRoomId.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxRoomId.Location = new System.Drawing.Point(12, 334);
            this.textBoxRoomId.Name = "textBoxRoomId";
            this.textBoxRoomId.Size = new System.Drawing.Size(100, 20);
            this.textBoxRoomId.TabIndex = 1;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxStatus.Location = new System.Drawing.Point(118, 334);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(100, 20);
            this.textBoxStatus.TabIndex = 2;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxUsername.Location = new System.Drawing.Point(224, 334);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsername.TabIndex = 3;
            // 
            // textBoxClientId
            // 
            this.textBoxClientId.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxClientId.Location = new System.Drawing.Point(330, 334);
            this.textBoxClientId.Name = "textBoxClientId";
            this.textBoxClientId.Size = new System.Drawing.Size(100, 20);
            this.textBoxClientId.TabIndex = 16; // Новый индекс
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAdd.Location = new System.Drawing.Point(436, 332);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add Booking";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonEdit.Location = new System.Drawing.Point(517, 332);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 8;
            this.buttonEdit.Text = "Edit Booking";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDelete.Location = new System.Drawing.Point(598, 332);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 23);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete Booking";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonManageRooms
            // 
            this.buttonManageRooms.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonManageRooms.Location = new System.Drawing.Point(330, 370);
            this.buttonManageRooms.Name = "buttonManageRooms";
            this.buttonManageRooms.Size = new System.Drawing.Size(150, 23);
            this.buttonManageRooms.TabIndex = 13;
            this.buttonManageRooms.Text = "Manage Rooms";
            this.buttonManageRooms.UseVisualStyleBackColor = true;
            this.buttonManageRooms.Click += new System.EventHandler(this.buttonManageRooms_Click);
            // 
            // buttonManageClients
            // 
            this.buttonManageClients.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonManageClients.Location = new System.Drawing.Point(486, 370); // Положение кнопки
            this.buttonManageClients.Name = "buttonManageClients";
            this.buttonManageClients.Size = new System.Drawing.Size(150, 23);
            this.buttonManageClients.TabIndex = 14;
            this.buttonManageClients.Text = "Manage Clients";
            this.buttonManageClients.UseVisualStyleBackColor = true;
            this.buttonManageClients.Click += new System.EventHandler(this.buttonManageClients_Click);
            // 
            // labelRoomId
            // 
            this.labelRoomId.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelRoomId.AutoSize = true;
            this.labelRoomId.Location = new System.Drawing.Point(12, 318);
            this.labelRoomId.Name = "labelRoomId";
            this.labelRoomId.Size = new System.Drawing.Size(50, 13);
            this.labelRoomId.TabIndex = 5;
            this.labelRoomId.Text = "Room ID:";
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(115, 318);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(40, 13);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "Status:";
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(221, 318);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 7;
            this.labelUsername.Text = "Username:";
            // 
            // labelClientId
            // 
            this.labelClientId.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelClientId.AutoSize = true;
            this.labelClientId.Location = new System.Drawing.Point(327, 318);
            this.labelClientId.Name = "labelClientId";
            this.labelClientId.Size = new System.Drawing.Size(50, 13);
            this.labelClientId.TabIndex = 17; // Новый индекс
            this.labelClientId.Text = "Client ID:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxSearch.Location = new System.Drawing.Point(59, 363);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(159, 20);
            this.textBoxSearch.TabIndex = 11;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSearch.Location = new System.Drawing.Point(224, 361);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 12;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(12, 366);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(41, 13);
            this.labelSearch.TabIndex = 10;
            this.labelSearch.Text = "Search:";
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonExport.Location = new System.Drawing.Point(704, 332);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(100, 23);
            this.buttonExport.TabIndex = 15;
            this.buttonExport.Text = "Export to Excel";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonManageClients);
            this.Controls.Add(this.buttonManageRooms);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelClientId); // Добавление новой метки
            this.Controls.Add(this.textBoxClientId); // Добавление нового поля
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelRoomId);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.textBoxRoomId);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Hotel Booking Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
