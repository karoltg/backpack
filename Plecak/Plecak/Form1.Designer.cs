namespace Plecak
{
    partial class fError
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bPrice = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.bWeight = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nWeightMin = new System.Windows.Forms.NumericUpDown();
            this.nWeightMax = new System.Windows.Forms.NumericUpDown();
            this.nPriceMin = new System.Windows.Forms.NumericUpDown();
            this.nPriceMax = new System.Windows.Forms.NumericUpDown();
            this.nBackpackSize = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nNumberOfElements = new System.Windows.Forms.NumericUpDown();
            this.lError = new System.Windows.Forms.Label();
            this.priceError = new System.Windows.Forms.Label();
            this.weightError = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaWygenerowanychElementówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaPosortowamaCenaWagaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plecakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algorytmyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aproksymacyjnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zachłannyWagaMinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zachłannyCenaMaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zachłannyCenaWagaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zOgraniczeniemElementówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nMaxCopyOfElement = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.zachłannyWagaMinToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zachłannyCenaMaxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zachłannyCenaWagaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nWeightMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWeightMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPriceMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPriceMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBackpackSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumberOfElements)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxCopyOfElement)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Waga min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Waga max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cena min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cena max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ilość elementów";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Generuj nowe dane";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bPrice
            // 
            this.bPrice.Location = new System.Drawing.Point(15, 239);
            this.bPrice.Name = "bPrice";
            this.bPrice.Size = new System.Drawing.Size(97, 34);
            this.bPrice.TabIndex = 8;
            this.bPrice.Text = "Nowe ceny";
            this.bPrice.UseVisualStyleBackColor = true;
            this.bPrice.Click += new System.EventHandler(this.bPrice_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Wygeneruj nowe ceny dla istniejących elementów";
            // 
            // bWeight
            // 
            this.bWeight.Location = new System.Drawing.Point(18, 102);
            this.bWeight.Name = "bWeight";
            this.bWeight.Size = new System.Drawing.Size(97, 34);
            this.bWeight.TabIndex = 7;
            this.bWeight.Text = "Nowa waga";
            this.bWeight.UseVisualStyleBackColor = true;
            this.bWeight.Click += new System.EventHandler(this.bWeight_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Wygeneruj nową wagę dla istnejących elementów";
            // 
            // nWeightMin
            // 
            this.nWeightMin.Location = new System.Drawing.Point(15, 57);
            this.nWeightMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nWeightMin.Name = "nWeightMin";
            this.nWeightMin.Size = new System.Drawing.Size(100, 20);
            this.nWeightMin.TabIndex = 0;
            // 
            // nWeightMax
            // 
            this.nWeightMax.Location = new System.Drawing.Point(121, 57);
            this.nWeightMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nWeightMax.Name = "nWeightMax";
            this.nWeightMax.Size = new System.Drawing.Size(100, 20);
            this.nWeightMax.TabIndex = 1;
            // 
            // nPriceMin
            // 
            this.nPriceMin.Location = new System.Drawing.Point(15, 180);
            this.nPriceMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nPriceMin.Name = "nPriceMin";
            this.nPriceMin.Size = new System.Drawing.Size(100, 20);
            this.nPriceMin.TabIndex = 2;
            // 
            // nPriceMax
            // 
            this.nPriceMax.Location = new System.Drawing.Point(121, 180);
            this.nPriceMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nPriceMax.Name = "nPriceMax";
            this.nPriceMax.Size = new System.Drawing.Size(100, 20);
            this.nPriceMax.TabIndex = 3;
            // 
            // nBackpackSize
            // 
            this.nBackpackSize.Location = new System.Drawing.Point(340, 57);
            this.nBackpackSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nBackpackSize.Name = "nBackpackSize";
            this.nBackpackSize.Size = new System.Drawing.Size(100, 20);
            this.nBackpackSize.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(337, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Rozmiar plecaka";
            // 
            // nNumberOfElements
            // 
            this.nNumberOfElements.Location = new System.Drawing.Point(340, 180);
            this.nNumberOfElements.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nNumberOfElements.Name = "nNumberOfElements";
            this.nNumberOfElements.Size = new System.Drawing.Size(100, 20);
            this.nNumberOfElements.TabIndex = 5;
            // 
            // lError
            // 
            this.lError.AutoSize = true;
            this.lError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lError.ForeColor = System.Drawing.Color.Red;
            this.lError.Location = new System.Drawing.Point(78, 300);
            this.lError.Name = "lError";
            this.lError.Size = new System.Drawing.Size(395, 20);
            this.lError.TabIndex = 22;
            this.lError.Text = "Wszystkie elementy muszą być uzupełnione poprawnie";
            this.lError.Visible = false;
            // 
            // priceError
            // 
            this.priceError.AutoSize = true;
            this.priceError.ForeColor = System.Drawing.Color.Red;
            this.priceError.Location = new System.Drawing.Point(12, 276);
            this.priceError.Name = "priceError";
            this.priceError.Size = new System.Drawing.Size(94, 13);
            this.priceError.TabIndex = 23;
            this.priceError.Text = "Uzupełnij wartości";
            // 
            // weightError
            // 
            this.weightError.AutoSize = true;
            this.weightError.ForeColor = System.Drawing.Color.Red;
            this.weightError.Location = new System.Drawing.Point(15, 139);
            this.weightError.Name = "weightError";
            this.weightError.Size = new System.Drawing.Size(94, 13);
            this.weightError.TabIndex = 24;
            this.weightError.Text = "Uzupełnij wartości";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listyToolStripMenuItem,
            this.algorytmyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(498, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listyToolStripMenuItem
            // 
            this.listyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaWygenerowanychElementówToolStripMenuItem,
            this.listaPosortowamaCenaWagaToolStripMenuItem,
            this.plecakToolStripMenuItem});
            this.listyToolStripMenuItem.Name = "listyToolStripMenuItem";
            this.listyToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.listyToolStripMenuItem.Text = "Listy";
            // 
            // listaWygenerowanychElementówToolStripMenuItem
            // 
            this.listaWygenerowanychElementówToolStripMenuItem.Name = "listaWygenerowanychElementówToolStripMenuItem";
            this.listaWygenerowanychElementówToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.listaWygenerowanychElementówToolStripMenuItem.Text = "Lista wygenerowanych elementów";
            this.listaWygenerowanychElementówToolStripMenuItem.Click += new System.EventHandler(this.listaWygenerowanychElementówToolStripMenuItem_Click);
            // 
            // listaPosortowamaCenaWagaToolStripMenuItem
            // 
            this.listaPosortowamaCenaWagaToolStripMenuItem.Name = "listaPosortowamaCenaWagaToolStripMenuItem";
            this.listaPosortowamaCenaWagaToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.listaPosortowamaCenaWagaToolStripMenuItem.Text = "Lista posortowama cena / waga";
            this.listaPosortowamaCenaWagaToolStripMenuItem.Click += new System.EventHandler(this.listaPosortowamaCenaWagaToolStripMenuItem_Click);
            // 
            // plecakToolStripMenuItem
            // 
            this.plecakToolStripMenuItem.Name = "plecakToolStripMenuItem";
            this.plecakToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.plecakToolStripMenuItem.Text = "Plecak";
            this.plecakToolStripMenuItem.Click += new System.EventHandler(this.plecakToolStripMenuItem_Click);
            // 
            // algorytmyToolStripMenuItem
            // 
            this.algorytmyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aproksymacyjnyToolStripMenuItem,
            this.zOgraniczeniemElementówToolStripMenuItem});
            this.algorytmyToolStripMenuItem.Name = "algorytmyToolStripMenuItem";
            this.algorytmyToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.algorytmyToolStripMenuItem.Text = "Algorytmy";
            // 
            // aproksymacyjnyToolStripMenuItem
            // 
            this.aproksymacyjnyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zachłannyWagaMinToolStripMenuItem,
            this.zachłannyCenaMaxToolStripMenuItem,
            this.zachłannyCenaWagaToolStripMenuItem});
            this.aproksymacyjnyToolStripMenuItem.Name = "aproksymacyjnyToolStripMenuItem";
            this.aproksymacyjnyToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.aproksymacyjnyToolStripMenuItem.Text = "Bez ograniczeń elementów";
            // 
            // zachłannyWagaMinToolStripMenuItem
            // 
            this.zachłannyWagaMinToolStripMenuItem.Name = "zachłannyWagaMinToolStripMenuItem";
            this.zachłannyWagaMinToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.zachłannyWagaMinToolStripMenuItem.Text = "Zachłanny waga min";
            this.zachłannyWagaMinToolStripMenuItem.Click += new System.EventHandler(this.zachłannyWagaMinToolStripMenuItem_Click);
            // 
            // zachłannyCenaMaxToolStripMenuItem
            // 
            this.zachłannyCenaMaxToolStripMenuItem.Name = "zachłannyCenaMaxToolStripMenuItem";
            this.zachłannyCenaMaxToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.zachłannyCenaMaxToolStripMenuItem.Text = "Zachłanny cena max";
            this.zachłannyCenaMaxToolStripMenuItem.Click += new System.EventHandler(this.zachłannyCenaMaxToolStripMenuItem_Click);
            // 
            // zachłannyCenaWagaToolStripMenuItem
            // 
            this.zachłannyCenaWagaToolStripMenuItem.Name = "zachłannyCenaWagaToolStripMenuItem";
            this.zachłannyCenaWagaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.zachłannyCenaWagaToolStripMenuItem.Text = "zachłanny cena / waga";
            this.zachłannyCenaWagaToolStripMenuItem.Click += new System.EventHandler(this.zachłannyCenaWagaToolStripMenuItem_Click);
            // 
            // zOgraniczeniemElementówToolStripMenuItem
            // 
            this.zOgraniczeniemElementówToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zachłannyWagaMinToolStripMenuItem1,
            this.zachłannyCenaMaxToolStripMenuItem1,
            this.zachłannyCenaWagaToolStripMenuItem1});
            this.zOgraniczeniemElementówToolStripMenuItem.Name = "zOgraniczeniemElementówToolStripMenuItem";
            this.zOgraniczeniemElementówToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.zOgraniczeniemElementówToolStripMenuItem.Text = "Z ograniczeniem elementów";
            // 
            // nMaxCopyOfElement
            // 
            this.nMaxCopyOfElement.Location = new System.Drawing.Point(340, 116);
            this.nMaxCopyOfElement.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nMaxCopyOfElement.Name = "nMaxCopyOfElement";
            this.nMaxCopyOfElement.Size = new System.Drawing.Size(100, 20);
            this.nMaxCopyOfElement.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(340, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Max ilość kopii elementu";
            // 
            // zachłannyWagaMinToolStripMenuItem1
            // 
            this.zachłannyWagaMinToolStripMenuItem1.Name = "zachłannyWagaMinToolStripMenuItem1";
            this.zachłannyWagaMinToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.zachłannyWagaMinToolStripMenuItem1.Text = "Zachłanny waga min";
            this.zachłannyWagaMinToolStripMenuItem1.Click += new System.EventHandler(this.zachłannyWagaMinToolStripMenuItem1_Click);
            // 
            // zachłannyCenaMaxToolStripMenuItem1
            // 
            this.zachłannyCenaMaxToolStripMenuItem1.Name = "zachłannyCenaMaxToolStripMenuItem1";
            this.zachłannyCenaMaxToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.zachłannyCenaMaxToolStripMenuItem1.Text = "Zachłanny cena max";
            this.zachłannyCenaMaxToolStripMenuItem1.Click += new System.EventHandler(this.zachłannyCenaMaxToolStripMenuItem1_Click);
            // 
            // zachłannyCenaWagaToolStripMenuItem1
            // 
            this.zachłannyCenaWagaToolStripMenuItem1.Name = "zachłannyCenaWagaToolStripMenuItem1";
            this.zachłannyCenaWagaToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.zachłannyCenaWagaToolStripMenuItem1.Text = "Zachłanny cena / waga";
            this.zachłannyCenaWagaToolStripMenuItem1.Click += new System.EventHandler(this.zachłannyCenaWagaToolStripMenuItem1_Click);
            // 
            // fError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 341);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nMaxCopyOfElement);
            this.Controls.Add(this.weightError);
            this.Controls.Add(this.priceError);
            this.Controls.Add(this.lError);
            this.Controls.Add(this.nNumberOfElements);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nBackpackSize);
            this.Controls.Add(this.nPriceMax);
            this.Controls.Add(this.nPriceMin);
            this.Controls.Add(this.nWeightMax);
            this.Controls.Add(this.nWeightMin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bWeight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bPrice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fError";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nWeightMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWeightMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPriceMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPriceMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBackpackSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumberOfElements)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxCopyOfElement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bWeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nWeightMin;
        private System.Windows.Forms.NumericUpDown nWeightMax;
        private System.Windows.Forms.NumericUpDown nPriceMin;
        private System.Windows.Forms.NumericUpDown nPriceMax;
        private System.Windows.Forms.NumericUpDown nBackpackSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nNumberOfElements;
        private System.Windows.Forms.Label lError;
        private System.Windows.Forms.Label priceError;
        private System.Windows.Forms.Label weightError;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaWygenerowanychElementówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaPosortowamaCenaWagaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plecakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algorytmyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aproksymacyjnyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zachłannyWagaMinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zachłannyCenaMaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zachłannyCenaWagaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zOgraniczeniemElementówToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nMaxCopyOfElement;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem zachłannyWagaMinToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zachłannyCenaMaxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zachłannyCenaWagaToolStripMenuItem1;
    }
}

