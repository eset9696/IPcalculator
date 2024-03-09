using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace IPcalculator
{
    public partial class Form1 : Form
    {
        int[,] ip2;
        int[,] mask2;
		int[,] networkAddress2;
        int[,] broadcast2;

        int[] ip;
        int[] broadcast;
        int[] networkAddress;

        long hosts;
        int mask;

        string ipString;
        string pattern = @"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$";
        public Form1()
        {
            InitializeComponent();
            FillcbMask();
		}

        void FillcbMask()
        {
            for (int i = 0; i <= 32; i++)cbMask.Items.Add(i);
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

		void Print(long value)
		{
			labelIpInfo.Text += value + "\n";
		}

		void CalculateHostsNumber()
		{
            hosts = (long) Math.Pow(2, (32 - mask)) - 2;
            if(hosts < 0) hosts = 0;
		}

		void CalculateNetworkAddress()
        {
			networkAddress2 = new int[4, 8];
			networkAddress = new int[4];
			for (int i = 0;i < 4;i++)
            {
                for(int j = 0; j < 8; j++) networkAddress2[i, j] += (mask2[i, j] & ip2[i, j]);
			}
			GetNumberDecimalFrom(networkAddress, networkAddress2);
		}

		void CalculateBroadcast()
		{
			broadcast2 = new int[4, 8];
			broadcast = new int[4];
			int counter = 0;
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 8; j++, counter++)
				{
                    if(counter < mask) broadcast2[i, j] = ip2[i, j];
					else broadcast2[i, j] = 1;
				}
			}
			GetNumberDecimalFrom(broadcast, broadcast2);
		}

		void GetNumberDecimalFrom(int[] array, int[,] array2)
        {
            for(int i = 0; i < 4;i++) 
            {
                for(int j = 0; j < 8; j++) array[i] += (int)(array2[i, j] * Math.Pow(2, 7 - j));
            }
        }

        void ConvertMaskToBinaryForm()
        {
            int temp = mask;
			mask2 = new int[4, 8];
			for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 8; j++) mask2[i, j] = temp-- > 0 ? 1 : 0;
			}
        }

        void ConvertIpToBinaryForm()
        {
			ip2 = new int[4, 8];
			ConvertIpToDecimalForm();
			for (int i = 0; i < 4; i++)
			{
                for(int j = 0; j < 8; j++) ip2[i, j] = ConvertNumberToBin(ip[i])[j];
			}
		}
		void ConvertIpToDecimalForm()
		{
			ip = new int[4];
			string ipStringInput = ipString;
			for (int i = 0; i < 4; i++) ip[i] = Convert.ToInt32(ipStringInput.Split('.')[i]);
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

        void Calculate()
        {
            ipString = rtbIPinput.Text.ToString();
            if (Regex.IsMatch(ipString, pattern))
            {
				mask = Convert.ToInt32(cbMask.SelectedItem.ToString());
				ConvertIpToBinaryForm();
                ConvertMaskToBinaryForm();
                CalculateNetworkAddress();
                CalculateBroadcast();
                CalculateHostsNumber();
                ShowInfo();
            }
            else labelIpInfo.Text = "Неверный формат IP адреса";
		}

        void ShowInfo()
        {
            labelIpInfo.Text = "Network address:\t ";
			Print(networkAddress); 
            labelIpInfo.Text += "Broadcast address:\t ";
			Print(broadcast);
            labelIpInfo.Text += "Number of hosts:\t ";
            Print(hosts);
		}

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Calculate();
		}

		private void rtbIPinput_TextChanged(object sender, EventArgs e)
		{
            Calculate();
		}

		private void cbMask_SelectedIndexChanged(object sender, EventArgs e)
		{
			Calculate();
		}
	}
}
