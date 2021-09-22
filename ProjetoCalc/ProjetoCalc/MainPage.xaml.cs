using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjetoCalc
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        double v1;
        double v2;
        private void BtCe(object sender, EventArgs e)
        {
            lb1.Text = "";
        }

        private void BtC(object sender, EventArgs e)
        {

        }

        private void Bt7(object sender, EventArgs e)
        {
            lb1.Text += "7";
            //v1 = double.Parse()
        }

        private void Bt8(object sender, EventArgs e)
        {
            lb1.Text += "8";
        }

        private void BtBack(object sender, EventArgs e)
        {

        }

        private void Bt9(object sender, EventArgs e)
        {
            lb1.Text += "9";
        }

        private void BtSoma(object sender, EventArgs e)
        {
            lb1.Text += "+";
        }

        private void Bt4(object sender, EventArgs e)
        {
            lb1.Text += "4";
        }

        private void Bt5(object sender, EventArgs e)
        {
            lb1.Text += "5";
        }

        private void Bt6(object sender, EventArgs e)
        {
            lb1.Text += "6";
        }

        private void BtSub(object sender, EventArgs e)
        {
            lb1.Text += "-";
        }

        private void BtMult(object sender, EventArgs e)
        {
            lb1.Text += "*";
        }

        private void Bt1(object sender, EventArgs e)
        {
            lb1.Text += "1";
        }

        private void Bt2(object sender, EventArgs e)
        {
            lb1.Text += "2";
        }

        private void Bt3(object sender, EventArgs e)
        {
            lb1.Text += "3";
        }

        private void Bt0(object sender, EventArgs e)
        {
            lb1.Text += "0";
        }

        private void BtIgual(object sender, EventArgs e)
        {
            lb1.Text += "=";
        }

        private void BtDiv(object sender, EventArgs e)
        {
            lb1.Text += "/";
        }
    }
}
