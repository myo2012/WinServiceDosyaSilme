using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
namespace seri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.PortName = "COM";

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //MessageBox.Show(serialPort1.DataBits.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen==false)
            {
                serialPort1.Open();
            }
            string sendmesaj = richTextBox1.Text + "-->>>>";
            serialPort1.WriteLine(sendmesaj);
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                serialPort1.Open();
            }
            string i = serialPort1.ReadLine();
            richTextBox2.Text = "<<<<---" + i;
            serialPort1.Close();
        }



    }
}