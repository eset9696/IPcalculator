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
        int[,] ip2;
        int[,] mask2;

        int[] ip;
        int mask;

        int test = 0b0;
        //string networkAddress;
        int[,] networkAddress2;
        int[] networkAddress;
        string ipString = "192.168.100.1";
        public Form1()
        {
            InitializeComponent();
            FillcbMask();
            ip = new int[4];
            ip2 = new int[4, 8];
            mask2 = new int[4, 8];
            networkAddress2 = new int[4, 8];
            networkAddress = new int[4];
		}

        void FillcbMask()
        {
            for (int i = 0; i < 32; i++)
            {
                cbMask.Items.Add(i + 1);
            }
            cbMask.SelectedItem = 24;
        }

        void Print(int[,] array)
        {
            for(int i = 0;i < 4;i++)
            {
                for(int j = 0; j < 8;j++)
                {
                    labelIpInfo.Text += array[i, j].ToString();
                }
                labelIpInfo.Text += " ";
            }
                labelIpInfo.Text += "\n";
        }

        void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                labelIpInfo.Text += array[i].ToString();
                if(i != array.Length - 1)labelIpInfo.Text += ".";
            }
            labelIpInfo.Text += "\n";
        }

        void CalculateNetworkAddress()
        {
			for (int i = 0;i < 4;i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    networkAddress2[i, j] += (mask2[i, j] & ip2[i, j]);
                }
			}
        }

        void GetNumberDecimalFrom()
        {
            for(int i = 0; i < 4;i++) 
            {
                for(int j = 0; j < 8; j++)
                {
                    networkAddress[i] += (int)(networkAddress2[i, j] * Math.Pow(2, 7 - j));
                }
            }
        }

        void ConvertMaskToBinaryForm()
        {
            int mask10 = Convert.ToInt32(cbMask.SelectedItem.ToString());

			for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    mask2[i, j] = mask10-- > 0 ? 1 : 0;
                }
			}
        }

        void ConvertIpToBinaryForm()
        {
			for (int i = 0; i < 4; i++)
			{
                for(int j = 0; j < 8; j++)
                {
                    ip2[i, j] = ConvertNumberToBin(ip[i])[j];
                }
			}
		}

		int[] ConvertNumberToBin(int value)
		{
            int[] result = new int[8];
            for (int i = 0; i < 8; i++)
            {
                result[7 - i] = value % 2;
                value /= 2;
            }
            return result;
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
            Print(mask2);
            Print(ip2);
            Print(networkAddress2);
            GetNumberDecimalFrom();
            Print(networkAddress);
			labelIpInfo.Text += networkAddress[0] +"\n";
            labelIpInfo.Text += "network " +networkAddress2;

		}
    }
}
