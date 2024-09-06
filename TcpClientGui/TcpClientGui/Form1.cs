using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace TcpClientGui
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private string serverIp = "127.0.0.1";
        private int serverPort = 8888;

        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (client == null || !client.Connected)
                {
                    MessageBox.Show("Сначала подключитесь к серверу.");
                    return;
                }

                string message = textBoxMessage.Text;
                byte[] data = Encoding.UTF8.GetBytes(message);
                await stream.WriteAsync(data, 0, data.Length);
                textBoxHistory.AppendText($"Отправлено: {message}\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient();
                client.Connect(serverIp, serverPort);
                stream = client.GetStream();
                textBoxHistory.AppendText("Подключено к серверу.\r\n");
                statusIndicator.BackColor = System.Drawing.Color.Green;
                labelStatus.Text = "Подключено";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message);
                LogError(ex.Message);
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (client != null && client.Connected)
            {
                client.Close();
                textBoxHistory.AppendText("Отключено от сервера.\r\n");
                statusIndicator.BackColor = System.Drawing.Color.Red;
                labelStatus.Text = "Отключено";
            }
        }

        private void buttonSendFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (client == null || !client.Connected)
                {
                    MessageBox.Show("Сначала подключитесь к серверу.");
                    return;
                }

                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
                    stream.Write(fileBytes, 0, fileBytes.Length);
                    textBoxHistory.AppendText($"Файл {filePath} отправлен.\r\n");
                }
            }
            catch (Exception ex)
            {
                LogError(ex.Message);
                MessageBox.Show("Ошибка при отправке файла: " + ex.Message);
            }
        }

        private void LogError(string errorMessage)
        {
            string logPath = "error_log.txt";
            string logMessage = $"{DateTime.Now}: {errorMessage}\r\n";
            System.IO.File.AppendAllText(logPath, logMessage);
        }
    }
}
