namespace SPIDERMAN
{
    partial class TREPAR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TREPAR));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Atras = new System.Windows.Forms.Button();
            this.btn_SALIR = new System.Windows.Forms.Button();
            this.btn_Verificar = new System.Windows.Forms.Button();
            this.txt_resp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbo_unidad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.btn_Calcu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(362, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 110);
            this.label2.TabIndex = 8;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(493, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "PROBLEMA";
            // 
            // btn_Atras
            // 
            this.btn_Atras.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Atras.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Atras.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Atras.Location = new System.Drawing.Point(459, 417);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(189, 41);
            this.btn_Atras.TabIndex = 29;
            this.btn_Atras.Text = "ATRAS";
            this.btn_Atras.UseVisualStyleBackColor = false;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // btn_SALIR
            // 
            this.btn_SALIR.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_SALIR.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SALIR.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_SALIR.Location = new System.Drawing.Point(529, 464);
            this.btn_SALIR.Name = "btn_SALIR";
            this.btn_SALIR.Size = new System.Drawing.Size(189, 41);
            this.btn_SALIR.TabIndex = 28;
            this.btn_SALIR.Text = "SALIR";
            this.btn_SALIR.UseVisualStyleBackColor = false;
            this.btn_SALIR.Click += new System.EventHandler(this.btn_SALIR_Click);
            // 
            // btn_Verificar
            // 
            this.btn_Verificar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Verificar.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Verificar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Verificar.Location = new System.Drawing.Point(648, 370);
            this.btn_Verificar.Name = "btn_Verificar";
            this.btn_Verificar.Size = new System.Drawing.Size(151, 41);
            this.btn_Verificar.TabIndex = 57;
            this.btn_Verificar.Text = "VERIFICAR";
            this.btn_Verificar.UseVisualStyleBackColor = false;
            this.btn_Verificar.Click += new System.EventHandler(this.btn_Verificar_Click);
            // 
            // txt_resp
            // 
            this.txt_resp.Location = new System.Drawing.Point(228, 367);
            this.txt_resp.Multiline = true;
            this.txt_resp.Name = "txt_resp";
            this.txt_resp.Size = new System.Drawing.Size(157, 40);
            this.txt_resp.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(236, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 22);
            this.label4.TabIndex = 55;
            this.label4.Text = "RESPUESTA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SPIDERMAN.Properties.Resources._15;
            this.pictureBox1.Location = new System.Drawing.Point(750, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 367);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // cbo_unidad
            // 
            this.cbo_unidad.FormattingEnabled = true;
            this.cbo_unidad.Location = new System.Drawing.Point(422, 378);
            this.cbo_unidad.Name = "cbo_unidad";
            this.cbo_unidad.Size = new System.Drawing.Size(121, 21);
            this.cbo_unidad.TabIndex = 128;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(428, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 22);
            this.label5.TabIndex = 127;
            this.label5.Text = "UNIDAD";
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.BackColor = System.Drawing.Color.Red;
            this.btn_ayuda.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ayuda.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_ayuda.Location = new System.Drawing.Point(285, 464);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(189, 41);
            this.btn_ayuda.TabIndex = 126;
            this.btn_ayuda.Text = "AYUDA";
            this.btn_ayuda.UseVisualStyleBackColor = false;
            this.btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click);
            // 
            // btn_Calcu
            // 
            this.btn_Calcu.BackColor = System.Drawing.Color.Red;
            this.btn_Calcu.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Calcu.Location = new System.Drawing.Point(204, 413);
            this.btn_Calcu.Name = "btn_Calcu";
            this.btn_Calcu.Size = new System.Drawing.Size(189, 41);
            this.btn_Calcu.TabIndex = 129;
            this.btn_Calcu.Text = "CALCULADORA";
            this.btn_Calcu.UseVisualStyleBackColor = false;
            this.btn_Calcu.Click += new System.EventHandler(this.btn_Calcu_Click);
            // 
            // TREPAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1128, 520);
            this.Controls.Add(this.btn_Calcu);
            this.Controls.Add(this.cbo_unidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.btn_Verificar);
            this.Controls.Add(this.txt_resp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.btn_SALIR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TREPAR";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Atras;
        private System.Windows.Forms.Button btn_SALIR;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Verificar;
        private System.Windows.Forms.TextBox txt_resp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_unidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.Button btn_Calcu;
    }
}