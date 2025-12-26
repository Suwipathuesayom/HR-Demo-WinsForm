using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace plc_simulator.Plc
{
    public class PlcTcpClient
    {
        private TcpClient _client;
        public event Action<string> OnMessage;

        public async Task ConnectAsync(string ip, int port)
        {
            _client = new TcpClient();
            await _client.ConnectAsync(ip, port);

            _ = Task.Run(ReadLoop);
        }

        private async Task ReadLoop()
        {
            var stream = _client.GetStream();
            var buffer = new byte[1024];

            while (true)
            {
                int len = await stream.ReadAsync(buffer);
                var raw = Encoding.ASCII.GetString(buffer, 0, len);
                OnMessage?.Invoke(raw);
            }
        }
    }
}
