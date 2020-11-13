using System;
using System.Drawing;
using System.Windows.Forms;
using encrypt_decript.functions;
using encrypt_decript.models;



namespace encrypt_decript
{
    public partial class Form1 : Form
    {

        Params param = new Params();
        Decrypt decrypt = new Decrypt();
        Encrypt encrypt = new Encrypt();
        String result = "";

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

   

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtKey.Text.Length != 32)
            {
                label3.Visible = true;
                label3.Text = "key is not a valid size for this algorithm, key = 32 length";
                label3.BackColor = Color.Azure;
            }
            else {
                param.Key = txtKey.Text;
                param.InputString = inputTextPlain.Text;
                result = functions.Encrypt.EncryptString(param.Key, param.InputString);
                outputEncrypt.Text = result;
                label3.Visible = false;
                button2.Visible = false;
            }

     


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtKey.Text.Length != 32 )
            {
                label3.Visible = true;
                label3.Text = "key is not a valid size for this algorithm, key = 32 length";
                label3.BackColor = Color.Azure;
            }
            else {
                param.Key = txtKey.Text;
                param.InputString = inputTextPlain.Text;
                result = functions.Decrypt.DecryptString(param.Key, param.InputString);
                outputEncrypt.Text = result;
                button1.Visible = false;
            }
         

        }
    }
}
