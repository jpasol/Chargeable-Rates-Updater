namespace Chargeable_Rates_Updater
{
    partial class Form_RatesUpdater
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabRates = new System.Windows.Forms.TabPage();
            this.viewRates = new System.Windows.Forms.DataGridView();
            this.Chargeable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Changed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabRatesHistory = new System.Windows.Forms.TabPage();
            this.viewHistory = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.TabRates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewRates)).BeginInit();
            this.TabRatesHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabRates);
            this.tabControl1.Controls.Add(this.TabRatesHistory);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(577, 474);
            this.tabControl1.TabIndex = 1;
            // 
            // TabRates
            // 
            this.TabRates.Controls.Add(this.viewRates);
            this.TabRates.Location = new System.Drawing.Point(4, 22);
            this.TabRates.Name = "TabRates";
            this.TabRates.Padding = new System.Windows.Forms.Padding(3);
            this.TabRates.Size = new System.Drawing.Size(569, 448);
            this.TabRates.TabIndex = 0;
            this.TabRates.Text = "Rates";
            this.TabRates.UseVisualStyleBackColor = true;
            // 
            // viewRates
            // 
            this.viewRates.AllowUserToAddRows = false;
            this.viewRates.AllowUserToDeleteRows = false;
            this.viewRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewRates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chargeable,
            this.Rate,
            this.User,
            this.Changed});
            this.viewRates.Location = new System.Drawing.Point(6, 6);
            this.viewRates.Name = "viewRates";
            this.viewRates.Size = new System.Drawing.Size(557, 436);
            this.viewRates.TabIndex = 0;
            // 
            // Chargeable
            // 
            this.Chargeable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Chargeable.DataPropertyName = "Chargeable";
            this.Chargeable.HeaderText = "Chargeable";
            this.Chargeable.Name = "Chargeable";
            this.Chargeable.ReadOnly = true;
            this.Chargeable.Width = 86;
            // 
            // Rate
            // 
            this.Rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rate.DataPropertyName = "Rate";
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            // 
            // User
            // 
            this.User.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.User.DataPropertyName = "User";
            this.User.HeaderText = "User";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.Width = 54;
            // 
            // Changed
            // 
            this.Changed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Changed.DataPropertyName = "Created";
            this.Changed.HeaderText = "LastChanged";
            this.Changed.Name = "Changed";
            this.Changed.ReadOnly = true;
            this.Changed.Width = 95;
            // 
            // TabRatesHistory
            // 
            this.TabRatesHistory.Controls.Add(this.viewHistory);
            this.TabRatesHistory.Location = new System.Drawing.Point(4, 22);
            this.TabRatesHistory.Name = "TabRatesHistory";
            this.TabRatesHistory.Padding = new System.Windows.Forms.Padding(3);
            this.TabRatesHistory.Size = new System.Drawing.Size(569, 448);
            this.TabRatesHistory.TabIndex = 1;
            this.TabRatesHistory.Text = "History";
            this.TabRatesHistory.UseVisualStyleBackColor = true;
            // 
            // viewHistory
            // 
            this.viewHistory.AllowUserToAddRows = false;
            this.viewHistory.AllowUserToDeleteRows = false;
            this.viewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.viewHistory.Location = new System.Drawing.Point(6, 6);
            this.viewHistory.Name = "viewHistory";
            this.viewHistory.ReadOnly = true;
            this.viewHistory.Size = new System.Drawing.Size(557, 436);
            this.viewHistory.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Chargeable";
            this.dataGridViewTextBoxColumn1.HeaderText = "Chargeable";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 86;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Rate";
            this.dataGridViewTextBoxColumn2.HeaderText = "Rate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "User";
            this.dataGridViewTextBoxColumn3.HeaderText = "User";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 54;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Created";
            this.dataGridViewTextBoxColumn4.HeaderText = "LastChanged";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 95;
            // 
            // Form_RatesUpdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 498);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form_RatesUpdater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chargeable Rates Updater";
            this.Load += new System.EventHandler(this.Form_RatesUpdater_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabRates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewRates)).EndInit();
            this.TabRatesHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabRates;
        private System.Windows.Forms.DataGridView viewRates;
        private System.Windows.Forms.TabPage TabRatesHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chargeable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Changed;
        private System.Windows.Forms.DataGridView viewHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

