namespace Ticket_system
{
    partial class FormCategoriesEvents
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
            this.dataGridViewCategIvent = new System.Windows.Forms.DataGridView();
            this.btBack = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btApply = new System.Windows.Forms.Button();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategIvent)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCategIvent
            // 
            this.dataGridViewCategIvent.AllowUserToAddRows = false;
            this.dataGridViewCategIvent.AllowUserToDeleteRows = false;
            this.dataGridViewCategIvent.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCategIvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategIvent.Location = new System.Drawing.Point(2, 2);
            this.dataGridViewCategIvent.Name = "dataGridViewCategIvent";
            this.dataGridViewCategIvent.ReadOnly = true;
            this.dataGridViewCategIvent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCategIvent.Size = new System.Drawing.Size(369, 193);
            this.dataGridViewCategIvent.TabIndex = 0;
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.White;
            this.btBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btBack.Location = new System.Drawing.Point(377, 203);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(165, 38);
            this.btBack.TabIndex = 7;
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
            this.btAdd.Location = new System.Drawing.Point(377, 2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(165, 61);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "Добавить категорию";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.White;
            this.btEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEdit.Location = new System.Drawing.Point(377, 69);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(165, 61);
            this.btEdit.TabIndex = 8;
            this.btEdit.Text = "Редактировать категорию";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btApply
            // 
            this.btApply.BackColor = System.Drawing.Color.White;
            this.btApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btApply.Enabled = false;
            this.btApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btApply.Location = new System.Drawing.Point(377, 136);
            this.btApply.Name = "btApply";
            this.btApply.Size = new System.Drawing.Size(165, 61);
            this.btApply.TabIndex = 9;
            this.btApply.Text = "Применить изменения";
            this.btApply.UseVisualStyleBackColor = false;
            this.btApply.Click += new System.EventHandler(this.btApply_Click);
            // 
            // tbCategory
            // 
            this.tbCategory.Enabled = false;
            this.tbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCategory.Location = new System.Drawing.Point(131, 207);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(240, 29);
            this.tbCategory.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Категория";
            // 
            // FormCategoriesEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 250);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCategory);
            this.Controls.Add(this.btApply);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dataGridViewCategIvent);
            this.Name = "FormCategoriesEvents";
            this.Text = "FormCategoriesEvents";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategIvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCategIvent;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btApply;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.Label label1;
    }
}