using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatteliteManagment
{
    public partial class Form1 : Form
    {
        private readonly DuplexTcpClient _client = new DuplexTcpClient();
        public Form1()
        {
            InitializeComponent();

            _client.TextReceived += text =>
            {
                BeginInvoke(new Action(() =>
                {
                    sentTextBox.AppendText("С сервера: " + text + Environment.NewLine);
                }));
            };
        }

        private async Task startListeningServer()
        {
            try
            {
                await _client.ConnectAsync("127.0.0.1", 8924);
                MessageBox.Show("Подключение к серверу выполнено");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void connectToServer_Click(object sender, EventArgs e)
        {
            startListeningServer();
        }
    }
}
