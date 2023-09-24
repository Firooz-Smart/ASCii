using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASCII_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtdecimal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txthex.Text = Convert.ToString(long.Parse(txtdecimal.Text), 16);
                txtbinary.Text = BinaryOctalHexTable.toBinary(long.Parse(txtdecimal.Text));
                txtoctal.Text = Convert.ToString(long.Parse(txtdecimal.Text), 8);
                txtbase4.Text = BinaryOctalHexTable.to4(long.Parse(txtdecimal.Text));
              
            }
            catch
            {
                txtdecimal.Text = "";
                txtoctal.Text = "";
                txtbase4.Text = "";
                txthex.Text = "";
                txtbinary.Text = "";
            }
        }


        private void Binary_Click(object sender, EventArgs e)
        {

        }

        private void txtbinary_TextChanged(object sender, EventArgs e)
        {
            try { 
            long bin = long.Parse(txtbinary.Text);


            if (BinaryOctalHexTable.isValidate(bin, 2))
            {
                long dec = BinaryOctalHexTable.toDecimal(bin, 2);
                txtdecimal.Text = Convert.ToString(dec);
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "Not in base 2 !";
            }
        }
            catch
            {
                txtdecimal.Text = "";
                txtoctal.Text = "";
                txtbinary.Text = "";
                txtbase4.Text = "";
                txthex.Text = "";
            }

}

        private void txtbase4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                long base4 = long.Parse(txtbase4.Text);


                if (BinaryOctalHexTable.isValidate(base4, 4))
                {
                    long dec = BinaryOctalHexTable.toDecimal(base4, 4);
                    txtdecimal.Text = Convert.ToString(dec);
                   
                    lblError.Text = "";
                }
                else
                {
                    lblError.Text = "Not in base 4 !";
                }
            }
            catch
            {
                txtdecimal.Text = "";
                txtoctal.Text = "";
                txtbinary.Text = "";
                txtbase4.Text = "";
                txthex.Text = "";
            }

        }

        private void txtoctal_TextChanged(object sender, EventArgs e)
        {

            try
            {
                long base8 = long.Parse(txtoctal.Text);


                if (BinaryOctalHexTable.isValidate(base8, 8))
                {
                    long dec = BinaryOctalHexTable.toDecimal(base8, 8);
                    txtdecimal.Text = Convert.ToString(dec);
           
                    lblError.Text = "";
                }
                else
                {
                    lblError.Text = "Not in base 8 !";
                }
            }
            catch
            {
                txtdecimal.Text = "";
                txtoctal.Text = "";
                txtbinary.Text = "";
                txtbase4.Text = "";
                txthex.Text = "";
            }
        }

        private void txthex_TextChanged(object sender, EventArgs e)
        {
            String base16="";
                try
              { 
                base16 = (txthex.Text);
               }
            catch
            {
                txtdecimal.Text = "";
                txtoctal.Text = "";
                txtbinary.Text = "";
                txtbase4.Text = "";
                txthex.Text = "";
            }

         
              
                    long dec = BinaryOctalHexTable.hexaToDecimal(base16);
                    txtdecimal.Text = Convert.ToString(dec);
                
                
                
     

    }
    }
    }


