
namespace racfollow
{
    partial class arabalist
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
            this.racfollow_maindbDataSet = new racfollow.racfollow_maindbDataSet();
            this.arabalarbilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arabalar_bilgiTableAdapter = new racfollow.racfollow_maindbDataSetTableAdapters.arabalar_bilgiTableAdapter();
            this.arabalarbilgiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.arabalarbilgiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanzimanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yakitturuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uretimyiliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiraucretiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.racfollow_maindbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarbilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarbilgiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarbilgiBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // racfollow_maindbDataSet
            // 
            this.racfollow_maindbDataSet.DataSetName = "racfollow_maindbDataSet";
            this.racfollow_maindbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // arabalarbilgiBindingSource
            // 
            this.arabalarbilgiBindingSource.DataMember = "arabalar_bilgi";
            this.arabalarbilgiBindingSource.DataSource = this.racfollow_maindbDataSet;
            // 
            // arabalar_bilgiTableAdapter
            // 
            this.arabalar_bilgiTableAdapter.ClearBeforeFill = true;
            // 
            // arabalarbilgiBindingSource1
            // 
            this.arabalarbilgiBindingSource1.DataMember = "arabalar_bilgi";
            this.arabalarbilgiBindingSource1.DataSource = this.racfollow_maindbDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.sanzimanDataGridViewTextBoxColumn,
            this.plakaDataGridViewTextBoxColumn,
            this.yakitturuDataGridViewTextBoxColumn,
            this.renkDataGridViewTextBoxColumn,
            this.uretimyiliDataGridViewTextBoxColumn,
            this.kilometreDataGridViewTextBoxColumn,
            this.kiraucretiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.arabalarbilgiBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1320, 770);
            this.dataGridView1.TabIndex = 0;
            // 
            // arabalarbilgiBindingSource2
            // 
            this.arabalarbilgiBindingSource2.DataMember = "arabalar_bilgi";
            this.arabalarbilgiBindingSource2.DataSource = this.racfollow_maindbDataSet;
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
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "marka";
            this.markaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            this.markaDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 125;
            // 
            // sanzimanDataGridViewTextBoxColumn
            // 
            this.sanzimanDataGridViewTextBoxColumn.DataPropertyName = "sanziman";
            this.sanzimanDataGridViewTextBoxColumn.HeaderText = "sanziman";
            this.sanzimanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sanzimanDataGridViewTextBoxColumn.Name = "sanzimanDataGridViewTextBoxColumn";
            this.sanzimanDataGridViewTextBoxColumn.Width = 125;
            // 
            // plakaDataGridViewTextBoxColumn
            // 
            this.plakaDataGridViewTextBoxColumn.DataPropertyName = "plaka";
            this.plakaDataGridViewTextBoxColumn.HeaderText = "plaka";
            this.plakaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.plakaDataGridViewTextBoxColumn.Name = "plakaDataGridViewTextBoxColumn";
            this.plakaDataGridViewTextBoxColumn.Width = 125;
            // 
            // yakitturuDataGridViewTextBoxColumn
            // 
            this.yakitturuDataGridViewTextBoxColumn.DataPropertyName = "yakitturu";
            this.yakitturuDataGridViewTextBoxColumn.HeaderText = "yakitturu";
            this.yakitturuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yakitturuDataGridViewTextBoxColumn.Name = "yakitturuDataGridViewTextBoxColumn";
            this.yakitturuDataGridViewTextBoxColumn.Width = 125;
            // 
            // renkDataGridViewTextBoxColumn
            // 
            this.renkDataGridViewTextBoxColumn.DataPropertyName = "renk";
            this.renkDataGridViewTextBoxColumn.HeaderText = "renk";
            this.renkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.renkDataGridViewTextBoxColumn.Name = "renkDataGridViewTextBoxColumn";
            this.renkDataGridViewTextBoxColumn.Width = 125;
            // 
            // uretimyiliDataGridViewTextBoxColumn
            // 
            this.uretimyiliDataGridViewTextBoxColumn.DataPropertyName = "uretimyili";
            this.uretimyiliDataGridViewTextBoxColumn.HeaderText = "uretimyili";
            this.uretimyiliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uretimyiliDataGridViewTextBoxColumn.Name = "uretimyiliDataGridViewTextBoxColumn";
            this.uretimyiliDataGridViewTextBoxColumn.Width = 125;
            // 
            // kilometreDataGridViewTextBoxColumn
            // 
            this.kilometreDataGridViewTextBoxColumn.DataPropertyName = "kilometre";
            this.kilometreDataGridViewTextBoxColumn.HeaderText = "kilometre";
            this.kilometreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kilometreDataGridViewTextBoxColumn.Name = "kilometreDataGridViewTextBoxColumn";
            this.kilometreDataGridViewTextBoxColumn.Width = 125;
            // 
            // kiraucretiDataGridViewTextBoxColumn
            // 
            this.kiraucretiDataGridViewTextBoxColumn.DataPropertyName = "kiraucreti";
            this.kiraucretiDataGridViewTextBoxColumn.HeaderText = "kiraucreti";
            this.kiraucretiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kiraucretiDataGridViewTextBoxColumn.Name = "kiraucretiDataGridViewTextBoxColumn";
            this.kiraucretiDataGridViewTextBoxColumn.Width = 125;
            // 
            // arabalist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1302, 723);
            this.Controls.Add(this.dataGridView1);
            this.Name = "arabalist";
            this.Text = "carlist";
            this.Load += new System.EventHandler(this.arabalist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.racfollow_maindbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarbilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarbilgiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarbilgiBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private racfollow_maindbDataSet racfollow_maindbDataSet;
        private System.Windows.Forms.BindingSource arabalarbilgiBindingSource;
        private racfollow_maindbDataSetTableAdapters.arabalar_bilgiTableAdapter arabalar_bilgiTableAdapter;
        private System.Windows.Forms.BindingSource arabalarbilgiBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanzimanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yakitturuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn renkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uretimyiliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilometreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiraucretiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource arabalarbilgiBindingSource2;
    }
}