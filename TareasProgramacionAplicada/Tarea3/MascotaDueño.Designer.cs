namespace TareasProgramacionAplicada.Tarea3
{
    partial class MascotaDueño
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
            this.label4 = new System.Windows.Forms.Label();
            this.NombreMascotaTextbox = new System.Windows.Forms.TextBox();
            this.TipoMascotaTextBox = new System.Windows.Forms.TextBox();
            this.NombreDuenoTexbox = new System.Windows.Forms.TextBox();
            this.DireccionDuenoTextBox = new System.Windows.Forms.TextBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Mascota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de la mascota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre del dueño";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Direccion dueño";
            // 
            // NombreMascotaTextbox
            // 
            this.NombreMascotaTextbox.Location = new System.Drawing.Point(129, 29);
            this.NombreMascotaTextbox.Name = "NombreMascotaTextbox";
            this.NombreMascotaTextbox.Size = new System.Drawing.Size(100, 20);
            this.NombreMascotaTextbox.TabIndex = 4;
            // 
            // TipoMascotaTextBox
            // 
            this.TipoMascotaTextBox.Location = new System.Drawing.Point(129, 58);
            this.TipoMascotaTextBox.Name = "TipoMascotaTextBox";
            this.TipoMascotaTextBox.Size = new System.Drawing.Size(100, 20);
            this.TipoMascotaTextBox.TabIndex = 5;
            // 
            // NombreDuenoTexbox
            // 
            this.NombreDuenoTexbox.Location = new System.Drawing.Point(129, 84);
            this.NombreDuenoTexbox.Name = "NombreDuenoTexbox";
            this.NombreDuenoTexbox.Size = new System.Drawing.Size(100, 20);
            this.NombreDuenoTexbox.TabIndex = 6;
            // 
            // DireccionDuenoTextBox
            // 
            this.DireccionDuenoTextBox.Location = new System.Drawing.Point(129, 112);
            this.DireccionDuenoTextBox.Name = "DireccionDuenoTextBox";
            this.DireccionDuenoTextBox.Size = new System.Drawing.Size(100, 20);
            this.DireccionDuenoTextBox.TabIndex = 7;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(141, 158);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(88, 36);
            this.GuardarButton.TabIndex = 12;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // MascotaDueño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 455);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.DireccionDuenoTextBox);
            this.Controls.Add(this.NombreDuenoTexbox);
            this.Controls.Add(this.TipoMascotaTextBox);
            this.Controls.Add(this.NombreMascotaTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MascotaDueño";
            this.Text = "MascotaDueño";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NombreMascotaTextbox;
        private System.Windows.Forms.TextBox TipoMascotaTextBox;
        private System.Windows.Forms.TextBox NombreDuenoTexbox;
        private System.Windows.Forms.TextBox DireccionDuenoTextBox;
        private System.Windows.Forms.Button GuardarButton;
    }
}