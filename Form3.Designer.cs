namespace RandA
{
    partial class Form3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.partyDataSet = new RandA.partyDataSet();
            this.partyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partyTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partyTableTableAdapter = new RandA.partyDataSetTableAdapters.partyTableTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyLeaderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBox1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(106, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 33);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(106, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Khaki;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(106, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Организатор:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBox2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(106, 202);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 33);
            this.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Khaki;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(101, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата проведения:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBox3.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(106, 274);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 33);
            this.textBox3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Khaki;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(376, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Время начала:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBox4.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(374, 139);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(168, 33);
            this.textBox4.TabIndex = 6;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Khaki;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(376, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Адрес проведения:";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBox5.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(374, 202);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(168, 33);
            this.textBox5.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Khaki;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(376, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Бюджет:";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBox6.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(374, 274);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(168, 33);
            this.textBox6.TabIndex = 10;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(610, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 77);
            this.button1.TabIndex = 12;
            this.button1.Text = "Создать мероприятие";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(631, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(157, 97);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.Visible = false;
            // 
            // partyDataSet
            // 
            this.partyDataSet.DataSetName = "partyDataSet";
            this.partyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partyDataSetBindingSource
            // 
            this.partyDataSetBindingSource.DataSource = this.partyDataSet;
            this.partyDataSetBindingSource.Position = 0;
            // 
            // partyTableBindingSource
            // 
            this.partyTableBindingSource.DataMember = "partyTable";
            this.partyTableBindingSource.DataSource = this.partyDataSetBindingSource;
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RandA.Properties.Resources._8cf93ae0_6d87_542e_a273_7fe408ea7f28;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource partyDataSetBindingSource;
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
    }
}