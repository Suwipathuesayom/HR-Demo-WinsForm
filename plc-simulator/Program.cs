using System.Net;
using System.Net.Sockets;
using System.Text;
using hr_demo_data;
using System.Linq;

Console.WriteLine("PLC Simulator starting...");

using var db = new ApplicationDbContext();

if (!db.Users.Any())
{
    db.Users.Add(new hr_demo.domain.Models.User
    {
        Username = "EMP001",
        FirstName = "John",
        LastName = "Doe",
        Email = "emp001@example.com",
        Password = "pass",
        BirthDate = DateTime.Now.AddYears(-25),
        HireDate = DateTime.Now.AddYears(-1)
    });
    db.SaveChanges();
    Console.WriteLine("Created sample user EMP001");
}

var users = db.Users.Select(u => u.Username).Where(u => !string.IsNullOrEmpty(u)).ToArray();
if (users.Length == 0)
{
    Console.WriteLine("No users available to simulate. Exiting.");
    return;
}

var devices = new[] { "FINGER01", "FINGER02", "FINGER03" };
var rand = new Random();

var server = new TcpListener(IPAddress.Any, 9100);
server.Start();

Console.WriteLine("PLC Simulator started on port 9100");

while (true)
{
    var client = await server.AcceptTcpClientAsync();
    _ = Task.Run(async () =>
    {
        using var stream = client.GetStream();

        while (client.Connected)
        {
            if (rand.NextDouble() < 0.1)
            {
                users = db.Users.Select(u => u.Username).Where(u => !string.IsNullOrEmpty(u)).ToArray();
            }

            var username = users[rand.Next(users.Length)];
            var device = devices[rand.Next(devices.Length)];
            var msg = $"SCAN;USER={username};TIME={DateTime.Now:O};DEVICE={device}\n";

            var buffer = Encoding.ASCII.GetBytes(msg);
            await stream.WriteAsync(buffer);

            Console.WriteLine("Sent: " + msg.Trim());
            await Task.Delay(3000);
        }
    });
}

