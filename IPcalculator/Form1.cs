using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace IPcalculator
{
    public partial class Form1 : Form
    {
        int[] ip2;
        int[] mask22;
        string[] mask2;

        int[] ip;
        int mask;

        int test = 0b0;
        string networkAddress;
        string ipString = "192.168.100.1";
        public Form1()
        {
            InitializeComponent();
            FillcbMask();
            ip = new int[4];
            ip2 = new int[32];
            mask22 = new int[32];
            mask2 = new string[4];
		}

        void FillcbMask()
        {
            for (int i = 0; i < 32; i++)
            {
                cbMask.Items.Add(i + 1);
            }
            cbMask.SelectedItem = 24;
        }

        void CalculateNetworkAddress()
        {
			networkAddress = "";
			for (int i = 0;i < 4;i++)
            {
                networkAddress += (mask22[i] & ip2[i]).ToString();
			}
        }

        void ConvertMaskToBinaryForm()
        {
            int mask10 = Convert.ToInt32(cbMask.SelectedItem.ToString());

			for (int i = 0; i < 32; i++)
            {
                mask22[i] = mask10-- > 0 ? 1 : 0;
			}
        }

        void ConvertIpToBinaryForm()
        {
			string ipStringInput = "";

            for(int i = 0 ; i < 4; i++)
            {
                ipStringInput += ConvertNumberToBin(ip[i]).ToString();
			}
			for (int i = 0; i < ipStringInput.Length; i++)
			{
                ip2[i] = ipStringInput[i].Equals('1') ? 1 : 0;
			}
		}

		int ConvertNumberToBin(int n)
		{
			int res = 0;
			int p = 1;
			while (n > 0)
			{
				res += p * (n % 2);
				n >>= 1;
				p *= 10;
			}
			return res;
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
            string output = ip[0].ToString() + "." + ip[1].ToString() + "." + ip[2].ToString() + "." + ip[3].ToString() + "\n";
            labelIpInfo.Text = output;
            ConvertIpToBinaryForm();
            ConvertMaskToBinaryForm();

			CalculateNetworkAddress();
            labelIpInfo.Text += ip2[0] + "\n";
            for(int i = 0;i < ip2.Length;i++)
            {
				labelIpInfo.Text += ip2[i];
                if ((i + 1) % 8 == 0) labelIpInfo.Text += " ";
			}
			labelIpInfo.Text += "\n";
			for (int i = 0; i < mask22.Length; i++)
			{
				labelIpInfo.Text += mask22[i];
				if ((i + 1) % 8 == 0) labelIpInfo.Text += " ";
			}
			labelIpInfo.Text += "\n";
            labelIpInfo.Text += "network " +networkAddress;

		}
    }
}
