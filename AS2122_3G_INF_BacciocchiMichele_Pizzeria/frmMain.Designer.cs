
namespace AS2122_3G_INF_BacciocchiMichele_Pizzeria
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPizza = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantita = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstRiepilogo = new System.Windows.Forms.ListBox();
            this.lblMargherita = new System.Windows.Forms.Label();
            this.lblVerdure = new System.Windows.Forms.Label();
            this.lbl4Stagioni = new System.Windows.Forms.Label();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.lblnum3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo di pizza";
            // 
            // cmbPizza
            // 
            this.cmbPizza.FormattingEnabled = true;
            this.cmbPizza.Items.AddRange(new object[] {
            "Pizza margherita",
            "Pizza con verdure",
            "Pizza 4 stagioni"});
            this.cmbPizza.Location = new System.Drawing.Point(145, 63);
            this.cmbPizza.Name = "cmbPizza";
            this.cmbPizza.Size = new System.Drawing.Size(107, 23);
            this.cmbPizza.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantità";
            // 
            // txtQuantita
            // 
            this.txtQuantita.Location = new System.Drawing.Point(145, 156);
            this.txtQuantita.Name = "txtQuantita";
            this.txtQuantita.Size = new System.Drawing.Size(33, 23);
            this.txtQuantita.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Riepilogo";
            // 
            // lstRiepilogo
            // 
            this.lstRiepilogo.FormattingEnabled = true;
            this.lstRiepilogo.ItemHeight = 15;
            this.lstRiepilogo.Location = new System.Drawing.Point(449, 66);
            this.lstRiepilogo.Name = "lstRiepilogo";
            this.lstRiepilogo.Size = new System.Drawing.Size(170, 139);
            this.lstRiepilogo.TabIndex = 6;
            this.lstRiepilogo.SelectedIndexChanged += new System.EventHandler(this.lstRiepilogo_SelectedIndexChanged);
            // 
            // lblMargherita
            // 
            this.lblMargherita.AutoSize = true;
            this.lblMargherita.Location = new System.Drawing.Point(445, 235);
            this.lblMargherita.Name = "lblMargherita";
            this.lblMargherita.Size = new System.Drawing.Size(100, 15);
            this.lblMargherita.TabIndex = 7;
            this.lblMargherita.Text = "Pizze margherita: ";
            // 
            // lblVerdure
            // 
            this.lblVerdure.AutoSize = true;
            this.lblVerdure.Location = new System.Drawing.Point(449, 272);
            this.lblVerdure.Name = "lblVerdure";
            this.lblVerdure.Size = new System.Drawing.Size(105, 15);
            this.lblVerdure.TabIndex = 8;
            this.lblVerdure.Text = "Pizza con verdure: ";
            // 
            // lbl4Stagioni
            // 
            this.lbl4Stagioni.AutoSize = true;
            this.lbl4Stagioni.Location = new System.Drawing.Point(449, 304);
            this.lbl4Stagioni.Name = "lbl4Stagioni";
            this.lbl4Stagioni.Size = new System.Drawing.Size(126, 15);
            this.lbl4Stagioni.TabIndex = 9;
            this.lbl4Stagioni.Text = "Pizza quattro stagioni: ";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(277, 63);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(113, 26);
            this.btnAggiungi.TabIndex = 10;
            this.btnAggiungi.Text = "Aggiungi ordine";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(537, 235);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(13, 15);
            this.lblnum1.TabIndex = 11;
            this.lblnum1.Text = "0";
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(547, 272);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(13, 15);
            this.lblnum2.TabIndex = 12;
            this.lblnum2.Text = "0";
            this.lblnum2.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblnum3
            // 
            this.lblnum3.AutoSize = true;
            this.lblnum3.Location = new System.Drawing.Point(569, 304);
            this.lblnum3.Name = "lblnum3";
            this.lblnum3.Size = new System.Drawing.Size(13, 15);
            this.lblnum3.TabIndex = 13;
            this.lblnum3.Text = "0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 397);
            this.Controls.Add(this.lblnum3);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum1);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.lbl4Stagioni);
            this.Controls.Add(this.lblVerdure);
            this.Controls.Add(this.lblMargherita);
            this.Controls.Add(this.lstRiepilogo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuantita);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPizza);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "3G Lab 2.3 Bacciocchi Michele Pizzeria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPizza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstRiepilogo;
        private System.Windows.Forms.Label lblMargherita;
        private System.Windows.Forms.Label lblVerdure;
        private System.Windows.Forms.Label lbl4Stagioni;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.Label lblnum3;
    }
}

