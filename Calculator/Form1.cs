using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin;

namespace Number_System_Converter
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Pink500, Primary.Pink700, Primary.Pink100, Accent.Purple200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        Double result = 0;
        String opper = "";
        bool oppered = false;

        private void btn_click(object sender, EventArgs e)
        {
       
            if ((DisplayBar.Text == "0") || (oppered))
                DisplayBar.Clear();

            oppered = false;
            Button btn = (Button)sender;
            if (btn.Text == ".")
            {
                if (!DisplayBar.Text.Contains("."))
                {
                    DisplayBar.Text = DisplayBar.Text + btn.Text;
                }
            }
            else
            {
                DisplayBar.Text = DisplayBar.Text + btn.Text;
            }
        }

        private void opper_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            /*if(result != 0)
            {
                btnEQUAL.PerformClick();
                opper = btn.Text;
                label.Text = result + " " + opper;
                oppered = true;
            }
            else
            {*/
                opper = btn.Text;
                result = Double.Parse(DisplayBar.Text);
                label.Text = result + " " + opper;
                oppered = true;
            /*}*/
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            DisplayBar.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            DisplayBar.Text = "0";
            result = 0;
            label.Text = "";
        }

        private void btnEQUAL_Click(object sender, EventArgs e)
        {
            label.Text = "";
            switch(opper)
            {
                case "+":
                    DisplayBar.Text = (result + Double.Parse(DisplayBar.Text)).ToString();         
                    break;

                case "-":
                    DisplayBar.Text = (result - Double.Parse(DisplayBar.Text)).ToString();                   
                    break;

                case "*":
                    DisplayBar.Text = (result * Double.Parse(DisplayBar.Text)).ToString();                    
                    break;

                case "/":
                    DisplayBar.Text = (result / Double.Parse(DisplayBar.Text)).ToString();                   
                    break;

                default:
                    break;
            }
            result = Double.Parse(DisplayBar.Text);
            opper = "";
        }

        private void b_w_CheckedChanged(object sender, EventArgs e)
        {
            if (b_w.Checked)
            {
                b_w.Text = "LIGHT";
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan500, Primary.Cyan700, Primary.Cyan100, Accent.Yellow200, TextShade.WHITE);
            }
            if (!b_w.Checked)
            {
                b_w.Text = "DARK";
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Pink500, Primary.Pink700, Primary.Pink100, Accent.Purple200, TextShade.WHITE);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    digit0.PerformClick();
                    break;   
                case "1":
                    digit1.PerformClick();
                    break;
                case "2":
                    digit2.PerformClick();
                    break;
                case "3":
                    digit3.PerformClick();
                    break;
                case "4":
                    digit4.PerformClick();
                    break;
                case "5":
                    digit5.PerformClick();
                    break;
                case "6":
                    digit6.PerformClick();
                    break;
                case "7":
                    digit7.PerformClick();
                    break;
                case "8":
                    digit8.PerformClick();
                    break;
                case "9":
                    digit9.PerformClick();
                    break;
                case "+":
                    plus.PerformClick();
                    break;
                case "-":
                    minus.PerformClick();
                    break;
                case "*":
                    prod.PerformClick();
                    break;
                case "/":
                    div.PerformClick();
                    break;
                case "=":
                    btnEQUAL.PerformClick();
                    break;
                default:
                    break;
            }           
        }

        private void DisplayBar_click(object sender, EventArgs e)
        {
            MessageBox.Show("Please, don\'t click here");
            label.Focus();
        }

    }
}
