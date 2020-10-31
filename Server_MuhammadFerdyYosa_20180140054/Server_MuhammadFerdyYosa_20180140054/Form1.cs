using ServiceMtk_P2_054;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_MuhammadFerdyYosa_20180140054
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceHost hostObj = null;
            try
            {
                hostObj = new ServiceHost(typeof(Matematika));
                hostObj.Open();
                label2.Text = "Server ON";
                label3.Text = "Klik OFF untuk Mematikan Server";
                hostObj.Close();
            }
            catch (Exception ex)
            {
                hostObj = null;
                label3.Text = ex.Message;
                label2.Text = "Server OFF";
                label3.Text = "Klik ON untuk Menjalankan Server";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceHost hostObj = null;
            try
            {
                hostObj = new ServiceHost(typeof(Matematika));
                hostObj.Open();
                label2.Text = "Server ON";
                label3.Text = "Klik OFF untuk Mematikan Server";
                hostObj.Close();
                button1.Enabled = false;
                button2.Enabled = true;
            }
            catch (Exception ex)
            {
                hostObj = null;
                label3.Text = ex.Message;
                label2.Text = "Server OFF";
                label3.Text = "Klik ON untuk Menjalankan Server";
                button1.Enabled = true;
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceHost hostObj = null;
            hostObj = null;
            label2.Text = "Server OFF";
            label3.Text = "Klik ON untuk Menjalankan Server";
            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}
