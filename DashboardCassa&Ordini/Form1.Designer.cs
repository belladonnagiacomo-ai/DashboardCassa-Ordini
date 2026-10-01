namespace DashboardCassa_Ordini
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtArticolo = new TextBox();
            descr = new Label();
            prezzo = new Label();
            numProdotti = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lista = new ListBox();
            listaS = new Label();
            aggiungi = new Button();
            rimuovi = new Button();
            label1 = new Label();
            risultato = new Label();
            scontrino = new Button();
            SuspendLayout();
            // 
            // txtArticolo
            // 
            txtArticolo.Location = new Point(42, 137);
            txtArticolo.Name = "txtArticolo";
            txtArticolo.Size = new Size(141, 27);
            txtArticolo.TabIndex = 0;
            // 
            // descr
            // 
            descr.AutoSize = true;
            descr.Location = new Point(42, 114);
            descr.Name = "descr";
            descr.Size = new Size(141, 20);
            descr.TabIndex = 1;
            descr.Text = "Descrizione articolo";
            // 
            // prezzo
            // 
            prezzo.AutoSize = true;
            prezzo.Location = new Point(42, 182);
            prezzo.Name = "prezzo";
            prezzo.Size = new Size(53, 20);
            prezzo.TabIndex = 2;
            prezzo.Text = "Prezzo";
            // 
            // numProdotti
            // 
            numProdotti.AutoSize = true;
            numProdotti.Location = new Point(169, 182);
            numProdotti.Name = "numProdotti";
            numProdotti.Size = new Size(66, 20);
            numProdotti.TabIndex = 3;
            numProdotti.Text = "Quantità";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 205);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(86, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(169, 205);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(97, 27);
            textBox2.TabIndex = 5;
            // 
            // lista
            // 
            lista.FormattingEnabled = true;
            lista.Location = new Point(321, 137);
            lista.Name = "lista";
            lista.Size = new Size(293, 224);
            lista.TabIndex = 6;
            lista.SelectedIndexChanged += lista_SelectedIndexChanged;
            // 
            // listaS
            // 
            listaS.AutoSize = true;
            listaS.Location = new Point(321, 114);
            listaS.Name = "listaS";
            listaS.Size = new Size(80, 20);
            listaS.TabIndex = 7;
            listaS.Text = "Lista spesa";
            // 
            // aggiungi
            // 
            aggiungi.Location = new Point(42, 268);
            aggiungi.Name = "aggiungi";
            aggiungi.Size = new Size(224, 29);
            aggiungi.TabIndex = 8;
            aggiungi.Text = "+ Aggiungi voce";
            aggiungi.UseVisualStyleBackColor = true;
            // 
            // rimuovi
            // 
            rimuovi.Location = new Point(42, 332);
            rimuovi.Name = "rimuovi";
            rimuovi.Size = new Size(224, 29);
            rimuovi.TabIndex = 9;
            rimuovi.Text = "Rimuovi selezionato";
            rimuovi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 440);
            label1.Name = "label1";
            label1.Size = new Size(172, 20);
            label1.TabIndex = 10;
            label1.Text = "Totale da dare alla cassa";
            // 
            // risultato
            // 
            risultato.AutoSize = true;
            risultato.Location = new Point(45, 480);
            risultato.Name = "risultato";
            risultato.Size = new Size(0, 20);
            risultato.TabIndex = 11;
            // 
            // scontrino
            // 
            scontrino.Location = new Point(321, 431);
            scontrino.Name = "scontrino";
            scontrino.Size = new Size(293, 29);
            scontrino.TabIndex = 12;
            scontrino.Text = "Emetti scontrino";
            scontrino.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1433, 742);
            Controls.Add(scontrino);
            Controls.Add(risultato);
            Controls.Add(label1);
            Controls.Add(rimuovi);
            Controls.Add(aggiungi);
            Controls.Add(listaS);
            Controls.Add(lista);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(numProdotti);
            Controls.Add(prezzo);
            Controls.Add(descr);
            Controls.Add(txtArticolo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtArticolo;
        private Label descr;
        private Label prezzo;
        private Label numProdotti;
        private TextBox textBox1;
        private TextBox textBox2;
        private ListBox lista;
        private Label listaS;
        private Button aggiungi;
        private Button rimuovi;
        private Label label1;
        private Label risultato;
        private Button scontrino;
    }
}
