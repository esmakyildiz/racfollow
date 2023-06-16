
namespace racfollow
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
            this.esma = new System.Windows.Forms.Label();
            this.usersbutton = new System.Windows.Forms.Button();
            this.cars_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // esma
            // 
            this.esma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.esma.AutoSize = true;
            this.esma.BackColor = System.Drawing.Color.Transparent;
            this.esma.Font = new System.Drawing.Font("MS PGothic", 70F);
            this.esma.ForeColor = System.Drawing.Color.White;
            this.esma.Location = new System.Drawing.Point(321, 18);
            this.esma.Name = "esma";
            this.esma.Size = new System.Drawing.Size(718, 117);
            this.esma.TabIndex = 0;
            this.esma.Text = "RACFOLLOW";
            // 
            // usersbutton
            // 
            this.usersbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usersbutton.ForeColor = System.Drawing.Color.White;
            this.usersbutton.Location = new System.Drawing.Point(341, 158);
            this.usersbutton.Name = "usersbutton";
            this.usersbutton.Size = new System.Drawing.Size(238, 183);
            this.usersbutton.TabIndex = 1;
            this.usersbutton.Text = "Kullanıcılar";
            this.usersbutton.UseVisualStyleBackColor = true;
            this.usersbutton.Click += new System.EventHandler(this.usersbutton_Click_1);
            // 
            // cars_button
            // 
            this.cars_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cars_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cars_button.ForeColor = System.Drawing.Color.White;
            this.cars_button.Location = new System.Drawing.Point(801, 158);
            this.cars_button.Name = "cars_button";
            this.cars_button.Size = new System.Drawing.Size(238, 183);
            this.cars_button.TabIndex = 2;
            this.cars_button.Text = "Arabalar";
            this.cars_button.UseVisualStyleBackColor = true;
            this.cars_button.Click += new System.EventHandler(this.cars_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::racfollow.Properties.Resources.Rentacar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1302, 723);
            this.Controls.Add(this.cars_button);
            this.Controls.Add(this.usersbutton);
            this.Controls.Add(this.esma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label esma;
        private System.Windows.Forms.Button usersbutton;
        private System.Windows.Forms.Button cars_button;
    }
}

