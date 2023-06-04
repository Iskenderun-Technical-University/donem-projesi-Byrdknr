namespace byrdknr_hastane_otomasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hASTAADISOYADIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOLİKİNLİKLERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOKTORADIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rANDEVUTARİHİDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAATİDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.byyDataSet = new byrdknr_hastane_otomasyon.byyDataSet();
            this.table_1TableAdapter = new byrdknr_hastane_otomasyon.byyDataSetTableAdapters.Table_1TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.byyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hASTAADISOYADIDataGridViewTextBoxColumn,
            this.tCNODataGridViewTextBoxColumn,
            this.pOLİKİNLİKLERDataGridViewTextBoxColumn,
            this.dOKTORADIDataGridViewTextBoxColumn,
            this.rANDEVUTARİHİDataGridViewTextBoxColumn,
            this.sAATİDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.table1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 356);
            this.dataGridView1.TabIndex = 0;
            // 
            // hASTAADISOYADIDataGridViewTextBoxColumn
            // 
            this.hASTAADISOYADIDataGridViewTextBoxColumn.DataPropertyName = "HASTA ADI SOYADI";
            this.hASTAADISOYADIDataGridViewTextBoxColumn.HeaderText = "HASTA ADI SOYADI";
            this.hASTAADISOYADIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hASTAADISOYADIDataGridViewTextBoxColumn.Name = "hASTAADISOYADIDataGridViewTextBoxColumn";
            this.hASTAADISOYADIDataGridViewTextBoxColumn.Width = 125;
            // 
            // tCNODataGridViewTextBoxColumn
            // 
            this.tCNODataGridViewTextBoxColumn.DataPropertyName = "T_C_ NO";
            this.tCNODataGridViewTextBoxColumn.HeaderText = "T_C_ NO";
            this.tCNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tCNODataGridViewTextBoxColumn.Name = "tCNODataGridViewTextBoxColumn";
            this.tCNODataGridViewTextBoxColumn.Width = 125;
            // 
            // pOLİKİNLİKLERDataGridViewTextBoxColumn
            // 
            this.pOLİKİNLİKLERDataGridViewTextBoxColumn.DataPropertyName = "POLİKİNLİKLER";
            this.pOLİKİNLİKLERDataGridViewTextBoxColumn.HeaderText = "POLİKİNLİKLER";
            this.pOLİKİNLİKLERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pOLİKİNLİKLERDataGridViewTextBoxColumn.Name = "pOLİKİNLİKLERDataGridViewTextBoxColumn";
            this.pOLİKİNLİKLERDataGridViewTextBoxColumn.Width = 125;
            // 
            // dOKTORADIDataGridViewTextBoxColumn
            // 
            this.dOKTORADIDataGridViewTextBoxColumn.DataPropertyName = "DOKTOR ADI";
            this.dOKTORADIDataGridViewTextBoxColumn.HeaderText = "DOKTOR ADI";
            this.dOKTORADIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOKTORADIDataGridViewTextBoxColumn.Name = "dOKTORADIDataGridViewTextBoxColumn";
            this.dOKTORADIDataGridViewTextBoxColumn.Width = 125;
            // 
            // rANDEVUTARİHİDataGridViewTextBoxColumn
            // 
            this.rANDEVUTARİHİDataGridViewTextBoxColumn.DataPropertyName = "[RANDEVU TARİHİ";
            this.rANDEVUTARİHİDataGridViewTextBoxColumn.HeaderText = "[RANDEVU TARİHİ";
            this.rANDEVUTARİHİDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rANDEVUTARİHİDataGridViewTextBoxColumn.Name = "rANDEVUTARİHİDataGridViewTextBoxColumn";
            this.rANDEVUTARİHİDataGridViewTextBoxColumn.Width = 125;
            // 
            // sAATİDataGridViewTextBoxColumn
            // 
            this.sAATİDataGridViewTextBoxColumn.DataPropertyName = "SAATİ";
            this.sAATİDataGridViewTextBoxColumn.HeaderText = "SAATİ";
            this.sAATİDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sAATİDataGridViewTextBoxColumn.Name = "sAATİDataGridViewTextBoxColumn";
            this.sAATİDataGridViewTextBoxColumn.Width = 125;
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table_1";
            this.table1BindingSource.DataSource = this.byyDataSet;
            // 
            // byyDataSet
            // 
            this.byyDataSet.DataSetName = "byyDataSet";
            this.byyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_1TableAdapter
            // 
            this.table_1TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(12, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "GERİ DÖN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(643, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 53);
            this.button2.TabIndex = 2;
            this.button2.Text = "ÇIKIŞ YAP";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "RANDEVULARIM";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.byyDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private byyDataSet byyDataSet;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private byyDataSetTableAdapters.Table_1TableAdapter table_1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hASTAADISOYADIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOLİKİNLİKLERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOKTORADIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rANDEVUTARİHİDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAATİDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}