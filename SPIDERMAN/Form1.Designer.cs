namespace SPIDERMAN
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.cbo_modo = new System.Windows.Forms.ComboBox();
            this.btn_Validacion = new System.Windows.Forms.Button();
            this.btn_SALIR = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.75F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(309, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "ELIGE UNA MISION PARA EL \r\n       HOMBRE ARAÑA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 18.25F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(136, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkRed;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 18.25F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(136, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "MODO DE JUEGO";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_name.Location = new System.Drawing.Point(240, 169);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(494, 48);
            this.txt_name.TabIndex = 4;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // cbo_modo
            // 
            this.cbo_modo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbo_modo.FormattingEnabled = true;
            this.cbo_modo.Location = new System.Drawing.Point(240, 301);
            this.cbo_modo.Name = "cbo_modo";
            this.cbo_modo.Size = new System.Drawing.Size(494, 21);
            this.cbo_modo.TabIndex = 5;
            // 
            // btn_Validacion
            // 
            this.btn_Validacion.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Validacion.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Validacion.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Validacion.Location = new System.Drawing.Point(583, 364);
            this.btn_Validacion.Name = "btn_Validacion";
            this.btn_Validacion.Size = new System.Drawing.Size(151, 41);
            this.btn_Validacion.TabIndex = 6;
            this.btn_Validacion.Text = "SIGUIENTE";
            this.btn_Validacion.UseVisualStyleBackColor = false;
            this.btn_Validacion.Click += new System.EventHandler(this.btn_Validacion_Click);
            // 
            // btn_SALIR
            // 
            this.btn_SALIR.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_SALIR.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SALIR.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_SALIR.Location = new System.Drawing.Point(240, 364);
            this.btn_SALIR.Name = "btn_SALIR";
            this.btn_SALIR.Size = new System.Drawing.Size(151, 41);
            this.btn_SALIR.TabIndex = 7;
            this.btn_SALIR.Text = "SALIR";
            this.btn_SALIR.UseVisualStyleBackColor = false;
            this.btn_SALIR.Click += new System.EventHandler(this.btn_SALIR_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SPIDERMAN.Properties.Resources.sss;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1038, 513);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1038, 513);
            this.Controls.Add(this.btn_SALIR);
            this.Controls.Add(this.btn_Validacion);
            this.Controls.Add(this.cbo_modo);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ComboBox cbo_modo;
        private System.Windows.Forms.Button btn_Validacion;
        private System.Windows.Forms.Button btn_SALIR;
    }
}

