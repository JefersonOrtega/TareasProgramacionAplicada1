namespace TareasProgramacionAplicada.Tarea3
{
    partial class ToStringPoligono
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
            this.ApotematextBox = new System.Windows.Forms.TextBox();
            this.LongitudtextBox = new System.Windows.Forms.TextBox();
            this.LadostextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ApotematextBox
            // 
            this.ApotematextBox.Location = new System.Drawing.Point(100, 84);
            this.ApotematextBox.Name = "ApotematextBox";
            this.ApotematextBox.Size = new System.Drawing.Size(171, 20);
            this.ApotematextBox.TabIndex = 26;
            // 
            // LongitudtextBox
            // 
            this.LongitudtextBox.Location = new System.Drawing.Point(100, 54);
            this.LongitudtextBox.Name = "LongitudtextBox";
            this.LongitudtextBox.Size = new System.Drawing.Size(171, 20);
            this.LongitudtextBox.TabIndex = 25;
            // 
            // LadostextBox
            // 
            this.LadostextBox.Location = new System.Drawing.Point(100, 22);
            this.LadostextBox.Name = "LadostextBox";
            this.LadostextBox.Size = new System.Drawing.Size(171, 20);
            this.LadostextBox.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Apotema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Longitud";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Lados";
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Location = new System.Drawing.Point(116, 158);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(75, 23);
            this.Calcularbutton.TabIndex = 20;
            this.Calcularbutton.Text = "Calcular";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // ToStringPoligono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 281);
            this.Controls.Add(this.ApotematextBox);
            this.Controls.Add(this.LongitudtextBox);
            this.Controls.Add(this.LadostextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calcularbutton);
            this.Name = "ToStringPoligono";
            this.Text = "ToStringPoligono";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ApotematextBox;
        private System.Windows.Forms.TextBox LongitudtextBox;
        private System.Windows.Forms.TextBox LadostextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Calcularbutton;
    }
}