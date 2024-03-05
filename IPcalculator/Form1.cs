using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPcalculator
{
    public partial class Form1 : Form
    {
        int[] ip;
        int mask;
        string ipString = "192.168.100.0";
        public Form1()
        {
            InitializeComponent();
            FillcbMask();
            ip = new int[4];
        }

        void FillcbMask()
        {
            for (int i = 0; i < 32; i++)
            {
                cbMask.Items.Add(i + 1);
            }
            cbMask.SelectedItem = 24;
        }

        void ConvertMaskToBinaryForm()
        {
            string maskString = "";
            for(int i = 0;i < 32;i++)
            {
                maskString += i < Convert.ToInt32(cbMask.SelectedItem.ToString()) ? 1 : 0;
            }
        }

        void ConvertIpToBinaryForm()
        {
            string ipStringInput = ipString;
            for (int i = 0; i < ipStringInput.Length; i++)
            {
                //maskString += i < Convert.ToInt32(cbMask.SelectedItem.ToString()) ? 1 : 0;
            }
        }

        void ConvertIpToDecimalForm()
        {
            string ipStringInput = ipString; 
            for(int i = 0; i < 4; i++)
            {
                ip[i] = Convert.ToInt32(ipStringInput.Split('.')[i]);
            }
        }

        void Calculate()
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ConvertIpToDecimalForm();
            string output = ip[0].ToString() + ip[1].ToString() + ip[2].ToString() + ip[3].ToString(); ;
            labelIpInfo.Text = output;
        }
    }
}
