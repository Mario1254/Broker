namespace WindowsFormsApplication2
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vesiqeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maklerDataSet17 = new WindowsFormsApplication2.maklerDataSet17();
            this.t1TableAdapter = new WindowsFormsApplication2.maklerDataSet17TableAdapters.t1TableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.klDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rayonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remontDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ploshadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maklerDataSet18 = new WindowsFormsApplication2.maklerDataSet18();
            this.prodajaTableAdapter = new WindowsFormsApplication2.maklerDataSet18TableAdapters.prodajaTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.klDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rayonDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remontDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ploshadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maklerDataSet19 = new WindowsFormsApplication2.maklerDataSet19();
            this.arendaTableAdapter = new WindowsFormsApplication2.maklerDataSet19TableAdapters.arendaTableAdapter();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maklerDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodajaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maklerDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maklerDataSet19)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of contract";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(526, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nKDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.vesiqeDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.t1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // nKDataGridViewTextBoxColumn
            // 
            this.nKDataGridViewTextBoxColumn.DataPropertyName = "NK";
            this.nKDataGridViewTextBoxColumn.HeaderText = "NK";
            this.nKDataGridViewTextBoxColumn.Name = "nKDataGridViewTextBoxColumn";
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            // 
            // vesiqeDataGridViewTextBoxColumn
            // 
            this.vesiqeDataGridViewTextBoxColumn.DataPropertyName = "Vesiqe";
            this.vesiqeDataGridViewTextBoxColumn.HeaderText = "Vesiqe";
            this.vesiqeDataGridViewTextBoxColumn.Name = "vesiqeDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // t1BindingSource
            // 
            this.t1BindingSource.DataMember = "t1";
            this.t1BindingSource.DataSource = this.maklerDataSet17;
            // 
            // maklerDataSet17
            // 
            this.maklerDataSet17.DataSetName = "maklerDataSet17";
            this.maklerDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t1TableAdapter
            // 
            this.t1TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.klDataGridViewTextBoxColumn,
            this.pNDataGridViewTextBoxColumn,
            this.rayonDataGridViewTextBoxColumn,
            this.tipDataGridViewTextBoxColumn,
            this.remontDataGridViewTextBoxColumn,
            this.roomsDataGridViewTextBoxColumn,
            this.ploshadDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.prodajaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(44, 250);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(377, 150);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // klDataGridViewTextBoxColumn
            // 
            this.klDataGridViewTextBoxColumn.DataPropertyName = "Kl";
            this.klDataGridViewTextBoxColumn.HeaderText = "Kl";
            this.klDataGridViewTextBoxColumn.Name = "klDataGridViewTextBoxColumn";
            // 
            // pNDataGridViewTextBoxColumn
            // 
            this.pNDataGridViewTextBoxColumn.DataPropertyName = "PN";
            this.pNDataGridViewTextBoxColumn.HeaderText = "PN";
            this.pNDataGridViewTextBoxColumn.Name = "pNDataGridViewTextBoxColumn";
            // 
            // rayonDataGridViewTextBoxColumn
            // 
            this.rayonDataGridViewTextBoxColumn.DataPropertyName = "Rayon";
            this.rayonDataGridViewTextBoxColumn.HeaderText = "Rayon";
            this.rayonDataGridViewTextBoxColumn.Name = "rayonDataGridViewTextBoxColumn";
            // 
            // tipDataGridViewTextBoxColumn
            // 
            this.tipDataGridViewTextBoxColumn.DataPropertyName = "Tip";
            this.tipDataGridViewTextBoxColumn.HeaderText = "Tip";
            this.tipDataGridViewTextBoxColumn.Name = "tipDataGridViewTextBoxColumn";
            // 
            // remontDataGridViewTextBoxColumn
            // 
            this.remontDataGridViewTextBoxColumn.DataPropertyName = "Remont";
            this.remontDataGridViewTextBoxColumn.HeaderText = "Remont";
            this.remontDataGridViewTextBoxColumn.Name = "remontDataGridViewTextBoxColumn";
            // 
            // roomsDataGridViewTextBoxColumn
            // 
            this.roomsDataGridViewTextBoxColumn.DataPropertyName = "Rooms";
            this.roomsDataGridViewTextBoxColumn.HeaderText = "Rooms";
            this.roomsDataGridViewTextBoxColumn.Name = "roomsDataGridViewTextBoxColumn";
            // 
            // ploshadDataGridViewTextBoxColumn
            // 
            this.ploshadDataGridViewTextBoxColumn.DataPropertyName = "Ploshad";
            this.ploshadDataGridViewTextBoxColumn.HeaderText = "Ploshad";
            this.ploshadDataGridViewTextBoxColumn.Name = "ploshadDataGridViewTextBoxColumn";
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            // 
            // prodajaBindingSource
            // 
            this.prodajaBindingSource.DataMember = "prodaja";
            this.prodajaBindingSource.DataSource = this.maklerDataSet18;
            // 
            // maklerDataSet18
            // 
            this.maklerDataSet18.DataSetName = "maklerDataSet18";
            this.maklerDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prodajaTableAdapter
            // 
            this.prodajaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.klDataGridViewTextBoxColumn1,
            this.pNDataGridViewTextBoxColumn1,
            this.rayonDataGridViewTextBoxColumn1,
            this.tipDataGridViewTextBoxColumn1,
            this.remontDataGridViewTextBoxColumn1,
            this.roomsDataGridViewTextBoxColumn1,
            this.ploshadDataGridViewTextBoxColumn1,
            this.cenaDataGridViewTextBoxColumn1,
            this.srokDataGridViewTextBoxColumn,
            this.d1DataGridViewTextBoxColumn,
            this.d2DataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.arendaBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(456, 250);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(361, 150);
            this.dataGridView3.TabIndex = 4;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // klDataGridViewTextBoxColumn1
            // 
            this.klDataGridViewTextBoxColumn1.DataPropertyName = "Kl";
            this.klDataGridViewTextBoxColumn1.HeaderText = "Kl";
            this.klDataGridViewTextBoxColumn1.Name = "klDataGridViewTextBoxColumn1";
            // 
            // pNDataGridViewTextBoxColumn1
            // 
            this.pNDataGridViewTextBoxColumn1.DataPropertyName = "PN";
            this.pNDataGridViewTextBoxColumn1.HeaderText = "PN";
            this.pNDataGridViewTextBoxColumn1.Name = "pNDataGridViewTextBoxColumn1";
            // 
            // rayonDataGridViewTextBoxColumn1
            // 
            this.rayonDataGridViewTextBoxColumn1.DataPropertyName = "Rayon";
            this.rayonDataGridViewTextBoxColumn1.HeaderText = "Rayon";
            this.rayonDataGridViewTextBoxColumn1.Name = "rayonDataGridViewTextBoxColumn1";
            // 
            // tipDataGridViewTextBoxColumn1
            // 
            this.tipDataGridViewTextBoxColumn1.DataPropertyName = "Tip";
            this.tipDataGridViewTextBoxColumn1.HeaderText = "Tip";
            this.tipDataGridViewTextBoxColumn1.Name = "tipDataGridViewTextBoxColumn1";
            // 
            // remontDataGridViewTextBoxColumn1
            // 
            this.remontDataGridViewTextBoxColumn1.DataPropertyName = "Remont";
            this.remontDataGridViewTextBoxColumn1.HeaderText = "Remont";
            this.remontDataGridViewTextBoxColumn1.Name = "remontDataGridViewTextBoxColumn1";
            // 
            // roomsDataGridViewTextBoxColumn1
            // 
            this.roomsDataGridViewTextBoxColumn1.DataPropertyName = "Rooms";
            this.roomsDataGridViewTextBoxColumn1.HeaderText = "Rooms";
            this.roomsDataGridViewTextBoxColumn1.Name = "roomsDataGridViewTextBoxColumn1";
            // 
            // ploshadDataGridViewTextBoxColumn1
            // 
            this.ploshadDataGridViewTextBoxColumn1.DataPropertyName = "Ploshad";
            this.ploshadDataGridViewTextBoxColumn1.HeaderText = "Ploshad";
            this.ploshadDataGridViewTextBoxColumn1.Name = "ploshadDataGridViewTextBoxColumn1";
            // 
            // cenaDataGridViewTextBoxColumn1
            // 
            this.cenaDataGridViewTextBoxColumn1.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn1.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn1.Name = "cenaDataGridViewTextBoxColumn1";
            // 
            // srokDataGridViewTextBoxColumn
            // 
            this.srokDataGridViewTextBoxColumn.DataPropertyName = "Srok";
            this.srokDataGridViewTextBoxColumn.HeaderText = "Srok";
            this.srokDataGridViewTextBoxColumn.Name = "srokDataGridViewTextBoxColumn";
            // 
            // d1DataGridViewTextBoxColumn
            // 
            this.d1DataGridViewTextBoxColumn.DataPropertyName = "D1";
            this.d1DataGridViewTextBoxColumn.HeaderText = "D1";
            this.d1DataGridViewTextBoxColumn.Name = "d1DataGridViewTextBoxColumn";
            // 
            // d2DataGridViewTextBoxColumn
            // 
            this.d2DataGridViewTextBoxColumn.DataPropertyName = "D2";
            this.d2DataGridViewTextBoxColumn.HeaderText = "D2";
            this.d2DataGridViewTextBoxColumn.Name = "d2DataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // arendaBindingSource
            // 
            this.arendaBindingSource.DataMember = "arenda";
            this.arendaBindingSource.DataSource = this.maklerDataSet19;
            // 
            // maklerDataSet19
            // 
            this.maklerDataSet19.DataSetName = "maklerDataSet19";
            this.maklerDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // arendaTableAdapter
            // 
            this.arendaTableAdapter.ClearBeforeFill = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(535, 74);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Rent";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(535, 97);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sale";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(535, 129);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(91, 17);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Rent and sale";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(535, 152);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(88, 17);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Sale and rent";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "dolgosrochniy",
            "sutochniy"});
            this.comboBox1.Location = new System.Drawing.Point(634, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(841, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maklerDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodajaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maklerDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maklerDataSet19)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private maklerDataSet17 maklerDataSet17;
        private System.Windows.Forms.BindingSource t1BindingSource;
        private maklerDataSet17TableAdapters.t1TableAdapter t1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vesiqeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private maklerDataSet18 maklerDataSet18;
        private System.Windows.Forms.BindingSource prodajaBindingSource;
        private maklerDataSet18TableAdapters.prodajaTableAdapter prodajaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn klDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rayonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remontDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ploshadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private maklerDataSet19 maklerDataSet19;
        private System.Windows.Forms.BindingSource arendaBindingSource;
        private maklerDataSet19TableAdapters.arendaTableAdapter arendaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn klDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rayonDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn remontDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ploshadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn srokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn d1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn d2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}