namespace thready
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_wiadomosc = new System.Windows.Forms.TextBox();
            this.label_wiadomosc = new System.Windows.Forms.Label();
            this.label_minuty = new System.Windows.Forms.Label();
            this.textBox_min = new System.Windows.Forms.TextBox();
            this.button_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_wiadomosc
            // 
            this.textBox_wiadomosc.Location = new System.Drawing.Point(42, 31);
            this.textBox_wiadomosc.Name = "textBox_wiadomosc";
            this.textBox_wiadomosc.Size = new System.Drawing.Size(143, 20);
            this.textBox_wiadomosc.TabIndex = 0;
            this.textBox_wiadomosc.Click += new System.EventHandler(this.textBox_wiadomosc_TextChanged);
            this.textBox_wiadomosc.TextChanged += new System.EventHandler(this.textBox_wiadomosc_TextChanged);
            // 
            // label_wiadomosc
            // 
            this.label_wiadomosc.AutoSize = true;
            this.label_wiadomosc.Location = new System.Drawing.Point(81, 15);
            this.label_wiadomosc.Name = "label_wiadomosc";
            this.label_wiadomosc.Size = new System.Drawing.Size(63, 13);
            this.label_wiadomosc.TabIndex = 1;
            this.label_wiadomosc.Text = "Wiadomość";
            // 
            // label_minuty
            // 
            this.label_minuty.AutoSize = true;
            this.label_minuty.Location = new System.Drawing.Point(94, 75);
            this.label_minuty.Name = "label_minuty";
            this.label_minuty.Size = new System.Drawing.Size(38, 13);
            this.label_minuty.TabIndex = 2;
            this.label_minuty.Text = "Minuty";
            // 
            // textBox_min
            // 
            this.textBox_min.Location = new System.Drawing.Point(42, 91);
            this.textBox_min.Name = "textBox_min";
            this.textBox_min.Size = new System.Drawing.Size(143, 20);
            this.textBox_min.TabIndex = 3;
            this.textBox_min.Click += new System.EventHandler(this.textBox_min_TextChanged);
            this.textBox_min.TextChanged += new System.EventHandler(this.textBox_min_TextChanged);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(75, 136);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 4;
            this.button_start.Text = "START";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            this.button_start.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_start_MouseDown);
            this.button_start.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_start_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 201);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.textBox_min);
            this.Controls.Add(this.label_minuty);
            this.Controls.Add(this.label_wiadomosc);
            this.Controls.Add(this.textBox_wiadomosc);
            this.Name = "Form1";
            this.Text = "Thread";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_wiadomosc;
        private System.Windows.Forms.Label label_wiadomosc;
        private System.Windows.Forms.Label label_minuty;
        private System.Windows.Forms.TextBox textBox_min;
        private System.Windows.Forms.Button button_start;
    }
}

