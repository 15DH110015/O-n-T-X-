using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace BaiMang20_3
{
    public partial class Form2 : Form
    {
        Socket server;
        EndPoint remote;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnKeo_Click(object sender, EventArgs e)
        {
            txtSelec.Text = "Kéo";

            byte[] sendData = Encoding.ASCII.GetBytes("0");
            server.SendTo(sendData, remote);

            byte[] receiveData = new byte[20];
            txtResult.Text = Encoding.ASCII.GetString(receiveData);
            Random r = new Random();
            r.Next(0, 3);
        }

        private void btnBua_Click(object sender, EventArgs e)
        {
            txtSelec.Text = "Búa";

            byte[] sendData = Encoding.ASCII.GetBytes("0");
            server.SendTo(sendData, remote);

            byte[] receiveData = new byte[20];
            txtResult.Text = Encoding.ASCII.GetString(receiveData);
            Random r = new Random();
            r.Next(0, 3);
        }

        private void btnBao_Click(object sender, EventArgs e)
        {
            txtSelec.Text = "Bao";

            byte[] sendData = Encoding.ASCII.GetBytes("0");
            server.SendTo(sendData, remote);

            byte[] receiveData = new byte[20];
            txtResult.Text = Encoding.ASCII.GetString(receiveData);
            Random r = new Random();
            r.Next(0, 3);
        }
    }
}
