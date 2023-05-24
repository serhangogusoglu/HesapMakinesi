using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {

        private char _islem;
        private  bool _ekranTemizlenecekMi;
        private int _ilkSayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void rakam1Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel1.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel1.Text == "0")
            {
                ekranLabel1.Text = " ";
            }
            ekranLabel1.Text = ekranLabel1.Text + "1";

        }

        private void rakam2Button_Click(object sender, EventArgs e)
        {

            if (_ekranTemizlenecekMi)
            {
                ekranLabel1.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel1.Text == "0")
            {
                ekranLabel1.Text = " ";
            }
            ekranLabel1.Text = ekranLabel1.Text + "2";

        }

        private void rakam3Button_Click(object sender, EventArgs e)
        {

            if (_ekranTemizlenecekMi)
            {
                ekranLabel1.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel1.Text == "0")
            {
                ekranLabel1.Text = " ";
            }
            ekranLabel1.Text = ekranLabel1.Text + "3";

        }

        private void rakam4Button_Click(object sender, EventArgs e)
        {

            if (_ekranTemizlenecekMi)
            {
                ekranLabel1.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel1.Text == "0")
            {
                ekranLabel1.Text = " ";
            }
            ekranLabel1.Text = ekranLabel1.Text + "4";

        }

        private void rakam5Button_Click(object sender, EventArgs e)
        {

            if (_ekranTemizlenecekMi)
            {
                ekranLabel1.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel1.Text == "0")
            {
                ekranLabel1.Text = " ";
            }
            ekranLabel1.Text = ekranLabel1.Text + "5";

        }

        private void rakam6Button_Click(object sender, EventArgs e)
        {

            if (_ekranTemizlenecekMi)
            {
                ekranLabel1.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel1.Text == "0")
            {
                ekranLabel1.Text = " ";
            }
            ekranLabel1.Text = ekranLabel1.Text + "6";
        }

        private void rakam7Button_Click(object sender, EventArgs e)
        {

            if (_ekranTemizlenecekMi)
            {
                ekranLabel1.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel1.Text == "0")
            {
                ekranLabel1.Text = " ";
            }
            ekranLabel1.Text = ekranLabel1.Text + "7";
        }

        private void rakam8Button_Click(object sender, EventArgs e)
        {

            if (_ekranTemizlenecekMi)
            {
                ekranLabel1.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel1.Text == "0")
            {
                ekranLabel1.Text = " ";
            }
            ekranLabel1.Text = ekranLabel1.Text + "8";
        }

        private void rakam9Button_Click(object sender, EventArgs e)
        {

            if (_ekranTemizlenecekMi)
            {
                ekranLabel1.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel1.Text == "0")
            {
                ekranLabel1.Text = " ";
            }
            ekranLabel1.Text = ekranLabel1.Text + "9";
        }

        private void rakam0Button_Click(object sender, EventArgs e)
        {

            if (_ekranTemizlenecekMi)
            {
                ekranLabel1.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel1.Text == "0")
            {
                ekranLabel1.Text = " ";
            }
            ekranLabel1.Text = ekranLabel1.Text + "0";
        }

        private void toplamaButton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel1.Text);

        }

        private void esittirButton_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(ekranLabel1.Text);
            int sonuc;
            switch (_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilkSayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilkSayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilkSayi / ikinciSayi;
                    break;
                default:
                    sonuc=0;
                    break;
            }
            ekranLabel1.Text = Convert.ToString(sonuc);
            }

        private void cıkarmaButton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel1.Text);
        }

        private void carpmaButton_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel1.Text);
        }

        private void bolmeButton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel1.Text);
        }

        private void cbutton_Click(object sender, EventArgs e)
        {
            ekranLabel1.Text = "0";
        }
    }
    }

