namespace wizualne_baza_osob
{
    partial class Okno_baza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Okno_baza));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imieBox = new System.Windows.Forms.TextBox();
            this.nazwiskoBox = new System.Windows.Forms.TextBox();
            this.rokBox = new System.Windows.Forms.TextBox();
            this.wzrostBox = new System.Windows.Forms.TextBox();
            this.stanowiskocomboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButtonmezczyzna = new System.Windows.Forms.RadioButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lewoStrip = new System.Windows.Forms.ToolStripButton();
            this.nowyStrip = new System.Windows.Forms.ToolStripButton();
            this.dodajStrip = new System.Windows.Forms.ToolStripButton();
            this.zapiszStrip = new System.Windows.Forms.ToolStripButton();
            this.usunStrip = new System.Windows.Forms.ToolStripButton();
            this.prawoStrip = new System.Windows.Forms.ToolStripButton();
            this.controlNumer = new System.Windows.Forms.ToolStripButton();
            this.boxPlec = new System.Windows.Forms.GroupBox();
            this.radioButtonkobieta = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.wynagrodzenieBox = new System.Windows.Forms.TextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.boxPlec.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nazwisko:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rok:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Wzrost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Stanowisko:";
            // 
            // imieBox
            // 
            this.imieBox.Location = new System.Drawing.Point(109, 45);
            this.imieBox.Name = "imieBox";
            this.imieBox.Size = new System.Drawing.Size(100, 20);
            this.imieBox.TabIndex = 1;
            this.imieBox.Click += new System.EventHandler(this.imieBox_Click);
            this.imieBox.TextChanged += new System.EventHandler(this.imieBox_Click);
            // 
            // nazwiskoBox
            // 
            this.nazwiskoBox.Location = new System.Drawing.Point(109, 79);
            this.nazwiskoBox.Name = "nazwiskoBox";
            this.nazwiskoBox.Size = new System.Drawing.Size(100, 20);
            this.nazwiskoBox.TabIndex = 2;
            this.nazwiskoBox.Click += new System.EventHandler(this.nazwiskoBox_Click);
            this.nazwiskoBox.TextChanged += new System.EventHandler(this.nazwiskoBox_Click);
            // 
            // rokBox
            // 
            this.rokBox.BackColor = System.Drawing.SystemColors.Window;
            this.rokBox.Location = new System.Drawing.Point(109, 112);
            this.rokBox.Name = "rokBox";
            this.rokBox.Size = new System.Drawing.Size(100, 20);
            this.rokBox.TabIndex = 3;
            this.rokBox.Click += new System.EventHandler(this.rokBox_Click);
            this.rokBox.TextChanged += new System.EventHandler(this.rokBox_Click);
            // 
            // wzrostBox
            // 
            this.wzrostBox.Location = new System.Drawing.Point(109, 145);
            this.wzrostBox.Name = "wzrostBox";
            this.wzrostBox.Size = new System.Drawing.Size(100, 20);
            this.wzrostBox.TabIndex = 4;
            this.wzrostBox.Click += new System.EventHandler(this.wzrostBox_Click);
            this.wzrostBox.TextChanged += new System.EventHandler(this.wzrostBox_Click);
            this.wzrostBox.Enter += new System.EventHandler(this.wzrostBox_Enter);
            this.wzrostBox.Leave += new System.EventHandler(this.wzrostBox_Leave);
            // 
            // stanowiskocomboBox1
            // 
            this.stanowiskocomboBox1.FormattingEnabled = true;
            this.stanowiskocomboBox1.Items.AddRange(new object[] {
            "Prezes",
            "Manager",
            "Pracownik",
            "Stazysta"});
            this.stanowiskocomboBox1.Location = new System.Drawing.Point(109, 181);
            this.stanowiskocomboBox1.Name = "stanowiskocomboBox1";
            this.stanowiskocomboBox1.Size = new System.Drawing.Size(121, 21);
            this.stanowiskocomboBox1.TabIndex = 5;
            this.stanowiskocomboBox1.TextChanged += new System.EventHandler(this.stanowiskocomboBox1_Click);
            this.stanowiskocomboBox1.Click += new System.EventHandler(this.stanowiskocomboBox1_Click);
            // 
            // radioButtonmezczyzna
            // 
            this.radioButtonmezczyzna.AutoSize = true;
            this.radioButtonmezczyzna.Location = new System.Drawing.Point(6, 19);
            this.radioButtonmezczyzna.Name = "radioButtonmezczyzna";
            this.radioButtonmezczyzna.Size = new System.Drawing.Size(77, 17);
            this.radioButtonmezczyzna.TabIndex = 0;
            this.radioButtonmezczyzna.TabStop = true;
            this.radioButtonmezczyzna.Text = "mężczyzna";
            this.radioButtonmezczyzna.UseVisualStyleBackColor = true;
            this.radioButtonmezczyzna.Click += new System.EventHandler(this.radioButtonmezczyzna_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lewoStrip,
            this.toolStripButton2,
            this.nowyStrip,
            this.dodajStrip,
            this.zapiszStrip,
            this.usunStrip,
            this.prawoStrip,
            this.controlNumer,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(384, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lewoStrip
            // 
            this.lewoStrip.AutoSize = false;
            this.lewoStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lewoStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lewoStrip.Image = ((System.Drawing.Image)(resources.GetObject("lewoStrip.Image")));
            this.lewoStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lewoStrip.Name = "lewoStrip";
            this.lewoStrip.Size = new System.Drawing.Size(30, 22);
            this.lewoStrip.Text = "<<";
            this.lewoStrip.Click += new System.EventHandler(this.lewoEndStrip_Click);
            // 
            // nowyStrip
            // 
            this.nowyStrip.AutoSize = false;
            this.nowyStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.nowyStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.nowyStrip.Image = ((System.Drawing.Image)(resources.GetObject("nowyStrip.Image")));
            this.nowyStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nowyStrip.Name = "nowyStrip";
            this.nowyStrip.Size = new System.Drawing.Size(50, 22);
            this.nowyStrip.Text = "Nowy";
            this.nowyStrip.Click += new System.EventHandler(this.nowyStrip_Click);
            // 
            // dodajStrip
            // 
            this.dodajStrip.AutoSize = false;
            this.dodajStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dodajStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dodajStrip.Image = ((System.Drawing.Image)(resources.GetObject("dodajStrip.Image")));
            this.dodajStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dodajStrip.Name = "dodajStrip";
            this.dodajStrip.Size = new System.Drawing.Size(50, 22);
            this.dodajStrip.Text = "Dodaj";
            this.dodajStrip.Click += new System.EventHandler(this.dodajStrip_Click);
            // 
            // zapiszStrip
            // 
            this.zapiszStrip.AutoSize = false;
            this.zapiszStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.zapiszStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.zapiszStrip.Image = ((System.Drawing.Image)(resources.GetObject("zapiszStrip.Image")));
            this.zapiszStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zapiszStrip.Name = "zapiszStrip";
            this.zapiszStrip.Size = new System.Drawing.Size(50, 22);
            this.zapiszStrip.Text = "Zapisz";
            this.zapiszStrip.Click += new System.EventHandler(this.zapiszStrip_Click);
            // 
            // usunStrip
            // 
            this.usunStrip.AutoSize = false;
            this.usunStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.usunStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.usunStrip.Image = ((System.Drawing.Image)(resources.GetObject("usunStrip.Image")));
            this.usunStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.usunStrip.Name = "usunStrip";
            this.usunStrip.Size = new System.Drawing.Size(50, 22);
            this.usunStrip.Text = "Usuń";
            this.usunStrip.Click += new System.EventHandler(this.usunStrip_Click);
            // 
            // prawoStrip
            // 
            this.prawoStrip.AutoSize = false;
            this.prawoStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.prawoStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.prawoStrip.Image = ((System.Drawing.Image)(resources.GetObject("prawoStrip.Image")));
            this.prawoStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.prawoStrip.Name = "prawoStrip";
            this.prawoStrip.Size = new System.Drawing.Size(30, 22);
            this.prawoStrip.Text = ">";
            this.prawoStrip.Click += new System.EventHandler(this.prawoStrip_Click);
            // 
            // controlNumer
            // 
            this.controlNumer.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.controlNumer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.controlNumer.Image = ((System.Drawing.Image)(resources.GetObject("controlNumer.Image")));
            this.controlNumer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.controlNumer.Name = "controlNumer";
            this.controlNumer.Size = new System.Drawing.Size(23, 22);
            this.controlNumer.Text = "n";
            this.controlNumer.Click += new System.EventHandler(this.controlNumer_Click);
            // 
            // boxPlec
            // 
            this.boxPlec.Controls.Add(this.radioButtonkobieta);
            this.boxPlec.Controls.Add(this.radioButtonmezczyzna);
            this.boxPlec.Location = new System.Drawing.Point(242, 33);
            this.boxPlec.Name = "boxPlec";
            this.boxPlec.Size = new System.Drawing.Size(130, 66);
            this.boxPlec.TabIndex = 5;
            this.boxPlec.TabStop = false;
            this.boxPlec.Text = "Płeć";
            // 
            // radioButtonkobieta
            // 
            this.radioButtonkobieta.AutoSize = true;
            this.radioButtonkobieta.Location = new System.Drawing.Point(6, 42);
            this.radioButtonkobieta.Name = "radioButtonkobieta";
            this.radioButtonkobieta.Size = new System.Drawing.Size(60, 17);
            this.radioButtonkobieta.TabIndex = 0;
            this.radioButtonkobieta.TabStop = true;
            this.radioButtonkobieta.Text = "kobieta";
            this.radioButtonkobieta.UseVisualStyleBackColor = true;
            this.radioButtonkobieta.Click += new System.EventHandler(this.radioButtonkobieta_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 264);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(384, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(260, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "created by Marcin Werbliński";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Wynagrodzenie:";
            // 
            // wynagrodzenieBox
            // 
            this.wynagrodzenieBox.Location = new System.Drawing.Point(109, 218);
            this.wynagrodzenieBox.Name = "wynagrodzenieBox";
            this.wynagrodzenieBox.Size = new System.Drawing.Size(100, 20);
            this.wynagrodzenieBox.TabIndex = 6;
            this.wynagrodzenieBox.Click += new System.EventHandler(this.wynagrodzenieBox_Click);
            this.wynagrodzenieBox.TextChanged += new System.EventHandler(this.wynagrodzenieBox_Click);
            this.wynagrodzenieBox.Enter += new System.EventHandler(this.wynagrodzenieBox_Enter);
            this.wynagrodzenieBox.Leave += new System.EventHandler(this.wynagrodzenieBox_Leave);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(30, 22);
            this.toolStripButton1.Text = ">>";
            this.toolStripButton1.Click += new System.EventHandler(this.prawoEndStrip_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(30, 22);
            this.toolStripButton2.Text = "<";
            this.toolStripButton2.Click += new System.EventHandler(this.lewoStrip_Click);
            // 
            // Okno_baza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 286);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stanowiskocomboBox1);
            this.Controls.Add(this.wynagrodzenieBox);
            this.Controls.Add(this.wzrostBox);
            this.Controls.Add(this.rokBox);
            this.Controls.Add(this.nazwiskoBox);
            this.Controls.Add(this.imieBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.boxPlec);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Okno_baza";
            this.Text = "Baza złodziei";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.boxPlec.ResumeLayout(false);
            this.boxPlec.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox imieBox;
        private System.Windows.Forms.TextBox nazwiskoBox;
        private System.Windows.Forms.TextBox rokBox;
        private System.Windows.Forms.TextBox wzrostBox;
        private System.Windows.Forms.ComboBox stanowiskocomboBox1;
        private System.Windows.Forms.RadioButton radioButtonmezczyzna;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton lewoStrip;
        private System.Windows.Forms.ToolStripButton nowyStrip;
        private System.Windows.Forms.ToolStripButton dodajStrip;
        private System.Windows.Forms.ToolStripButton zapiszStrip;
        private System.Windows.Forms.ToolStripButton usunStrip;
        private System.Windows.Forms.ToolStripButton prawoStrip;
        private System.Windows.Forms.GroupBox boxPlec;
        private System.Windows.Forms.RadioButton radioButtonkobieta;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripButton controlNumer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox wynagrodzenieBox;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

