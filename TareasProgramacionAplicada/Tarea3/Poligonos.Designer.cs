namespace TareasProgramacionAplicada.Tarea3
{
    partial class Poligonos
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
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LadostextBox = new System.Windows.Forms.TextBox();
            this.LongitudtextBox = new System.Windows.Forms.TextBox();
            this.ApotematextBox = new System.Windows.Forms.TextBox();
            this.AreatextBox = new System.Windows.Forms.TextBox();
            this.PerimetrotextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Location = new System.Drawing.Point(96, 219);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(75, 23);
            this.Calcularbutton.TabIndex = 0;
            this.Calcularbutton.Text = "Calcular";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Longitud";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apotema";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Area";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Perimetro";
            // 
            // LadostextBox
            // 
            this.LadostextBox.Location = new System.Drawing.Point(96, 18);
            this.LadostextBox.Name = "LadostextBox";
            this.LadostextBox.Size = new System.Drawing.Size(171, 20);
            this.LadostextBox.TabIndex = 6;
            // 
            // LongitudtextBox
            // 
            this.LongitudtextBox.Location = new System.Drawing.Point(96, 50);
            this.LongitudtextBox.Name = "LongitudtextBox";
            this.LongitudtextBox.Size = new System.Drawing.Size(171, 20);
            this.LongitudtextBox.TabIndex = 7;
            // 
            // ApotematextBox
            // 
            this.ApotematextBox.Location = new System.Drawing.Point(96, 80);
            this.ApotematextBox.Name = "ApotematextBox";
            this.ApotematextBox.Size = new System.Drawing.Size(171, 20);
            this.ApotematextBox.TabIndex = 8;
            // 
            // AreatextBox
            // 
            this.AreatextBox.Location = new System.Drawing.Point(13, 164);
            this.AreatextBox.Name = "AreatextBox";
            this.AreatextBox.ReadOnly = true;
            this.AreatextBox.Size = new System.Drawing.Size(100, 20);
            this.AreatextBox.TabIndex = 9;
            // 
            // PerimetrotextBox
            // 
            this.PerimetrotextBox.Location = new System.Drawing.Point(167, 164);
            this.PerimetrotextBox.Name = "PerimetrotextBox";
            this.PerimetrotextBox.ReadOnly = true;
            this.PerimetrotextBox.Size = new System.Drawing.Size(100, 20);
            this.PerimetrotextBox.TabIndex = 10;
            // 
            // Poligonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 303);
            this.Controls.Add(this.PerimetrotextBox);
            this.Controls.Add(this.AreatextBox);
            this.Controls.Add(this.ApotematextBox);
            this.Controls.Add(this.LongitudtextBox);
            this.Controls.Add(this.LadostextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calcularbutton);
            this.Name = "Poligonos";
            this.Text = "Poligonos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calcularbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LadostextBox;
        private System.Windows.Forms.TextBox LongitudtextBox;
        private System.Windows.Forms.TextBox ApotematextBox;
        private System.Windows.Forms.TextBox AreatextBox;
        private System.Windows.Forms.TextBox PerimetrotextBox;
    }
}