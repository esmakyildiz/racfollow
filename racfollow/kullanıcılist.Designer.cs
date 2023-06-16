
namespace racfollow
{
    partial class kullanıcılist
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
            this.racfollow_maindbDataSet = new racfollow.racfollow_maindbDataSet();
            this.kullanıcılarbilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullanıcılar_bilgiTableAdapter = new racfollow.racfollow_maindbDataSetTableAdapters.kullanıcılar_bilgiTableAdapter();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racfollow_maindbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcılarbilgiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.tcDataGridViewTextBoxColumn,
            this.isimDataGridViewTextBoxColumn,
            this.soyisimDataGridViewTextBoxColumn,
            this.numaraDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kullanıcılarbilgiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1320, 770);
            this.dataGridView1.TabIndex = 0;
            // 
            // racfollow_maindbDataSet
            // 
            this.racfollow_maindbDataSet.DataSetName = "racfollow_maindbDataSet";
            this.racfollow_maindbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullanıcılarbilgiBindingSource
            // 
            this.kullanıcılarbilgiBindingSource.DataMember = "kullanıcılar_bilgi";
            this.kullanıcılarbilgiBindingSource.DataSource = this.racfollow_maindbDataSet;
            // 
            // kullanıcılar_bilgiTableAdapter
            // 
            this.kullanıcılar_bilgiTableAdapter.ClearBeforeFill = true;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Width = 125;
            // 
            // tcDataGridViewTextBoxColumn
            // 
            this.tcDataGridViewTextBoxColumn.DataPropertyName = "tc";
            this.tcDataGridViewTextBoxColumn.HeaderText = "tc";
            this.tcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tcDataGridViewTextBoxColumn.Name = "tcDataGridViewTextBoxColumn";
            this.tcDataGridViewTextBoxColumn.Width = 125;
            // 
            // isimDataGridViewTextBoxColumn
            // 
            this.isimDataGridViewTextBoxColumn.DataPropertyName = "isim";
            this.isimDataGridViewTextBoxColumn.HeaderText = "isim";
            this.isimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isimDataGridViewTextBoxColumn.Name = "isimDataGridViewTextBoxColumn";
            this.isimDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyisimDataGridViewTextBoxColumn
            // 
            this.soyisimDataGridViewTextBoxColumn.DataPropertyName = "soyisim";
            this.soyisimDataGridViewTextBoxColumn.HeaderText = "soyisim";
            this.soyisimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyisimDataGridViewTextBoxColumn.Name = "soyisimDataGridViewTextBoxColumn";
            this.soyisimDataGridViewTextBoxColumn.Width = 125;
            // 
            // numaraDataGridViewTextBoxColumn
            // 
            this.numaraDataGridViewTextBoxColumn.DataPropertyName = "numara";
            this.numaraDataGridViewTextBoxColumn.HeaderText = "numara";
            this.numaraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numaraDataGridViewTextBoxColumn.Name = "numaraDataGridViewTextBoxColumn";
            this.numaraDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "adres";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 125;
            // 
            // kullanıcılist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1301, 723);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kullanıcılist";
            this.Text = "kullanıcılist";
            this.Load += new System.EventHandler(this.kullanıcılist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racfollow_maindbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcılarbilgiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private racfollow_maindbDataSet racfollow_maindbDataSet;
        private System.Windows.Forms.BindingSource kullanıcılarbilgiBindingSource;
        private racfollow_maindbDataSetTableAdapters.kullanıcılar_bilgiTableAdapter kullanıcılar_bilgiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
    }
}