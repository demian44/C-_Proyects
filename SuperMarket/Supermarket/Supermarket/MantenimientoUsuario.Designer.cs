namespace Supermarket
{
    partial class MantenimientoUsuario
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
            this.textPass = new MiLibreria.ErrorTextBox();
            this.textUsuario = new MiLibreria.ErrorTextBox();
            this.textNombre = new MiLibreria.ErrorTextBox();
            this.TextId = new MiLibreria.ErrorTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textRepPass = new MiLibreria.ErrorTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textUrl = new MiLibreria.ErrorTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioAdminYes = new System.Windows.Forms.RadioButton();
            this.radioAdminNot = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(413, 159);
            this.btnConsultar.Size = new System.Drawing.Size(146, 29);
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(414, 194);
            this.btnGuardar.Size = new System.Drawing.Size(89, 29);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(513, 302);
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(159, 153);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(245, 20);
            this.textPass.SoloNumeros = false;
            this.textPass.TabIndex = 18;
            this.textPass.Validar = true;
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(159, 111);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(245, 20);
            this.textUsuario.SoloNumeros = false;
            this.textUsuario.TabIndex = 17;
            this.textUsuario.Validar = true;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(159, 70);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(245, 20);
            this.textNombre.SoloNumeros = false;
            this.textNombre.TabIndex = 16;
            this.textNombre.Validar = true;
            // 
            // TextId
            // 
            this.TextId.Enabled = false;
            this.TextId.Location = new System.Drawing.Point(159, 30);
            this.TextId.Name = "TextId";
            this.TextId.Size = new System.Drawing.Size(67, 20);
            this.TextId.SoloNumeros = true;
            this.TextId.TabIndex = 6;
            this.TextId.Validar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Id Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Rep. Password";
            // 
            // textRepPass
            // 
            this.textRepPass.Location = new System.Drawing.Point(159, 194);
            this.textRepPass.Name = "textRepPass";
            this.textRepPass.Size = new System.Drawing.Size(247, 20);
            this.textRepPass.SoloNumeros = false;
            this.textRepPass.TabIndex = 23;
            this.textRepPass.Validar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "URL";
            // 
            // textUrl
            // 
            this.textUrl.Location = new System.Drawing.Point(78, 240);
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(326, 20);
            this.textUrl.SoloNumeros = false;
            this.textUrl.TabIndex = 25;
            this.textUrl.Validar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(414, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 18);
            this.label7.TabIndex = 28;
            this.label7.Text = "Admin Status";
            // 
            // radioAdminYes
            // 
            this.radioAdminYes.AutoSize = true;
            this.radioAdminYes.Location = new System.Drawing.Point(159, 281);
            this.radioAdminYes.Name = "radioAdminYes";
            this.radioAdminYes.Size = new System.Drawing.Size(34, 17);
            this.radioAdminYes.TabIndex = 29;
            this.radioAdminYes.Text = "Si";
            this.radioAdminYes.UseVisualStyleBackColor = true;
            // 
            // radioAdminNot
            // 
            this.radioAdminNot.AutoSize = true;
            this.radioAdminNot.Checked = true;
            this.radioAdminNot.Location = new System.Drawing.Point(209, 281);
            this.radioAdminNot.Name = "radioAdminNot";
            this.radioAdminNot.Size = new System.Drawing.Size(39, 17);
            this.radioAdminNot.TabIndex = 30;
            this.radioAdminNot.TabStop = true;
            this.radioAdminNot.Text = "No";
            this.radioAdminNot.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 29);
            this.button1.TabIndex = 31;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MantenimientoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(574, 332);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioAdminNot);
            this.Controls.Add(this.radioAdminYes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textUrl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textRepPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.TextId);
            this.Name = "MantenimientoUsuario";
            this.Text = "Administración de Usuarios";
            this.Load += new System.EventHandler(this.MantenimientoUsuario_Load);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.TextId, 0);
            this.Controls.SetChildIndex(this.textNombre, 0);
            this.Controls.SetChildIndex(this.textUsuario, 0);
            this.Controls.SetChildIndex(this.textPass, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.textRepPass, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.textUrl, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.radioAdminYes, 0);
            this.Controls.SetChildIndex(this.radioAdminNot, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MiLibreria.ErrorTextBox textPass;
        private MiLibreria.ErrorTextBox textUsuario;
        private MiLibreria.ErrorTextBox textNombre;
        private MiLibreria.ErrorTextBox TextId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private MiLibreria.ErrorTextBox textRepPass;
        private System.Windows.Forms.Label label6;
        private MiLibreria.ErrorTextBox textUrl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioAdminYes;
        private System.Windows.Forms.RadioButton radioAdminNot;
        private System.Windows.Forms.Button button1;
    }
}