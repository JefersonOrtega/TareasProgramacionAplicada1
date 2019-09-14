namespace TareasProgramacionAplicada.Tarea3
{
    partial class TiposNeumaticos
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
            this.NeumaticosdataGridView = new System.Windows.Forms.DataGridView();
            this.Generarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NeumaticosdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NeumaticosdataGridView
            // 
            this.NeumaticosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NeumaticosdataGridView.Location = new System.Drawing.Point(13, 89);
            this.NeumaticosdataGridView.Name = "NeumaticosdataGridView";
            this.NeumaticosdataGridView.Size = new System.Drawing.Size(519, 326);
            this.NeumaticosdataGridView.TabIndex = 0;
            
            // 
            // Generarbutton
            // 
            this.Generarbutton.Location = new System.Drawing.Point(175, 24);
            this.Generarbutton.Name = "Generarbutton";
            this.Generarbutton.Size = new System.Drawing.Size(180, 50);
            this.Generarbutton.TabIndex = 1;
            this.Generarbutton.Text = "Generar";
            this.Generarbutton.UseVisualStyleBackColor = true;
            this.Generarbutton.Click += new System.EventHandler(this.Generarbutton_Click);
            // 
            // TiposNeumaticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 456);
            this.Controls.Add(this.Generarbutton);
            this.Controls.Add(this.NeumaticosdataGridView);
            this.Name = "TiposNeumaticos";
            this.Text = "TiposNeumaticos";
            ((System.ComponentModel.ISupportInitialize)(this.NeumaticosdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView NeumaticosdataGridView;
        private System.Windows.Forms.Button Generarbutton;
    }
}