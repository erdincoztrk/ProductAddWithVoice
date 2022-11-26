using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;
using System.Speech.Recognition;
namespace YapayZekaTemelleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void productlist()
        {
            var products = db.table_product.ToList();
            dataGridView1.DataSource = products;
        }
        machineEntities db = new machineEntities();
        
        void enabled()
        {
            txtname.Enabled = false;
            txtbrand.Enabled = false;
            txtbuyp.Enabled = false;
            txtsellp.Enabled = false;
            txtcategory.Enabled = false;
            maskeddate.Enabled = false;
            cmbcase.Enabled = false;
            txtstock.Enabled = false;
        }
        void colormethod()
        {
            txtname.BackColor = Color.White;
            txtbrand.BackColor = Color.White;
            txtbuyp.BackColor = Color.White;
            txtsellp.BackColor = Color.White;
            txtcategory.BackColor = Color.White;
            txtstock.BackColor = Color.White;
            maskeddate.BackColor = Color.White;
            cmbcase.BackColor = Color.White;
        }
        private void btnspeak_Click(object sender, EventArgs e)
        {
            SpeechRecognitionEngine sr = new SpeechRecognitionEngine();
            Grammar g = new DictationGrammar();
            sr.LoadGrammar(g);
            try
            {
                btnspeak.Text = "PLEASE SPEAK";
                sr.SetInputToDefaultAudioDevice();
                RecognitionResult res = sr.Recognize();
                richTextBox1.Text = res.Text;
            }
            catch (Exception)
            {

                btnspeak.Text = "ERROR! TRY AGAIN";
            }
        }

        private void btnlisten_Click(object sender, EventArgs e)
        {
            SpVoice voice = new SpVoice();
            voice.Speak(richTextBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            enabled();
            colormethod();
        }

        private void productLst_Click(object sender, EventArgs e)
        {
            productlist();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Enabled == true && txtname.BackColor == Color.LightGray)
                {
                    txtname.Text = richTextBox1.Text;
                    enabled();
                    colormethod();
                }
                if(txtbrand.Enabled == true && txtbrand.BackColor == Color.LightGray)
                {
                    txtbrand.Text = richTextBox1.Text;
                    enabled();
                    colormethod();
                }
                if(txtbuyp.Enabled == true && txtbuyp.BackColor == Color.LightGray)
                {
                    txtbuyp.Text = richTextBox1.Text;
                    enabled();
                    colormethod();
                }
                if(txtsellp.Enabled == true && txtsellp.BackColor == Color.LightGray)
                {
                    txtsellp.Text = richTextBox1.Text;
                    enabled();
                    colormethod();
                }
                if(txtstock.Enabled == true && txtstock.BackColor == Color.LightGray)
                {
                    txtstock.Text = richTextBox1.Text;
                    enabled();
                    colormethod();
                }
                if(txtcategory.Enabled == true && txtcategory.BackColor == Color.LightGray)
                {
                    txtcategory.Text = richTextBox1.Text;
                    enabled();
                    colormethod();
                }
                if(maskeddate.Enabled == true && maskeddate.BackColor == Color.LightGray)
                {
                    maskeddate.Text = DateTime.Now.ToShortDateString();
                    enabled();
                    colormethod();
                }
                if(cmbcase.Enabled == true && cmbcase.BackColor == Color.LightGray)
                {
                    cmbcase.Text = richTextBox1.Text;
                    enabled();
                    colormethod();
                }

        //-------------******************************************************************************************************************************
                if (richTextBox1.Text == "Product list" || richTextBox1.Text == "Products list" || richTextBox1.Text == "List of products" || richTextBox1.Text == "I")
                {
                    productlist();
                    
                }
                else
                {
                    dataGridView1.DataSource = "";
                }
            //****************************************************************************
            if(richTextBox1.Text == "Product add")
                {
                    table_product t = new table_product();
                    t.name = txtname.Text;
                    t.brand = txtbrand.Text;
                    t.stock = short.Parse(txtstock.Text);
                    t.buyprice = decimal.Parse(txtbuyp.Text);
                    t.sellprice = decimal.Parse(txtsellp.Text);
                    t.category = txtcategory.Text;
                    t.dateaddpro = DateTime.Parse(maskeddate.Text);
                    t.productcase = bool.Parse(cmbcase.Text);
                    db.table_product.Add(t);
                    db.SaveChanges();
                    MessageBox.Show("PRODUCT SAVED");


                    
                }
            //****************************************************************************
                if (richTextBox1.Text == "Name")
                {
                    
                    txtname.Focus();
                    txtname.Enabled = true;
                    txtname.BackColor = Color.LightGray;
                    richTextBox1.Clear();
                    
                }
                if (richTextBox1.Text == "Brand")
                {
                    txtbrand.Focus();
                    txtbrand.Enabled = true;
                    txtbrand.BackColor = Color.LightGray;
                    richTextBox1.Clear();
                }
                if (richTextBox1.Text == "Stock")
                {
                    txtstock.Focus();
                    txtstock.Enabled = true;
                    txtstock.BackColor = Color.LightGray;
                    richTextBox1.Clear();
                }
                if (richTextBox1.Text == "Buy price")
                {txtbuyp.Focus();
                    txtbuyp.Enabled = true;
                    txtbuyp.BackColor = Color.LightGray;
                    richTextBox1.Clear();
                }
                if (richTextBox1.Text == "Sell price")
                {txtsellp.Focus();
                    txtsellp.Enabled = true;
                    txtsellp.BackColor = Color.LightGray;
                    richTextBox1.Clear();
                }
                if (richTextBox1.Text == "Category")
                {txtcategory.Focus();
                    txtcategory.Enabled = true;
                    txtcategory.BackColor = Color.LightGray;
                    richTextBox1.Clear();
                }
                if (richTextBox1.Text == "Date")
                {maskeddate.Focus();
                    maskeddate.Enabled = true;
                    maskeddate.BackColor = Color.LightGray;
                    richTextBox1.Clear();
                }
                if (richTextBox1.Text == "Case")
                {
                    cmbcase.Focus();
                    cmbcase.SelectedIndex = 0;
                    cmbcase.Enabled = true;
                    cmbcase.BackColor = Color.LightGray;
                    richTextBox1.Clear();
                    
                }
                if(richTextBox1.Text.Contains("Exit") || richTextBox1.Text.Contains("exit"))
                {
                   DialogResult = MessageBox.Show("ÇIKMAK İSTEDİĞİNİZE EMİN MİSİNİZ?", "UYARI", MessageBoxButtons.YesNo);
                    if(DialogResult == DialogResult.Yes)
                    {
                        this.Close();
                    }
                    else
                    {
                        richTextBox1.Clear();                       
                    }
                }

                
            }
            catch (Exception)
            {

                MessageBox.Show("HATA");
            }
            
        }

        
    }
}
