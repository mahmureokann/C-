namespace WFA_McAdan
{
    partial class AdminForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudMenuFiyat = new System.Windows.Forms.NumericUpDown();
            this.nudEkstraFiyat = new System.Windows.Forms.NumericUpDown();
            this.btnMenuOlustur = new System.Windows.Forms.Button();
            this.txtEkstra = new System.Windows.Forms.TextBox();
            this.txtMenu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMenuFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEkstraFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.nudMenuFiyat);
            this.groupBox1.Controls.Add(this.nudEkstraFiyat);
            this.groupBox1.Controls.Add(this.btnMenuOlustur);
            this.groupBox1.Controls.Add(this.txtEkstra);
            this.groupBox1.Controls.Add(this.txtMenu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(59, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 401);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menü Oluşturma Ekranı";
            // 
            // nudMenuFiyat
            // 
            this.nudMenuFiyat.Location = new System.Drawing.Point(324, 86);
            this.nudMenuFiyat.Name = "nudMenuFiyat";
            this.nudMenuFiyat.Size = new System.Drawing.Size(120, 30);
            this.nudMenuFiyat.TabIndex = 3;
            // 
            // nudEkstraFiyat
            // 
            this.nudEkstraFiyat.Location = new System.Drawing.Point(324, 142);
            this.nudEkstraFiyat.Name = "nudEkstraFiyat";
            this.nudEkstraFiyat.Size = new System.Drawing.Size(120, 30);
            this.nudEkstraFiyat.TabIndex = 3;
            // 
            // btnMenuOlustur
            // 
            this.btnMenuOlustur.Location = new System.Drawing.Point(156, 210);
            this.btnMenuOlustur.Name = "btnMenuOlustur";
            this.btnMenuOlustur.Size = new System.Drawing.Size(141, 65);
            this.btnMenuOlustur.TabIndex = 2;
            this.btnMenuOlustur.Text = "Menü Oluştur";
            this.btnMenuOlustur.UseVisualStyleBackColor = true;
            this.btnMenuOlustur.Click += new System.EventHandler(this.btnMenuOlustur_Click);
            // 
            // txtEkstra
            // 
            this.txtEkstra.Location = new System.Drawing.Point(156, 142);
            this.txtEkstra.Name = "txtEkstra";
            this.txtEkstra.Size = new System.Drawing.Size(141, 30);
            this.txtEkstra.TabIndex = 1;
            // 
            // txtMenu
            // 
            this.txtMenu.Location = new System.Drawing.Point(156, 86);
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.Size = new System.Drawing.Size(141, 30);
            this.txtMenu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ekstra:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menü Adı:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 62);
            this.button1.TabIndex = 4;
            this.button1.Text = "Burger Seçim Sayfasına Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMenuFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEkstraFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenuOlustur;
        private System.Windows.Forms.TextBox txtEkstra;
        private System.Windows.Forms.TextBox txtMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMenuFiyat;
        private System.Windows.Forms.NumericUpDown nudEkstraFiyat;
        private System.Windows.Forms.Button button1;
    }
}