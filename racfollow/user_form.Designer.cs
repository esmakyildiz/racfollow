
namespace racfollow
{
    partial class user_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_form));
            this.adduser = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.deleteuser = new System.Windows.Forms.Button();
            this.listuser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adduser
            // 
            this.adduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adduser.ForeColor = System.Drawing.Color.White;
            this.adduser.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.adduser.ImageIndex = 0;
            this.adduser.ImageList = this.ımageList1;
            this.adduser.Location = new System.Drawing.Point(213, 264);
            this.adduser.Name = "adduser";
            this.adduser.Size = new System.Drawing.Size(244, 201);
            this.adduser.TabIndex = 2;
            this.adduser.Text = "Kullanıcı Ekle";
            this.adduser.UseVisualStyleBackColor = true;
            this.adduser.Click += new System.EventHandler(this.adduser_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "kullanıcıekle.jpg");
            this.ımageList1.Images.SetKeyName(1, "kullanıcısil.png");
            this.ımageList1.Images.SetKeyName(2, "kullanıcılistele.png");
            // 
            // deleteuser
            // 
            this.deleteuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteuser.ForeColor = System.Drawing.Color.White;
            this.deleteuser.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.deleteuser.ImageIndex = 1;
            this.deleteuser.ImageList = this.ımageList1;
            this.deleteuser.Location = new System.Drawing.Point(463, 264);
            this.deleteuser.Name = "deleteuser";
            this.deleteuser.Size = new System.Drawing.Size(244, 201);
            this.deleteuser.TabIndex = 3;
            this.deleteuser.Text = "Kullanıcı Sil";
            this.deleteuser.UseVisualStyleBackColor = true;
            // 
            // listuser
            // 
            this.listuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listuser.ForeColor = System.Drawing.Color.White;
            this.listuser.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.listuser.ImageIndex = 2;
            this.listuser.ImageList = this.ımageList1;
            this.listuser.Location = new System.Drawing.Point(713, 264);
            this.listuser.Name = "listuser";
            this.listuser.Size = new System.Drawing.Size(244, 201);
            this.listuser.TabIndex = 4;
            this.listuser.Text = "Kullanıcıları Listele";
            this.listuser.UseVisualStyleBackColor = true;
            this.listuser.Click += new System.EventHandler(this.listuser_Click);
            // 
            // user_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1302, 723);
            this.Controls.Add(this.listuser);
            this.Controls.Add(this.deleteuser);
            this.Controls.Add(this.adduser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "user_form";
            this.Text = "user_form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adduser;
        private System.Windows.Forms.Button deleteuser;
        private System.Windows.Forms.Button listuser;
        private System.Windows.Forms.ImageList ımageList1;
    }
}