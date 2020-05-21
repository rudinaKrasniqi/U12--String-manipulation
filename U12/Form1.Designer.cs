namespace U12
{
    partial class Form1
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
            this.txtTeksti = new System.Windows.Forms.TextBox();
            this.btnShkronjatEVogla = new System.Windows.Forms.Button();
            this.btnCapitalize = new System.Windows.Forms.Button();
            this.btnShkronjatEMedha = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblKerkoFjale = new System.Windows.Forms.Label();
            this.txtFjala = new System.Windows.Forms.TextBox();
            this.btnKerko = new System.Windows.Forms.Button();
            this.btnNumeroShkronja = new System.Windows.Forms.Button();
            this.btnNumeroNumrat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teksti";
            // 
            // txtTeksti
            // 
            this.txtTeksti.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeksti.Location = new System.Drawing.Point(39, 59);
            this.txtTeksti.Multiline = true;
            this.txtTeksti.Name = "txtTeksti";
            this.txtTeksti.Size = new System.Drawing.Size(370, 472);
            this.txtTeksti.TabIndex = 1;
            // 
            // btnShkronjatEVogla
            // 
            this.btnShkronjatEVogla.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShkronjatEVogla.Location = new System.Drawing.Point(455, 223);
            this.btnShkronjatEVogla.Name = "btnShkronjatEVogla";
            this.btnShkronjatEVogla.Size = new System.Drawing.Size(316, 52);
            this.btnShkronjatEVogla.TabIndex = 2;
            this.btnShkronjatEVogla.Text = "Numero shkronjat e vogla";
            this.btnShkronjatEVogla.UseVisualStyleBackColor = true;
            this.btnShkronjatEVogla.Click += new System.EventHandler(this.btnShkronjatEVogla_Click);
            // 
            // btnCapitalize
            // 
            this.btnCapitalize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapitalize.Location = new System.Drawing.Point(455, 361);
            this.btnCapitalize.Name = "btnCapitalize";
            this.btnCapitalize.Size = new System.Drawing.Size(316, 52);
            this.btnCapitalize.TabIndex = 2;
            this.btnCapitalize.Text = "Capitalize fjalen";
            this.btnCapitalize.UseVisualStyleBackColor = true;
            this.btnCapitalize.Click += new System.EventHandler(this.btnCapitalize_Click);
            // 
            // btnShkronjatEMedha
            // 
            this.btnShkronjatEMedha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShkronjatEMedha.Location = new System.Drawing.Point(455, 293);
            this.btnShkronjatEMedha.Name = "btnShkronjatEMedha";
            this.btnShkronjatEMedha.Size = new System.Drawing.Size(316, 52);
            this.btnShkronjatEMedha.TabIndex = 2;
            this.btnShkronjatEMedha.Text = "Numero shkronjat e medha";
            this.btnShkronjatEMedha.UseVisualStyleBackColor = true;
            this.btnShkronjatEMedha.Click += new System.EventHandler(this.btnShkronjatEMedha_Click);
            // 
            // lblKerkoFjale
            // 
            this.lblKerkoFjale.AutoSize = true;
            this.lblKerkoFjale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKerkoFjale.Location = new System.Drawing.Point(450, 441);
            this.lblKerkoFjale.Name = "lblKerkoFjale";
            this.lblKerkoFjale.Size = new System.Drawing.Size(141, 29);
            this.lblKerkoFjale.TabIndex = 0;
            this.lblKerkoFjale.Text = "Kerko fjalen";
            // 
            // txtFjala
            // 
            this.txtFjala.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFjala.Location = new System.Drawing.Point(453, 478);
            this.txtFjala.Name = "txtFjala";
            this.txtFjala.Size = new System.Drawing.Size(165, 34);
            this.txtFjala.TabIndex = 1;
            // 
            // btnKerko
            // 
            this.btnKerko.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKerko.Location = new System.Drawing.Point(624, 461);
            this.btnKerko.Name = "btnKerko";
            this.btnKerko.Size = new System.Drawing.Size(143, 51);
            this.btnKerko.TabIndex = 2;
            this.btnKerko.Text = "Kerko";
            this.btnKerko.UseVisualStyleBackColor = true;
            this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
            // 
            // btnNumeroShkronja
            // 
            this.btnNumeroShkronja.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumeroShkronja.Location = new System.Drawing.Point(455, 81);
            this.btnNumeroShkronja.Name = "btnNumeroShkronja";
            this.btnNumeroShkronja.Size = new System.Drawing.Size(316, 52);
            this.btnNumeroShkronja.TabIndex = 2;
            this.btnNumeroShkronja.Text = "Numero shkronjat";
            this.btnNumeroShkronja.UseVisualStyleBackColor = true;
            this.btnNumeroShkronja.Click += new System.EventHandler(this.btnNumeroShkronja_Click);
            // 
            // btnNumeroNumrat
            // 
            this.btnNumeroNumrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumeroNumrat.Location = new System.Drawing.Point(455, 151);
            this.btnNumeroNumrat.Name = "btnNumeroNumrat";
            this.btnNumeroNumrat.Size = new System.Drawing.Size(316, 52);
            this.btnNumeroNumrat.TabIndex = 2;
            this.btnNumeroNumrat.Text = "Numero numrat";
            this.btnNumeroNumrat.UseVisualStyleBackColor = true;
            this.btnNumeroNumrat.Click += new System.EventHandler(this.btnNumeroNumrat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.btnNumeroNumrat);
            this.Controls.Add(this.btnShkronjatEMedha);
            this.Controls.Add(this.btnKerko);
            this.Controls.Add(this.btnCapitalize);
            this.Controls.Add(this.btnNumeroShkronja);
            this.Controls.Add(this.btnShkronjatEVogla);
            this.Controls.Add(this.txtFjala);
            this.Controls.Add(this.lblKerkoFjale);
            this.Controls.Add(this.txtTeksti);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTeksti;
        private System.Windows.Forms.Button btnShkronjatEVogla;
        private System.Windows.Forms.Button btnCapitalize;
        private System.Windows.Forms.Button btnShkronjatEMedha;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblKerkoFjale;
        private System.Windows.Forms.TextBox txtFjala;
        private System.Windows.Forms.Button btnKerko;
        private System.Windows.Forms.Button btnNumeroShkronja;
        private System.Windows.Forms.Button btnNumeroNumrat;
    }
}

