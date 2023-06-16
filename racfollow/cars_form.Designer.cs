
namespace racfollow
{
    partial class cars_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cars_form));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listcar = new System.Windows.Forms.Button();
            this.deletecar = new System.Windows.Forms.Button();
            this.addcar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "beeb59f2-ee4a-495c-9270-6761981f5574.jpg");
            this.ımageList1.Images.SetKeyName(1, "0f0949e1-f978-46ac-bb63-516c591d7281.jpg");
            this.ımageList1.Images.SetKeyName(2, "587fe990-c455-40fd-8fd6-f29427bcbba1.jpg");
            // 
            // listcar
            // 
            this.listcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listcar.ForeColor = System.Drawing.Color.White;
            this.listcar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.listcar.ImageIndex = 2;
            this.listcar.ImageList = this.ımageList1;
            this.listcar.Location = new System.Drawing.Point(709, 261);
            this.listcar.Name = "listcar";
            this.listcar.Size = new System.Drawing.Size(244, 201);
            this.listcar.TabIndex = 7;
            this.listcar.Text = "Arabaları Listele";
            this.listcar.UseVisualStyleBackColor = true;
            this.listcar.Click += new System.EventHandler(this.listcar_Click_1);
            // 
            // deletecar
            // 
            this.deletecar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletecar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deletecar.ForeColor = System.Drawing.Color.White;
            this.deletecar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.deletecar.ImageIndex = 1;
            this.deletecar.ImageList = this.ımageList1;
            this.deletecar.Location = new System.Drawing.Point(459, 261);
            this.deletecar.Name = "deletecar";
            this.deletecar.Size = new System.Drawing.Size(244, 201);
            this.deletecar.TabIndex = 6;
            this.deletecar.Text = "Araba Sil";
            this.deletecar.UseVisualStyleBackColor = true;
            // 
            // addcar
            // 
            this.addcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addcar.ForeColor = System.Drawing.Color.White;
            this.addcar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.addcar.ImageIndex = 0;
            this.addcar.ImageList = this.ımageList1;
            this.addcar.Location = new System.Drawing.Point(209, 261);
            this.addcar.Name = "addcar";
            this.addcar.Size = new System.Drawing.Size(244, 201);
            this.addcar.TabIndex = 5;
            this.addcar.Text = "Araba Ekle";
            this.addcar.UseVisualStyleBackColor = true;
            this.addcar.Click += new System.EventHandler(this.addcar_Click);
            // 
            // cars_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1302, 723);
            this.Controls.Add(this.listcar);
            this.Controls.Add(this.deletecar);
            this.Controls.Add(this.addcar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "cars_form";
            this.Text = "cars_form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listcar;
        private System.Windows.Forms.Button deletecar;
        private System.Windows.Forms.Button addcar;
        private System.Windows.Forms.ImageList ımageList1;
    }
}