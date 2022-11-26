
namespace YapayZekaTemelleri
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbcase = new System.Windows.Forms.ComboBox();
            this.maskeddate = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcategory = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsellp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbuyp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbrand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.productLst = new System.Windows.Forms.Button();
            this.btnlisten = new System.Windows.Forms.Button();
            this.btnspeak = new System.Windows.Forms.Button();
            this.btnproduct = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbcase);
            this.panel1.Controls.Add(this.maskeddate);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtcategory);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtsellp);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtbuyp);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtstock);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtbrand);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 579);
            this.panel1.TabIndex = 0;
            // 
            // cmbcase
            // 
            this.cmbcase.FormattingEnabled = true;
            this.cmbcase.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmbcase.Location = new System.Drawing.Point(167, 365);
            this.cmbcase.Name = "cmbcase";
            this.cmbcase.Size = new System.Drawing.Size(224, 35);
            this.cmbcase.TabIndex = 17;
            // 
            // maskeddate
            // 
            this.maskeddate.Location = new System.Drawing.Point(167, 325);
            this.maskeddate.Mask = "00/00/0000";
            this.maskeddate.Name = "maskeddate";
            this.maskeddate.Size = new System.Drawing.Size(224, 34);
            this.maskeddate.TabIndex = 16;
            this.maskeddate.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(94, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 27);
            this.label9.TabIndex = 15;
            this.label9.Text = "CASE:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 27);
            this.label8.TabIndex = 13;
            this.label8.Text = "DATE:";
            // 
            // txtcategory
            // 
            this.txtcategory.Location = new System.Drawing.Point(167, 285);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(224, 34);
            this.txtcategory.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 27);
            this.label7.TabIndex = 11;
            this.label7.Text = "CATEGORY:";
            // 
            // txtsellp
            // 
            this.txtsellp.Location = new System.Drawing.Point(167, 245);
            this.txtsellp.Name = "txtsellp";
            this.txtsellp.Size = new System.Drawing.Size(224, 34);
            this.txtsellp.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "SELL PRİCE:";
            // 
            // txtbuyp
            // 
            this.txtbuyp.Location = new System.Drawing.Point(167, 205);
            this.txtbuyp.Name = "txtbuyp";
            this.txtbuyp.Size = new System.Drawing.Size(224, 34);
            this.txtbuyp.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "BUY PRİCE:";
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(167, 165);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(224, 34);
            this.txtstock.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "STOCK:";
            // 
            // txtbrand
            // 
            this.txtbrand.Location = new System.Drawing.Point(167, 125);
            this.txtbrand.Name = "txtbrand";
            this.txtbrand.Size = new System.Drawing.Size(224, 34);
            this.txtbrand.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "BRAND:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(167, 85);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(224, 34);
            this.txtname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCT DETAILS";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.productLst);
            this.panel2.Controls.Add(this.btnlisten);
            this.panel2.Controls.Add(this.btnspeak);
            this.panel2.Controls.Add(this.btnproduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(442, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 104);
            this.panel2.TabIndex = 1;
            // 
            // productLst
            // 
            this.productLst.Location = new System.Drawing.Point(540, 18);
            this.productLst.Name = "productLst";
            this.productLst.Size = new System.Drawing.Size(172, 70);
            this.productLst.TabIndex = 11;
            this.productLst.Text = "PRODUCT LİST";
            this.productLst.UseVisualStyleBackColor = true;
            this.productLst.Click += new System.EventHandler(this.productLst_Click);
            // 
            // btnlisten
            // 
            this.btnlisten.Location = new System.Drawing.Point(362, 18);
            this.btnlisten.Name = "btnlisten";
            this.btnlisten.Size = new System.Drawing.Size(172, 70);
            this.btnlisten.TabIndex = 5;
            this.btnlisten.Text = "LISTEN";
            this.btnlisten.UseVisualStyleBackColor = true;
            this.btnlisten.Click += new System.EventHandler(this.btnlisten_Click);
            // 
            // btnspeak
            // 
            this.btnspeak.Location = new System.Drawing.Point(184, 18);
            this.btnspeak.Name = "btnspeak";
            this.btnspeak.Size = new System.Drawing.Size(172, 70);
            this.btnspeak.TabIndex = 4;
            this.btnspeak.Text = "SPEAK";
            this.btnspeak.UseVisualStyleBackColor = true;
            this.btnspeak.Click += new System.EventHandler(this.btnspeak_Click);
            // 
            // btnproduct
            // 
            this.btnproduct.Location = new System.Drawing.Point(6, 18);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.Size = new System.Drawing.Size(172, 70);
            this.btnproduct.TabIndex = 0;
            this.btnproduct.Text = "PRODUCT ADD";
            this.btnproduct.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(442, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(767, 251);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(767, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.richTextBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(442, 355);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(767, 224);
            this.panel5.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(593, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 27);
            this.label10.TabIndex = 10;
            this.label10.Text = "PLEASE WAIT...";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(587, 217);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 579);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Product add with voice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbcase;
        private System.Windows.Forms.MaskedTextBox maskeddate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsellp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbuyp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnproduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnspeak;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnlisten;
        private System.Windows.Forms.Button productLst;
    }
}

