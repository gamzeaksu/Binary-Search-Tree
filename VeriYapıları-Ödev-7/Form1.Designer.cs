namespace VeriYapıları_Ödev_7
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtBul = new System.Windows.Forms.TextBox();
            this.txtEkle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLevel = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtSil = new System.Windows.Forms.TextBox();
            this.txtSonuc = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(43, 45);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(300, 488);
            this.listBox1.TabIndex = 0;
            // 
            // btnPre
            // 
            this.btnPre.BackColor = System.Drawing.Color.LightGreen;
            this.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPre.Location = new System.Drawing.Point(380, 54);
            this.btnPre.Margin = new System.Windows.Forms.Padding(4);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(136, 32);
            this.btnPre.TabIndex = 1;
            this.btnPre.Text = "Pre-Order";
            this.btnPre.UseVisualStyleBackColor = false;
            this.btnPre.Click += new System.EventHandler(this.BtnPre_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.LightGreen;
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIn.Location = new System.Drawing.Point(380, 103);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(136, 32);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "In-Order";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.BtnIn_Click);
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.Color.LightGreen;
            this.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPost.Location = new System.Drawing.Point(380, 152);
            this.btnPost.Margin = new System.Windows.Forms.Padding(4);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(136, 32);
            this.btnPost.TabIndex = 3;
            this.btnPost.Text = "Post-Order";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.BtnPost_Click);
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.Color.LightGreen;
            this.btnBul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBul.Location = new System.Drawing.Point(395, 373);
            this.btnBul.Margin = new System.Windows.Forms.Padding(4);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(103, 32);
            this.btnBul.TabIndex = 4;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.BtnBul_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.LightGreen;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Location = new System.Drawing.Point(395, 288);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(103, 32);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // txtBul
            // 
            this.txtBul.Location = new System.Drawing.Point(380, 337);
            this.txtBul.Margin = new System.Windows.Forms.Padding(4);
            this.txtBul.Name = "txtBul";
            this.txtBul.Size = new System.Drawing.Size(136, 28);
            this.txtBul.TabIndex = 6;
            // 
            // txtEkle
            // 
            this.txtEkle.Location = new System.Drawing.Point(380, 252);
            this.txtEkle.Margin = new System.Windows.Forms.Padding(4);
            this.txtEkle.Name = "txtEkle";
            this.txtEkle.Size = new System.Drawing.Size(136, 28);
            this.txtEkle.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 557);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sonuç : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 604);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 48);
            this.label2.TabIndex = 11;
            this.label2.Text = "Gamze Aksu\r\n171180005";
            // 
            // btnLevel
            // 
            this.btnLevel.BackColor = System.Drawing.Color.LightGreen;
            this.btnLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLevel.Location = new System.Drawing.Point(380, 201);
            this.btnLevel.Margin = new System.Windows.Forms.Padding(4);
            this.btnLevel.Name = "btnLevel";
            this.btnLevel.Size = new System.Drawing.Size(136, 32);
            this.btnLevel.TabIndex = 13;
            this.btnLevel.Text = "Level-Order";
            this.btnLevel.UseVisualStyleBackColor = false;
            this.btnLevel.Click += new System.EventHandler(this.BtnLevel_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.LightGreen;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Location = new System.Drawing.Point(395, 466);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(103, 36);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // txtSil
            // 
            this.txtSil.Location = new System.Drawing.Point(380, 423);
            this.txtSil.Name = "txtSil";
            this.txtSil.Size = new System.Drawing.Size(136, 28);
            this.txtSil.TabIndex = 19;
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(118, 540);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(225, 142);
            this.txtSonuc.TabIndex = 21;
            this.txtSonuc.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(638, 694);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.txtSil);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEkle);
            this.Controls.Add(this.txtBul);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtBul;
        private System.Windows.Forms.TextBox txtEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLevel;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtSil;
        private System.Windows.Forms.RichTextBox txtSonuc;
    }
}

