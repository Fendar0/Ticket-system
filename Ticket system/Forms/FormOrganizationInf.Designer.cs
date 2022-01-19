namespace Ticket_system
{
    partial class FormOrganizationInf
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
            this.btAddOrganization = new System.Windows.Forms.Button();
            this.dataGridOrganization = new System.Windows.Forms.DataGridView();
            this.btBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrganization)).BeginInit();
            this.SuspendLayout();
            // 
            // btAddOrganization
            // 
            this.btAddOrganization.BackColor = System.Drawing.Color.White;
            this.btAddOrganization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddOrganization.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAddOrganization.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAddOrganization.Location = new System.Drawing.Point(12, 238);
            this.btAddOrganization.Name = "btAddOrganization";
            this.btAddOrganization.Size = new System.Drawing.Size(152, 61);
            this.btAddOrganization.TabIndex = 4;
            this.btAddOrganization.Text = "Добавить организацию";
            this.btAddOrganization.UseVisualStyleBackColor = false;
            this.btAddOrganization.Click += new System.EventHandler(this.btAddOrganization_Click);
            // 
            // dataGridOrganization
            // 
            this.dataGridOrganization.AllowUserToAddRows = false;
            this.dataGridOrganization.AllowUserToDeleteRows = false;
            this.dataGridOrganization.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridOrganization.BackgroundColor = System.Drawing.Color.White;
            this.dataGridOrganization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrganization.Location = new System.Drawing.Point(12, 12);
            this.dataGridOrganization.Name = "dataGridOrganization";
            this.dataGridOrganization.ReadOnly = true;
            this.dataGridOrganization.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridOrganization.Size = new System.Drawing.Size(770, 220);
            this.dataGridOrganization.TabIndex = 3;
            this.dataGridOrganization.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOrganization_CellContentClick);
            this.dataGridOrganization.DoubleClick += new System.EventHandler(this.dataGridOrganization_DoubleClick);
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.White;
            this.btBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btBack.Location = new System.Drawing.Point(170, 238);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(152, 61);
            this.btBack.TabIndex = 5;
            this.btBack.Text = "Назад";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // FormOrganizationInf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 306);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btAddOrganization);
            this.Controls.Add(this.dataGridOrganization);
            this.Name = "FormOrganizationInf";
            this.Text = "FormOrganizationInf";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrganization)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btAddOrganization;
        private System.Windows.Forms.DataGridView dataGridOrganization;
        private System.Windows.Forms.Button btBack;
    }
}