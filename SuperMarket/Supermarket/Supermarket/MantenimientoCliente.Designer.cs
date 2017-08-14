namespace Supermarket
{
    partial class MantenimientoCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textId_Cli = new MiLibreria.ErrorTextBox();
            this.textNom_Cli = new MiLibreria.ErrorTextBox();
            this.textApellido = new MiLibreria.ErrorTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.TabIndex = 4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.TabIndex = 5;
            // 
            // btnNuevo
            // 
            this.btnNuevo.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Apellido";
            // 
            // textId_Cli
            // 
            this.textId_Cli.Location = new System.Drawing.Point(116, 50);
            this.textId_Cli.Name = "textId_Cli";
            this.textId_Cli.Size = new System.Drawing.Size(195, 20);
            this.textId_Cli.SoloNumeros = true;
            this.textId_Cli.TabIndex = 0;
            this.textId_Cli.Validar = true;
            // 
            // textNom_Cli
            // 
            this.textNom_Cli.Location = new System.Drawing.Point(116, 81);
            this.textNom_Cli.Name = "textNom_Cli";
            this.textNom_Cli.Size = new System.Drawing.Size(195, 20);
            this.textNom_Cli.SoloNumeros = false;
            this.textNom_Cli.TabIndex = 1;
            this.textNom_Cli.Validar = true;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(116, 113);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(195, 20);
            this.textApellido.SoloNumeros = false;
            this.textApellido.TabIndex = 2;
            this.textApellido.Validar = true;
            // 
            // MantenimientoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 332);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNom_Cli);
            this.Controls.Add(this.textId_Cli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MantenimientoCliente";
            this.Text = "MantenimientoCliente";
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textId_Cli, 0);
            this.Controls.SetChildIndex(this.textNom_Cli, 0);
            this.Controls.SetChildIndex(this.textApellido, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MiLibreria.ErrorTextBox textId_Cli;
        private MiLibreria.ErrorTextBox textNom_Cli;
        private MiLibreria.ErrorTextBox textApellido;
    }
}