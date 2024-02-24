namespace DZ_22_02_List_of_contacts
{
    partial class Contact
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bInsert = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bSearch = new System.Windows.Forms.Button();
            this.bRefresh = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(360, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // bInsert
            // 
            this.bInsert.Location = new System.Drawing.Point(441, 37);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(125, 38);
            this.bInsert.TabIndex = 1;
            this.bInsert.Text = "Добавить контакт";
            this.bInsert.UseVisualStyleBackColor = true;
            this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(441, 81);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(125, 38);
            this.bUpdate.TabIndex = 1;
            this.bUpdate.Text = "Изменить контакт";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(441, 125);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(125, 38);
            this.bDelete.TabIndex = 1;
            this.bDelete.Text = "Удалить контакт";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(441, 169);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(125, 38);
            this.bSearch.TabIndex = 1;
            this.bSearch.Text = "Искать контакт";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // bRefresh
            // 
            this.bRefresh.Location = new System.Drawing.Point(441, 213);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(125, 38);
            this.bRefresh.TabIndex = 1;
            this.bRefresh.Text = "Обновление списка контактов";
            this.bRefresh.UseVisualStyleBackColor = true;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(441, 257);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(125, 38);
            this.exit.TabIndex = 1;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 319);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.bRefresh);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bInsert);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Contact";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.Contact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bRefresh;
        private System.Windows.Forms.Button exit;
    }
}

