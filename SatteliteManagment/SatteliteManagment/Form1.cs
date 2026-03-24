using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
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
                    //sentTextBox.AppendText("С сервера: " + text + Environment.NewLine);
                }));
            };
        }

        void changeInterfaceState(bool stateServer)
        {
            if (stateServer)
            {
                pictureBox1.BackColor = Color.Green;
                buttonOpenCloseServer.Text = "Выключить сервер";
                labelComPortConnectionInfo.Text = "Подключено";
            }
            else
            {
                pictureBox1.BackColor = Color.Red;
                buttonOpenCloseServer.Text = "Включить сервер";
                labelComPortConnectionInfo.Text = "Выключено";
            }
        }

        private async Task changeServerState(bool stateServer)
        {

            //true - включить сервер, false - выключить сервер
            if (stateServer)
                try
                {
                    buttonOpenCloseServer.Enabled = false;
                    await _client.ConnectAsync("127.0.0.1", 8924);
                    changeInterfaceState(true);
                    buttonOpenCloseServer.Enabled = true;

                }
                catch (Exception e)
                {
                        MessageBox.Show("Подключение к серверу не было выполнено. Проверьте, что сервер включен");
                    buttonOpenCloseServer.Enabled = true;
                    changeInterfaceState(false);
                }
            else
                changeInterfaceState(false);
        }

        private void SetDataGridLogHeaders()
        {
            dataGridViewLogs.ColumnCount = 6;
            dataGridViewLogs.Columns[0].Width = 165;
            dataGridViewLogs.Columns[1].Width = 100;
            dataGridViewLogs.Columns[2].Width = 70;
            dataGridViewLogs.Columns[3].Width = 70;
            dataGridViewLogs.Columns[4].Width = 305;
            dataGridViewLogs.Columns[5].Width = 355;

            dataGridViewLogs.Columns[0].HeaderText = "Дата и время";
            dataGridViewLogs.Columns[1].HeaderText = "Номер приёмника";
            dataGridViewLogs.Columns[2].HeaderText = "SNR";
            dataGridViewLogs.Columns[3].HeaderText = "RSSI";
            dataGridViewLogs.Columns[4].HeaderText = "Байтовый текст";
            dataGridViewLogs.Columns[5].HeaderText = "Текстовое описание пакета";
        }

        private void buttonSendCommand_Click(object sender, EventArgs e)
        {/*
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("COM порт закрыт!");
                return;
            }

            try
            {
                string commandToSendRaw = textBoxSendCommand.Text;

                string commandToSend;
                if (radioButtonSeparatorDollar.Checked)
                {
                    commandToSend = commandToSendRaw.Replace("$", String.Empty);
                }
                else
                {
                    commandToSend = commandToSendRaw;
                }

                byte[] commandToSendBytes = GetBytesFromByteString(commandToSend).ToArray();

                outputQueue.Add(commandToSendBytes);

                ColoredItem outputLog = new ColoredItem(commandToSendBytes, "Отправка команды с терминала", Color.Blue);
                WriteRadioControlLog(outputLog);
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось преобразовать строку в команду, проверьте правильность ввода");
            }
            */
        }

        public void WriteRadioControlLog(/*ColoredItem item*/)
        {
            /*
            if (item.color == Color.Green && !checkBoxIsLoggingTrancieverChanges.Checked)
            {
                return;
            }

            WriteLogHex(item);*/
        }

        private IEnumerable<byte> GetBytesFromByteString(string s)
        {
            for (int index = 0; index < s.Length; index += 2)
            {
                yield return Convert.ToByte(s.Substring(index, 2), 16);
            }
        }

        private void buttonClearLogs_Click(object sender, EventArgs e)
        {
            dataGridViewLogs.Rows.Clear();
            dataGridViewLogs.Refresh();
            SetDataGridLogHeaders();
        }
        
        private void connectToServer_Click(object sender, EventArgs e)
        {
            if (buttonOpenCloseServer.Text=="Включить сервер") 
                changeServerState(true);
            else
                changeServerState(false);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == "" || Path.GetExtension(openFileDialog1.FileName).ToLower() != ".txt")
                return;
            string path = openFileDialog1.FileName;
            byte[] dataArray=File.ReadAllBytes(path);
            List<byte[]> data = new List<byte[]>();
            int dataArrayLength = dataArray.Length;
            int countDataPacket = (int)(dataArrayLength / 255);
            for (int index = 0; index <= countDataPacket; index++)
            {
                int subArrayLength = (index!= countDataPacket) ? 255 : dataArrayLength % 255;
                byte[] subArray = new byte[subArrayLength];

                Array.Copy(dataArray, subArray, subArrayLength);
                data.Add(subArray);
            }

            if (buttonOpenCloseServer.Text == "Включить сервер" || labelComPortConnectionInfo.Text == "Выключено")
                connectToServer_Click(sender,e);

            byte[] baseSendString = Encoding.ASCII.GetBytes("Идёт отправка команд из файла");

            _client.SendTextAsync(baseSendString);

            foreach (var i in data)
            {
                _client.SendTextAsync(i);
            }
        }
    }
}
