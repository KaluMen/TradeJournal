namespace Journal
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tradeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pairIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.journalDataSet = new Journal.JournalDataSet();
            this.tradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tradesTableAdapter = new Journal.JournalDataSetTableAdapters.TradesTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pairsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pairNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pairsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pairsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tradesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tradesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pairsTableAdapter = new Journal.JournalDataSetTableAdapters.PairsTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pairsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pairsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chartreuse;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(12, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(99, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(186, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tradeIDDataGridViewTextBoxColumn,
            this.pairIDDataGridViewTextBoxColumn,
            this.dateTimeDataGridViewTextBoxColumn,
            this.pnLDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tradesBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.Size = new System.Drawing.Size(452, 200);
            this.dataGridView1.TabIndex = 3;
            // 
            // tradeIDDataGridViewTextBoxColumn
            // 
            this.tradeIDDataGridViewTextBoxColumn.DataPropertyName = "TradeID";
            this.tradeIDDataGridViewTextBoxColumn.HeaderText = "TradeID";
            this.tradeIDDataGridViewTextBoxColumn.Name = "tradeIDDataGridViewTextBoxColumn";
            // 
            // pairIDDataGridViewTextBoxColumn
            // 
            this.pairIDDataGridViewTextBoxColumn.DataPropertyName = "PairID";
            this.pairIDDataGridViewTextBoxColumn.HeaderText = "PairID";
            this.pairIDDataGridViewTextBoxColumn.Name = "pairIDDataGridViewTextBoxColumn";
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            // 
            // pnLDataGridViewTextBoxColumn
            // 
            this.pnLDataGridViewTextBoxColumn.DataPropertyName = "PnL";
            this.pnLDataGridViewTextBoxColumn.HeaderText = "PnL";
            this.pnLDataGridViewTextBoxColumn.Name = "pnLDataGridViewTextBoxColumn";
            // 
            // tradesBindingSource3
            // 
            this.tradesBindingSource3.DataMember = "Trades";
            this.tradesBindingSource3.DataSource = this.journalDataSet;
            // 
            // journalDataSet
            // 
            this.journalDataSet.DataSetName = "JournalDataSet";
            this.journalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tradesBindingSource
            // 
            this.tradesBindingSource.DataMember = "Trades";
            this.tradesBindingSource.DataSource = this.journalDataSet;
            // 
            // tradesTableAdapter
            // 
            this.tradesTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 23);
            this.textBox1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(158, 103);
            this.dateTimePicker1.MaximumSize = new System.Drawing.Size(190, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 23);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "PairID";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(547, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 33);
            this.button4.TabIndex = 9;
            this.button4.Text = "Statistic";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkRed;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(634, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 33);
            this.button5.TabIndex = 10;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(155, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(309, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "PnL";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pairsIDDataGridViewTextBoxColumn,
            this.pairNameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.pairsBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(480, 103);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(245, 254);
            this.dataGridView2.TabIndex = 13;
            // 
            // pairsIDDataGridViewTextBoxColumn
            // 
            this.pairsIDDataGridViewTextBoxColumn.DataPropertyName = "PairsID";
            this.pairsIDDataGridViewTextBoxColumn.HeaderText = "PairsID";
            this.pairsIDDataGridViewTextBoxColumn.Name = "pairsIDDataGridViewTextBoxColumn";
            // 
            // pairNameDataGridViewTextBoxColumn
            // 
            this.pairNameDataGridViewTextBoxColumn.DataPropertyName = "PairName";
            this.pairNameDataGridViewTextBoxColumn.HeaderText = "PairName";
            this.pairNameDataGridViewTextBoxColumn.Name = "pairNameDataGridViewTextBoxColumn";
            // 
            // pairsBindingSource1
            // 
            this.pairsBindingSource1.DataMember = "Pairs";
            this.pairsBindingSource1.DataSource = this.journalDataSet;
            // 
            // pairsBindingSource
            // 
            this.pairsBindingSource.DataMember = "Pairs";
            this.pairsBindingSource.DataSource = this.journalDataSet;
            // 
            // tradesBindingSource1
            // 
            this.tradesBindingSource1.DataMember = "Trades";
            this.tradesBindingSource1.DataSource = this.journalDataSet;
            // 
            // tradesBindingSource2
            // 
            this.tradesBindingSource2.DataMember = "Trades";
            this.tradesBindingSource2.DataSource = this.journalDataSet;
            // 
            // pairsTableAdapter
            // 
            this.pairsTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(362, 22);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 33);
            this.button6.TabIndex = 14;
            this.button6.Text = "Instruction";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(312, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 23);
            this.textBox2.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(510, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Lista dostupnih Parova";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(737, 376);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pairsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pairsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradesBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private JournalDataSet journalDataSet;
        private System.Windows.Forms.BindingSource tradesBindingSource;
        private JournalDataSetTableAdapters.TradesTableAdapter tradesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pairIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnLDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource tradesBindingSource1;
        private System.Windows.Forms.BindingSource tradesBindingSource2;
        private System.Windows.Forms.BindingSource pairsBindingSource;
        private JournalDataSetTableAdapters.PairsTableAdapter pairsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pairsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pairNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource tradesBindingSource3;
        private System.Windows.Forms.BindingSource pairsBindingSource1;
        private System.Windows.Forms.Label label4;
    }
}

