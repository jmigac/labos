namespace Kolegiji
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
            this.components = new System.ComponentModel.Container();
            this.TxtNazivKolegija = new System.Windows.Forms.TextBox();
            this.LabelKolegij = new System.Windows.Forms.Label();
            this.LabelDodjela = new System.Windows.Forms.Label();
            this.BtnUnosKolegija = new System.Windows.Forms.Button();
            this.TxtDodjelaNaziv = new System.Windows.Forms.TextBox();
            this.TxtOcjena = new System.Windows.Forms.TextBox();
            this.LabelOcjena = new System.Windows.Forms.Label();
            this.BtnUnosOcjene = new System.Windows.Forms.Button();
            this.ListaPopisSvihKolegija = new System.Windows.Forms.ListBox();
            this.LabelNajbolji = new System.Windows.Forms.Label();
            this.LabelNajlosiji = new System.Windows.Forms.Label();
            this.IspisOcjena = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TxtNazivKolegija
            // 
            this.TxtNazivKolegija.Location = new System.Drawing.Point(13, 29);
            this.TxtNazivKolegija.Name = "TxtNazivKolegija";
            this.TxtNazivKolegija.Size = new System.Drawing.Size(152, 20);
            this.TxtNazivKolegija.TabIndex = 0;
            // 
            // LabelKolegij
            // 
            this.LabelKolegij.AutoSize = true;
            this.LabelKolegij.Location = new System.Drawing.Point(13, 10);
            this.LabelKolegij.Name = "LabelKolegij";
            this.LabelKolegij.Size = new System.Drawing.Size(76, 13);
            this.LabelKolegij.TabIndex = 1;
            this.LabelKolegij.Text = "Naziv kolegija:";
            // 
            // LabelDodjela
            // 
            this.LabelDodjela.AutoSize = true;
            this.LabelDodjela.Location = new System.Drawing.Point(10, 82);
            this.LabelDodjela.Name = "LabelDodjela";
            this.LabelDodjela.Size = new System.Drawing.Size(76, 13);
            this.LabelDodjela.TabIndex = 2;
            this.LabelDodjela.Text = "Naziv kolegija:";
            // 
            // BtnUnosKolegija
            // 
            this.BtnUnosKolegija.Location = new System.Drawing.Point(13, 56);
            this.BtnUnosKolegija.Name = "BtnUnosKolegija";
            this.BtnUnosKolegija.Size = new System.Drawing.Size(152, 23);
            this.BtnUnosKolegija.TabIndex = 3;
            this.BtnUnosKolegija.Text = "Unesi";
            this.BtnUnosKolegija.UseVisualStyleBackColor = true;
            this.BtnUnosKolegija.Click += new System.EventHandler(this.BtnUnosKolegija_Click);
            // 
            // TxtDodjelaNaziv
            // 
            this.TxtDodjelaNaziv.Location = new System.Drawing.Point(13, 101);
            this.TxtDodjelaNaziv.Name = "TxtDodjelaNaziv";
            this.TxtDodjelaNaziv.Size = new System.Drawing.Size(152, 20);
            this.TxtDodjelaNaziv.TabIndex = 0;
            // 
            // TxtOcjena
            // 
            this.TxtOcjena.Location = new System.Drawing.Point(13, 144);
            this.TxtOcjena.MaxLength = 1;
            this.TxtOcjena.Name = "TxtOcjena";
            this.TxtOcjena.Size = new System.Drawing.Size(152, 20);
            this.TxtOcjena.TabIndex = 4;
            // 
            // LabelOcjena
            // 
            this.LabelOcjena.AutoSize = true;
            this.LabelOcjena.Location = new System.Drawing.Point(10, 123);
            this.LabelOcjena.Name = "LabelOcjena";
            this.LabelOcjena.Size = new System.Drawing.Size(44, 13);
            this.LabelOcjena.TabIndex = 2;
            this.LabelOcjena.Text = "Ocjena:";
            // 
            // BtnUnosOcjene
            // 
            this.BtnUnosOcjene.Location = new System.Drawing.Point(13, 170);
            this.BtnUnosOcjene.Name = "BtnUnosOcjene";
            this.BtnUnosOcjene.Size = new System.Drawing.Size(152, 23);
            this.BtnUnosOcjene.TabIndex = 5;
            this.BtnUnosOcjene.Text = "UnesiOcjenu";
            this.BtnUnosOcjene.UseVisualStyleBackColor = true;
            this.BtnUnosOcjene.Click += new System.EventHandler(this.BtnUnosOcjene_Click);
            // 
            // ListaPopisSvihKolegija
            // 
            this.ListaPopisSvihKolegija.FormattingEnabled = true;
            this.ListaPopisSvihKolegija.Location = new System.Drawing.Point(179, 10);
            this.ListaPopisSvihKolegija.Name = "ListaPopisSvihKolegija";
            this.ListaPopisSvihKolegija.Size = new System.Drawing.Size(142, 186);
            this.ListaPopisSvihKolegija.TabIndex = 6;
            // 
            // LabelNajbolji
            // 
            this.LabelNajbolji.AutoSize = true;
            this.LabelNajbolji.Location = new System.Drawing.Point(328, 9);
            this.LabelNajbolji.Name = "LabelNajbolji";
            this.LabelNajbolji.Size = new System.Drawing.Size(88, 13);
            this.LabelNajbolji.TabIndex = 7;
            this.LabelNajbolji.Text = "Najbolji kolegij je:";
            // 
            // LabelNajlosiji
            // 
            this.LabelNajlosiji.AutoSize = true;
            this.LabelNajlosiji.Location = new System.Drawing.Point(328, 29);
            this.LabelNajlosiji.Name = "LabelNajlosiji";
            this.LabelNajlosiji.Size = new System.Drawing.Size(89, 13);
            this.LabelNajlosiji.TabIndex = 7;
            this.LabelNajlosiji.Text = "Najlošiji kolegij je:";
            // 
            // IspisOcjena
            // 
            this.IspisOcjena.Enabled = true;
            this.IspisOcjena.Interval = 2500;
            this.IspisOcjena.Tick += new System.EventHandler(this.IspisOcjena_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 202);
            this.Controls.Add(this.LabelNajlosiji);
            this.Controls.Add(this.LabelNajbolji);
            this.Controls.Add(this.ListaPopisSvihKolegija);
            this.Controls.Add(this.BtnUnosOcjene);
            this.Controls.Add(this.TxtOcjena);
            this.Controls.Add(this.BtnUnosKolegija);
            this.Controls.Add(this.LabelOcjena);
            this.Controls.Add(this.LabelDodjela);
            this.Controls.Add(this.LabelKolegij);
            this.Controls.Add(this.TxtDodjelaNaziv);
            this.Controls.Add(this.TxtNazivKolegija);
            this.Name = "Form1";
            this.Text = "Pregled kolegija korisnika";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNazivKolegija;
        private System.Windows.Forms.Label LabelKolegij;
        private System.Windows.Forms.Label LabelDodjela;
        private System.Windows.Forms.Button BtnUnosKolegija;
        private System.Windows.Forms.TextBox TxtDodjelaNaziv;
        private System.Windows.Forms.TextBox TxtOcjena;
        private System.Windows.Forms.Label LabelOcjena;
        private System.Windows.Forms.Button BtnUnosOcjene;
        private System.Windows.Forms.ListBox ListaPopisSvihKolegija;
        private System.Windows.Forms.Label LabelNajbolji;
        private System.Windows.Forms.Label LabelNajlosiji;
        private System.Windows.Forms.Timer IspisOcjena;
    }
}

