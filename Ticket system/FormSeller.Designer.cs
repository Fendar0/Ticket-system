namespace Ticket_system
{
    partial class FormSeller
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
            this.btBack = new System.Windows.Forms.Button();
            this.btTicketInf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btBack.Location = new System.Drawing.Point(220, 193);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(109, 35);
            this.btBack.TabIndex = 7;
            this.btBack.Text = "Назад";
            this.btBack.UseVisualStyleBackColor = true;
            // 
            // btTicketInf
            // 
            this.btTicketInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btTicketInf.Location = new System.Drawing.Point(107, 129);
            this.btTicketInf.Name = "btTicketInf";
            this.btTicketInf.Size = new System.Drawing.Size(223, 58);
            this.btTicketInf.TabIndex = 6;
            this.btTicketInf.Text = "Информация\r\nо билетах";
            this.btTicketInf.UseVisualStyleBackColor = true;
            // 
            // FormSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btTicketInf);
            this.Name = "FormSeller";
            this.Text = "FormSeller";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btTicketInf;
    }
}