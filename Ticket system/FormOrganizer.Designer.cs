namespace Ticket_system
{
    partial class FormOrganizer
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
            this.button1 = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.btTicketInf = new System.Windows.Forms.Button();
            this.btEventsInf = new System.Windows.Forms.Button();
            this.btOrganizationInf = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(13, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 83);
            this.button1.TabIndex = 12;
            this.button1.Text = "Информация\r\nо категориях мероприятий\r\n";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btBack.Location = new System.Drawing.Point(126, 361);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(109, 35);
            this.btBack.TabIndex = 11;
            this.btBack.Text = "Назад";
            this.btBack.UseVisualStyleBackColor = true;
            // 
            // btTicketInf
            // 
            this.btTicketInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btTicketInf.Location = new System.Drawing.Point(13, 297);
            this.btTicketInf.Name = "btTicketInf";
            this.btTicketInf.Size = new System.Drawing.Size(223, 58);
            this.btTicketInf.TabIndex = 10;
            this.btTicketInf.Text = "Информация\r\nо билетах";
            this.btTicketInf.UseVisualStyleBackColor = true;
            // 
            // btEventsInf
            // 
            this.btEventsInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEventsInf.Location = new System.Drawing.Point(13, 166);
            this.btEventsInf.Name = "btEventsInf";
            this.btEventsInf.Size = new System.Drawing.Size(223, 61);
            this.btEventsInf.TabIndex = 9;
            this.btEventsInf.Text = "Информация\r\nо мероприятиях";
            this.btEventsInf.UseVisualStyleBackColor = true;
            // 
            // btOrganizationInf
            // 
            this.btOrganizationInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btOrganizationInf.Location = new System.Drawing.Point(12, 12);
            this.btOrganizationInf.Name = "btOrganizationInf";
            this.btOrganizationInf.Size = new System.Drawing.Size(223, 59);
            this.btOrganizationInf.TabIndex = 8;
            this.btOrganizationInf.Text = "Информация\r\nоб организациях";
            this.btOrganizationInf.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(13, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 58);
            this.button2.TabIndex = 13;
            this.button2.Text = "Информация\r\nо местах проведения";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormOrganizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 405);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btTicketInf);
            this.Controls.Add(this.btEventsInf);
            this.Controls.Add(this.btOrganizationInf);
            this.Name = "FormOrganizer";
            this.Text = "FormOrganizer";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btTicketInf;
        private System.Windows.Forms.Button btEventsInf;
        private System.Windows.Forms.Button btOrganizationInf;
        private System.Windows.Forms.Button button2;
    }
}