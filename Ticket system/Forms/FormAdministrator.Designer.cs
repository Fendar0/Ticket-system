namespace Ticket_system
{
    partial class Administrator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btUsersInf = new System.Windows.Forms.Button();
            this.btOrganizationInf = new System.Windows.Forms.Button();
            this.btEventsInf = new System.Windows.Forms.Button();
            this.btTicketInf = new System.Windows.Forms.Button();
            this.btLogs = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btUsersInf
            // 
            this.btUsersInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btUsersInf.Location = new System.Drawing.Point(12, 12);
            this.btUsersInf.Name = "btUsersInf";
            this.btUsersInf.Size = new System.Drawing.Size(223, 61);
            this.btUsersInf.TabIndex = 0;
            this.btUsersInf.Text = "Информация\r\nо пользователях";
            this.btUsersInf.UseVisualStyleBackColor = true;
            this.btUsersInf.Click += new System.EventHandler(this.btUsersInf_Click);
            // 
            // btOrganizationInf
            // 
            this.btOrganizationInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btOrganizationInf.Location = new System.Drawing.Point(12, 79);
            this.btOrganizationInf.Name = "btOrganizationInf";
            this.btOrganizationInf.Size = new System.Drawing.Size(223, 59);
            this.btOrganizationInf.TabIndex = 1;
            this.btOrganizationInf.Text = "Информация\r\nоб организациях";
            this.btOrganizationInf.UseVisualStyleBackColor = true;
            this.btOrganizationInf.Click += new System.EventHandler(this.btOrganizationInf_Click);
            // 
            // btEventsInf
            // 
            this.btEventsInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEventsInf.Location = new System.Drawing.Point(12, 144);
            this.btEventsInf.Name = "btEventsInf";
            this.btEventsInf.Size = new System.Drawing.Size(223, 61);
            this.btEventsInf.TabIndex = 2;
            this.btEventsInf.Text = "Информация\r\nо мероприятиях";
            this.btEventsInf.UseVisualStyleBackColor = true;
            this.btEventsInf.Click += new System.EventHandler(this.btEventsInf_Click);
            // 
            // btTicketInf
            // 
            this.btTicketInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btTicketInf.Location = new System.Drawing.Point(12, 206);
            this.btTicketInf.Name = "btTicketInf";
            this.btTicketInf.Size = new System.Drawing.Size(223, 58);
            this.btTicketInf.TabIndex = 3;
            this.btTicketInf.Text = "Информация\r\nо билетах";
            this.btTicketInf.UseVisualStyleBackColor = true;
            this.btTicketInf.Click += new System.EventHandler(this.btTicketInf_Click);
            // 
            // btLogs
            // 
            this.btLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btLogs.Location = new System.Drawing.Point(12, 270);
            this.btLogs.Name = "btLogs";
            this.btLogs.Size = new System.Drawing.Size(109, 35);
            this.btLogs.TabIndex = 4;
            this.btLogs.Text = "Логи";
            this.btLogs.UseVisualStyleBackColor = true;
            this.btLogs.Click += new System.EventHandler(this.btLogs_Click);
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btBack.Location = new System.Drawing.Point(126, 270);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(109, 35);
            this.btBack.TabIndex = 5;
            this.btBack.Text = "Назад";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 315);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btLogs);
            this.Controls.Add(this.btTicketInf);
            this.Controls.Add(this.btEventsInf);
            this.Controls.Add(this.btOrganizationInf);
            this.Controls.Add(this.btUsersInf);
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btUsersInf;
        private System.Windows.Forms.Button btOrganizationInf;
        private System.Windows.Forms.Button btEventsInf;
        private System.Windows.Forms.Button btTicketInf;
        private System.Windows.Forms.Button btLogs;
        private System.Windows.Forms.Button btBack;
    }
}