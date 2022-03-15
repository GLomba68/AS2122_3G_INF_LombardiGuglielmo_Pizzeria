
namespace AS2122_3G_INF_LombardiGuglielmo_Pizzeria
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblQuattroStagioni = new System.Windows.Forms.Label();
            this.lblVerdure = new System.Windows.Forms.Label();
            this.lblMargherita = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtQuantità = new System.Windows.Forms.TextBox();
            this.btnTipo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo di pizza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantità";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Riepilogo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantità pizza margherita";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantità pizza verdure";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantità pizza quattro stagioni";
            // 
            // lblQuattroStagioni
            // 
            this.lblQuattroStagioni.AutoSize = true;
            this.lblQuattroStagioni.Location = new System.Drawing.Point(573, 286);
            this.lblQuattroStagioni.Name = "lblQuattroStagioni";
            this.lblQuattroStagioni.Size = new System.Drawing.Size(12, 15);
            this.lblQuattroStagioni.TabIndex = 8;
            this.lblQuattroStagioni.Text = "/";
            // 
            // lblVerdure
            // 
            this.lblVerdure.AutoSize = true;
            this.lblVerdure.Location = new System.Drawing.Point(573, 250);
            this.lblVerdure.Name = "lblVerdure";
            this.lblVerdure.Size = new System.Drawing.Size(12, 15);
            this.lblVerdure.TabIndex = 7;
            this.lblVerdure.Text = "/";
            // 
            // lblMargherita
            // 
            this.lblMargherita.AutoSize = true;
            this.lblMargherita.Location = new System.Drawing.Point(573, 218);
            this.lblMargherita.Name = "lblMargherita";
            this.lblMargherita.Size = new System.Drawing.Size(12, 15);
            this.lblMargherita.TabIndex = 6;
            this.lblMargherita.Text = "/";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(424, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 124);
            this.listBox1.TabIndex = 9;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Margherita",
            "Verdure",
            "Quattro Stagioni"});
            this.cmbTipo.Location = new System.Drawing.Point(176, 74);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 23);
            this.cmbTipo.TabIndex = 10;
            // 
            // txtQuantità
            // 
            this.txtQuantità.Location = new System.Drawing.Point(176, 215);
            this.txtQuantità.Name = "txtQuantità";
            this.txtQuantità.Size = new System.Drawing.Size(100, 23);
            this.txtQuantità.TabIndex = 11;
            // 
            // btnTipo
            // 
            this.btnTipo.Location = new System.Drawing.Point(303, 74);
            this.btnTipo.Name = "btnTipo";
            this.btnTipo.Size = new System.Drawing.Size(75, 23);
            this.btnTipo.TabIndex = 12;
            this.btnTipo.Text = "button1";
            this.btnTipo.UseVisualStyleBackColor = true;
            this.btnTipo.Click += new System.EventHandler(this.btnTipo_OnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTipo);
            this.Controls.Add(this.txtQuantità);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblQuattroStagioni);
            this.Controls.Add(this.lblVerdure);
            this.Controls.Add(this.lblMargherita);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblQuattroStagioni;
        private System.Windows.Forms.Label lblVerdure;
        private System.Windows.Forms.Label lblMargherita;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtQuantità;
        private System.Windows.Forms.Button btnTipo;
    }
}

