namespace HotelApp
{
    partial class ClientForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.Button buttonEditClient;
        private System.Windows.Forms.Button buttonDeleteClient;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;

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
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.buttonEditClient = new System.Windows.Forms.Button();
            this.buttonDeleteClient = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(776, 290);
            this.dataGridViewClients.TabIndex = 0;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxUsername.Location = new System.Drawing.Point(12, 334);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsername.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxPassword.Location = new System.Drawing.Point(118, 334);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 2;
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAddClient.Location = new System.Drawing.Point(224, 332);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(75, 23);
            this.buttonAddClient.TabIndex = 3;
            this.buttonAddClient.Text = "Add Client";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // buttonEditClient
            // 
            this.buttonEditClient.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonEditClient.Location = new System.Drawing.Point(305, 332);
            this.buttonEditClient.Name = "buttonEditClient";
            this.buttonEditClient.Size = new System.Drawing.Size(75, 23);
            this.buttonEditClient.TabIndex = 4;
            this.buttonEditClient.Text = "Edit Client";
            this.buttonEditClient.UseVisualStyleBackColor = true;
            this.buttonEditClient.Click += new System.EventHandler(this.buttonEditClient_Click);
            // 
            // buttonDeleteClient
            // 
            this.buttonDeleteClient.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDeleteClient.Location = new System.Drawing.Point(386, 332);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteClient.TabIndex = 5;
            this.buttonDeleteClient.Text = "Delete Client";
            this.buttonDeleteClient.UseVisualStyleBackColor = true;
            this.buttonDeleteClient.Click += new System.EventHandler(this.buttonDeleteClient_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(12, 318);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 6;
            this.labelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(115, 318);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Password:";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.buttonDeleteClient);
            this.Controls.Add(this.buttonEditClient);
            this.Controls.Add(this.buttonAddClient);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.dataGridViewClients);
            this.Name = "ClientForm";
            this.Text = "Client Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
