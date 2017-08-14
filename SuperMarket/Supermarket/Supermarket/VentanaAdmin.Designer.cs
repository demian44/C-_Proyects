namespace Supermarket
{
    partial class VentanaAdmin
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
            this.labelAdmin = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.label_Admin = new System.Windows.Forms.Label();
            this.label_User = new System.Windows.Forms.Label();
            this.label_Code = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(510, 300);
            this.btnSalir.TabIndex = 4;
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAdmin.Location = new System.Drawing.Point(280, 21);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(62, 18);
            this.labelAdmin.TabIndex = 3;
            this.labelAdmin.Text = "Admin";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelUser.Location = new System.Drawing.Point(280, 65);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(75, 18);
            this.labelUser.TabIndex = 4;
            this.labelUser.Text = "Usuario";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCode.Location = new System.Drawing.Point(280, 104);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(68, 18);
            this.labelCode.TabIndex = 5;
            this.labelCode.Text = "Código";
            // 
            // label_Admin
            // 
            this.label_Admin.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label_Admin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Admin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Admin.Location = new System.Drawing.Point(365, 21);
            this.label_Admin.Name = "label_Admin";
            this.label_Admin.Size = new System.Drawing.Size(189, 22);
            this.label_Admin.TabIndex = 6;
            // 
            // label_User
            // 
            this.label_User.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_User.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_User.Location = new System.Drawing.Point(365, 65);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(189, 22);
            this.label_User.TabIndex = 7;
            // 
            // label_Code
            // 
            this.label_Code.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Code.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Code.Location = new System.Drawing.Point(365, 104);
            this.label_Code.Name = "label_Code";
            this.label_Code.Size = new System.Drawing.Size(189, 22);
            this.label_Code.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Contenedor Principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(391, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cambiar Contraseña";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(391, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "Cerrar Sesión";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(391, 189);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(163, 31);
            this.button5.TabIndex = 1;
            this.button5.Text = "Administrar Usuarios";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // VentanaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(571, 332);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_Code);
            this.Controls.Add(this.label_User);
            this.Controls.Add(this.label_Admin);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelAdmin);
            this.Name = "VentanaAdmin";
            this.Text = "VentanaAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VentanaAdmin_FormClosed);
            this.Load += new System.EventHandler(this.VentanaAdmin_Load);
            this.Controls.SetChildIndex(this.labelAdmin, 0);
            this.Controls.SetChildIndex(this.labelUser, 0);
            this.Controls.SetChildIndex(this.labelCode, 0);
            this.Controls.SetChildIndex(this.label_Admin, 0);
            this.Controls.SetChildIndex(this.label_User, 0);
            this.Controls.SetChildIndex(this.label_Code, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label label_Admin;
        private System.Windows.Forms.Label label_User;
        private System.Windows.Forms.Label label_Code;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}