namespace TareasProgramacionAplicada.Tarea3
{
    partial class ProductosTienda
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
            this.label5 = new System.Windows.Forms.Label();
            this.IdProductoTextbox = new System.Windows.Forms.TextBox();
            this.NombreTextbox = new System.Windows.Forms.TextBox();
            this.TipoTextbox = new System.Windows.Forms.TextBox();
            this.MarcaTextbox = new System.Windows.Forms.TextBox();
            this.PrecioTextbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GuardarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Producto";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio";
            // 
            // IdProductoTextbox
            // 
            this.IdProductoTextbox.Location = new System.Drawing.Point(88, 22);
            this.IdProductoTextbox.Name = "IdProductoTextbox";
            this.IdProductoTextbox.Size = new System.Drawing.Size(332, 20);
            this.IdProductoTextbox.TabIndex = 5;
            // 
            // NombreTextbox
            // 
            this.NombreTextbox.Location = new System.Drawing.Point(88, 54);
            this.NombreTextbox.Name = "NombreTextbox";
            this.NombreTextbox.Size = new System.Drawing.Size(332, 20);
            this.NombreTextbox.TabIndex = 6;
            // 
            // TipoTextbox
            // 
            this.TipoTextbox.Location = new System.Drawing.Point(88, 83);
            this.TipoTextbox.Name = "TipoTextbox";
            this.TipoTextbox.Size = new System.Drawing.Size(332, 20);
            this.TipoTextbox.TabIndex = 7;
            // 
            // MarcaTextbox
            // 
            this.MarcaTextbox.Location = new System.Drawing.Point(88, 115);
            this.MarcaTextbox.Name = "MarcaTextbox";
            this.MarcaTextbox.Size = new System.Drawing.Size(332, 20);
            this.MarcaTextbox.TabIndex = 8;
            // 
            // PrecioTextbox
            // 
            this.PrecioTextbox.Location = new System.Drawing.Point(88, 144);
            this.PrecioTextbox.Name = "PrecioTextbox";
            this.PrecioTextbox.Size = new System.Drawing.Size(332, 20);
            this.PrecioTextbox.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(408, 206);
            this.dataGridView1.TabIndex = 10;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(186, 179);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(88, 36);
            this.GuardarButton.TabIndex = 11;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // ProductosTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 452);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PrecioTextbox);
            this.Controls.Add(this.MarcaTextbox);
            this.Controls.Add(this.TipoTextbox);
            this.Controls.Add(this.NombreTextbox);
            this.Controls.Add(this.IdProductoTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductosTienda";
            this.Text = "ProductosTienda";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IdProductoTextbox;
        private System.Windows.Forms.TextBox NombreTextbox;
        private System.Windows.Forms.TextBox TipoTextbox;
        private System.Windows.Forms.TextBox MarcaTextbox;
        private System.Windows.Forms.TextBox PrecioTextbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button GuardarButton;
    }
}