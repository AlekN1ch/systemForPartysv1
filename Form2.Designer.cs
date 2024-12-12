namespace RandA
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.partyDataSet = new RandA.partyDataSet();
            this.partyTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partyTableTableAdapter = new RandA.partyDataSetTableAdapters.partyTableTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyLeaderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.partyNameDataGridViewTextBoxColumn,
            this.partyDataDataGridViewTextBoxColumn,
            this.partyTimeDataGridViewTextBoxColumn,
            this.partyBalanceDataGridViewTextBoxColumn,
            this.partyPlaceDataGridViewTextBoxColumn,
            this.partyLeaderDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.partyTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(110, 102);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // partyDataSet
            // 
            this.partyDataSet.DataSetName = "partyDataSet";
            this.partyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partyTableBindingSource
            // 
            this.partyTableBindingSource.DataMember = "partyTable";
            this.partyTableBindingSource.DataSource = this.partyDataSet;
            // 
            // partyTableTableAdapter
            // 
            this.partyTableTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.Width = 125;
            // 
            // partyNameDataGridViewTextBoxColumn
            // 
            this.partyNameDataGridViewTextBoxColumn.DataPropertyName = "partyName";
            this.partyNameDataGridViewTextBoxColumn.HeaderText = "partyName";
            this.partyNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partyNameDataGridViewTextBoxColumn.Name = "partyNameDataGridViewTextBoxColumn";
            this.partyNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // partyDataDataGridViewTextBoxColumn
            // 
            this.partyDataDataGridViewTextBoxColumn.DataPropertyName = "partyData";
            this.partyDataDataGridViewTextBoxColumn.HeaderText = "partyData";
            this.partyDataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partyDataDataGridViewTextBoxColumn.Name = "partyDataDataGridViewTextBoxColumn";
            this.partyDataDataGridViewTextBoxColumn.Width = 125;
            // 
            // partyTimeDataGridViewTextBoxColumn
            // 
            this.partyTimeDataGridViewTextBoxColumn.DataPropertyName = "partyTime";
            this.partyTimeDataGridViewTextBoxColumn.HeaderText = "partyTime";
            this.partyTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partyTimeDataGridViewTextBoxColumn.Name = "partyTimeDataGridViewTextBoxColumn";
            this.partyTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // partyBalanceDataGridViewTextBoxColumn
            // 
            this.partyBalanceDataGridViewTextBoxColumn.DataPropertyName = "partyBalance";
            this.partyBalanceDataGridViewTextBoxColumn.HeaderText = "partyBalance";
            this.partyBalanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partyBalanceDataGridViewTextBoxColumn.Name = "partyBalanceDataGridViewTextBoxColumn";
            this.partyBalanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // partyPlaceDataGridViewTextBoxColumn
            // 
            this.partyPlaceDataGridViewTextBoxColumn.DataPropertyName = "partyPlace";
            this.partyPlaceDataGridViewTextBoxColumn.HeaderText = "partyPlace";
            this.partyPlaceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partyPlaceDataGridViewTextBoxColumn.Name = "partyPlaceDataGridViewTextBoxColumn";
            this.partyPlaceDataGridViewTextBoxColumn.Width = 125;
            // 
            // partyLeaderDataGridViewTextBoxColumn
            // 
            this.partyLeaderDataGridViewTextBoxColumn.DataPropertyName = "partyLeader";
            this.partyLeaderDataGridViewTextBoxColumn.HeaderText = "partyLeader";
            this.partyLeaderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partyLeaderDataGridViewTextBoxColumn.Name = "partyLeaderDataGridViewTextBoxColumn";
            this.partyLeaderDataGridViewTextBoxColumn.Width = 125;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(77, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(249, 290);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.LemonChiffon;
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 29;
            this.listBox2.Location = new System.Drawing.Point(332, 73);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(365, 290);
            this.listBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Sitka Banner", 28F);
            this.button1.Location = new System.Drawing.Point(684, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 76);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Khaki;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(687, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 55);
            this.button2.TabIndex = 4;
            this.button2.Text = "Обновить таблицу";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(72, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Khaki;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(327, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дополнительные данные:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RandA.Properties.Resources._8cf93ae0_6d87_542e_a273_7fe408ea7f28;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private partyDataSet partyDataSet;
        private System.Windows.Forms.BindingSource partyTableBindingSource;
        private partyDataSetTableAdapters.partyTableTableAdapter partyTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyPlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyLeaderDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}