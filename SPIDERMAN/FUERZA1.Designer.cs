namespace SPIDERMAN
{
    partial class FUERZA_C
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FUERZA_C));
            this.btn_Atras = new System.Windows.Forms.Button();
            this.btn_SALIR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Verificar = new System.Windows.Forms.Button();
            this.txt_resp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_unidad = new System.Windows.Forms.ComboBox();
            this.btn_Calcu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Atras
            // 
            this.btn_Atras.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Atras.Font = new System.Drawing.Font("Georgia Ref", 12F, System.Drawing.FontStyle.Italic);
            this.btn_Atras.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Atras.Location = new System.Drawing.Point(499, 307);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(151, 41);
            this.btn_Atras.TabIndex = 36;
            this.btn_Atras.Text = "ATRAS";
            this.btn_Atras.UseVisualStyleBackColor = false;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // btn_SALIR
            // 
            this.btn_SALIR.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_SALIR.Font = new System.Drawing.Font("Georgia Ref", 12F, System.Drawing.FontStyle.Italic);
            this.btn_SALIR.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_SALIR.Location = new System.Drawing.Point(590, 361);
            this.btn_SALIR.Name = "btn_SALIR";
            this.btn_SALIR.Size = new System.Drawing.Size(151, 41);
            this.btn_SALIR.TabIndex = 35;
            this.btn_SALIR.Text = "SALIR";
            this.btn_SALIR.UseVisualStyleBackColor = false;
            this.btn_SALIR.Click += new System.EventHandler(this.btn_SALIR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Georgia Ref", 12F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(306, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(485, 132);
            this.label2.TabIndex = 32;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Georgia Ref", 14F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(513, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "PROBLEMA";
            // 
            // btn_Verificar
            // 
            this.btn_Verificar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Verificar.Font = new System.Drawing.Font("Georgia Ref", 12F, System.Drawing.FontStyle.Italic);
            this.btn_Verificar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Verificar.Location = new System.Drawing.Point(634, 241);
            this.btn_Verificar.Name = "btn_Verificar";
            this.btn_Verificar.Size = new System.Drawing.Size(151, 41);
            this.btn_Verificar.TabIndex = 57;
            this.btn_Verificar.Text = "VERIFICAR";
            this.btn_Verificar.UseVisualStyleBackColor = false;
            this.btn_Verificar.Click += new System.EventHandler(this.btn_Verificar_Click);
            // 
            // txt_resp
            // 
            this.txt_resp.Font = new System.Drawing.Font("DigifaceWide", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resp.Location = new System.Drawing.Point(308, 244);
            this.txt_resp.Multiline = true;
            this.txt_resp.Name = "txt_resp";
            this.txt_resp.Size = new System.Drawing.Size(151, 38);
            this.txt_resp.TabIndex = 56;
            this.txt_resp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_resp_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("Georgia Ref", 12F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(312, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 22);
            this.label4.TabIndex = 55;
            this.label4.Text = "RESPUESTA";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Georgia Ref", 12F, System.Drawing.FontStyle.Italic);
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(385, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 41);
            this.button1.TabIndex = 119;
            this.button1.Text = "AYUDA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Ayuda_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SPIDERMAN.Properties.Resources._6789992_preview;
            this.pictureBox4.Location = new System.Drawing.Point(812, 26);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(288, 396);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("Georgia Ref", 12F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(485, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 121;
            this.label5.Text = "UNIDAD";
            // 
            // cbo_unidad
            // 
            this.cbo_unidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_unidad.FormattingEnabled = true;
            this.cbo_unidad.Location = new System.Drawing.Point(476, 244);
            this.cbo_unidad.Name = "cbo_unidad";
            this.cbo_unidad.Size = new System.Drawing.Size(143, 28);
            this.cbo_unidad.TabIndex = 122;
            // 
            // btn_Calcu
            // 
            this.btn_Calcu.BackColor = System.Drawing.Color.Red;
            this.btn_Calcu.Font = new System.Drawing.Font("Georgia Ref", 12F, System.Drawing.FontStyle.Italic);
            this.btn_Calcu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Calcu.Location = new System.Drawing.Point(306, 307);
            this.btn_Calcu.Name = "btn_Calcu";
            this.btn_Calcu.Size = new System.Drawing.Size(151, 41);
            this.btn_Calcu.TabIndex = 123;
            this.btn_Calcu.Text = "CALCULADORA";
            this.btn_Calcu.UseVisualStyleBackColor = false;
            this.btn_Calcu.Click += new System.EventHandler(this.btn_Calcu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SPIDERMAN.Properties.Resources._6789992_preview;
            this.pictureBox1.Location = new System.Drawing.Point(2, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 396);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 124;
            this.pictureBox1.TabStop = false;
            // 
            // FUERZA_C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1102, 446);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Calcu);
            this.Controls.Add(this.cbo_unidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Verificar);
            this.Controls.Add(this.txt_resp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.btn_SALIR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FUERZA_C";
            this.Text = "FUERZA_C";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Atras;
        private System.Windows.Forms.Button btn_SALIR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_Verificar;
        private System.Windows.Forms.TextBox txt_resp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_unidad;
        private System.Windows.Forms.Button btn_Calcu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}