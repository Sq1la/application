using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Server
{
    static void Main(string[] args)
    {
        // Создание TCP-сервера, слушающего на порту 8888
        TcpListener server = new TcpListener(IPAddress.Any, 8888);
        server.Start();
        Console.WriteLine("Сервер запущен. Ожидание подключений...");

        // Цикл для ожидания подключений
        while (true)
        {
            // Ожидание подключения клиента
            TcpClient client = server.AcceptTcpClient();
            Console.WriteLine("Клиент подключился!");

            // Получение потока для чтения и записи
            NetworkStream stream = client.GetStream();

            // Чтение данных от клиента
            byte[] buffer = new byte[256];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string receivedMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            Console.WriteLine($"Получено сообщение от клиента: {receivedMessage}");

            // Отправка ответа клиенту
            string responseMessage = "Сообщение получено!";
            byte[] responseBytes = Encoding.UTF8.GetBytes(responseMessage);
            stream.Write(responseBytes, 0, responseBytes.Length);

            // Закрытие соединения с клиентом
            client.Close();
        }
    }
}
