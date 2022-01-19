namespace Ticket_system
{
    partial class FormEventsInf
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
            this.btAdd = new System.Windows.Forms.Button();
            this.dataGridEvents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.White;
            this.btBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btBack.Location = new System.Drawing.Point(159, 228);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(152, 61);
            this.btBack.TabIndex = 8;
            this.btBack.Text = "Назад";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.White;
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAdd.Location = new System.Drawing.Point(1, 228);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(152, 61);
            this.btAdd.TabIndex = 7;
            this.btAdd.Text = "Добавить мероприятие";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // dataGridEvents
            // 
            this.dataGridEvents.AllowUserToAddRows = false;
            this.dataGridEvents.AllowUserToDeleteRows = false;
            this.dataGridEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridEvents.BackgroundColor = System.Drawing.Color.White;
            this.dataGridEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEvents.Location = new System.Drawing.Point(1, 2);
            this.dataGridEvents.Name = "dataGridEvents";
            this.dataGridEvents.ReadOnly = true;
            this.dataGridEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEvents.Size = new System.Drawing.Size(770, 220);
            this.dataGridEvents.TabIndex = 6;
            this.dataGridEvents.DoubleClick += new System.EventHandler(this.dataGridEvents_DoubleClick);
            // 
            // FormEventsInf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 295);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dataGridEvents);
            this.Name = "FormEventsInf";
            this.Text = "FormEventsInf";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DataGridView dataGridEvents;
    }
}