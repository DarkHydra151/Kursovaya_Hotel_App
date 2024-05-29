namespace HotelApp
{
    partial class RoomForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewRooms;
        private System.Windows.Forms.TextBox textBoxRoomNumber;
        private System.Windows.Forms.TextBox textBoxRoomType;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.TextBox textBoxNumberOfResidents;
        private System.Windows.Forms.Button buttonAddRoom;
        private System.Windows.Forms.Button buttonEditRoom;
        private System.Windows.Forms.Button buttonDeleteRoom;
        private System.Windows.Forms.Label labelRoomNumber;
        private System.Windows.Forms.Label labelRoomType;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelNumberOfResidents;

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
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.textBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.textBoxRoomType = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfResidents = new System.Windows.Forms.TextBox();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.buttonEditRoom = new System.Windows.Forms.Button();
            this.buttonDeleteRoom = new System.Windows.Forms.Button();
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.labelRoomType = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelNumberOfResidents = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.Size = new System.Drawing.Size(776, 290);
            this.dataGridViewRooms.TabIndex = 0;
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxRoomNumber.Location = new System.Drawing.Point(12, 334);
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxRoomNumber.TabIndex = 1;
            // 
            // textBoxRoomType
            // 
            this.textBoxRoomType.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxRoomType.Location = new System.Drawing.Point(118, 334);
            this.textBoxRoomType.Name = "textBoxRoomType";
            this.textBoxRoomType.Size = new System.Drawing.Size(100, 20);
            this.textBoxRoomType.TabIndex = 2;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxTime.Location = new System.Drawing.Point(224, 334);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxTime.TabIndex = 3;
            // 
            // textBoxNumberOfResidents
            // 
            this.textBoxNumberOfResidents.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxNumberOfResidents.Location = new System.Drawing.Point(330, 334);
            this.textBoxNumberOfResidents.Name = "textBoxNumberOfResidents";
            this.textBoxNumberOfResidents.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberOfResidents.TabIndex = 4;
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAddRoom.Location = new System.Drawing.Point(436, 332);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(75, 23);
            this.buttonAddRoom.TabIndex = 5;
            this.buttonAddRoom.Text = "Add Room";
            this.buttonAddRoom.UseVisualStyleBackColor = true;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
            // 
            // buttonEditRoom
            // 
            this.buttonEditRoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonEditRoom.Location = new System.Drawing.Point(517, 332);
            this.buttonEditRoom.Name = "buttonEditRoom";
            this.buttonEditRoom.Size = new System.Drawing.Size(75, 23);
            this.buttonEditRoom.TabIndex = 6;
            this.buttonEditRoom.Text = "Edit Room";
            this.buttonEditRoom.UseVisualStyleBackColor = true;
            this.buttonEditRoom.Click += new System.EventHandler(this.buttonEditRoom_Click);
            // 
            // buttonDeleteRoom
            // 
            this.buttonDeleteRoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDeleteRoom.Location = new System.Drawing.Point(598, 332);
            this.buttonDeleteRoom.Name = "buttonDeleteRoom";
            this.buttonDeleteRoom.Size = new System.Drawing.Size(100, 23);
            this.buttonDeleteRoom.TabIndex = 7;
            this.buttonDeleteRoom.Text = "Delete Room";
            this.buttonDeleteRoom.UseVisualStyleBackColor = true;
            this.buttonDeleteRoom.Click += new System.EventHandler(this.buttonDeleteRoom_Click);
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Location = new System.Drawing.Point(12, 318);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(78, 13);
            this.labelRoomNumber.TabIndex = 8;
            this.labelRoomNumber.Text = "Room Number:";
            // 
            // labelRoomType
            // 
            this.labelRoomType.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelRoomType.AutoSize = true;
            this.labelRoomType.Location = new System.Drawing.Point(115, 318);
            this.labelRoomType.Name = "labelRoomType";
            this.labelRoomType.Size = new System.Drawing.Size(68, 13);
            this.labelRoomType.TabIndex = 9;
            this.labelRoomType.Text = "Room Type:";
            // 
            // labelTime
            // 
            this.labelTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(221, 318);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(33, 13);
            this.labelTime.TabIndex = 10;
            this.labelTime.Text = "Time:";
            // 
            // labelNumberOfResidents
            // 
            this.labelNumberOfResidents.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelNumberOfResidents.AutoSize = true;
            this.labelNumberOfResidents.Location = new System.Drawing.Point(327, 318);
            this.labelNumberOfResidents.Name = "labelNumberOfResidents";
            this.labelNumberOfResidents.Size = new System.Drawing.Size(108, 13);
            this.labelNumberOfResidents.TabIndex = 11;
            this.labelNumberOfResidents.Text = "Number of Residents:";
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNumberOfResidents);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelRoomType);
            this.Controls.Add(this.labelRoomNumber);
            this.Controls.Add(this.buttonDeleteRoom);
            this.Controls.Add(this.buttonEditRoom);
            this.Controls.Add(this.buttonAddRoom);
            this.Controls.Add(this.textBoxNumberOfResidents);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.textBoxRoomType);
            this.Controls.Add(this.textBoxRoomNumber);
            this.Controls.Add(this.dataGridViewRooms);
            this.Name = "RoomForm";
            this.Text = "Room Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
