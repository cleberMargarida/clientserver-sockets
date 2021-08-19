using Logic.Assignatures.DTO;
using Logic.Assignatures.Interface;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Server
{
    public abstract class ServerSocket
    {
        private static int Port = 11000;

        public static void StartMultThreadServer()
        {
            Thread threadClientCS = new Thread(StartServer);
            Thread threadClientVB = new Thread(StartServer);

            threadClientCS.Start();
            threadClientVB.Start();
        }

        public static void StartServer()
        {
            IPAddress ipAddress = GetIpAddress();
            IPEndPoint localEndPoint = GetEndPoint(ipAddress, Port++);
            var request = Listen(ipAddress, localEndPoint, out Socket handler);
            ProcessRequest(handler, request);
            CloseServer(handler);
        }

        private static string Listen(IPAddress ipAddress, IPEndPoint localEndPoint, out Socket handler)
        {
            Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            listener.Bind(localEndPoint);
            listener.Listen(1);

            handler = listener.Accept();

            var bytes = new byte[1024];
            int bytesRec = handler.Receive(bytes);
            
            string requestMsg = null;
            requestMsg += Encoding.ASCII.GetString(bytes, 0, bytesRec);

            return requestMsg;
        }

        private static IPAddress GetIpAddress() => Dns.GetHostEntry("localhost").AddressList.First();

        private static IPEndPoint GetEndPoint(IPAddress ipAddress, int port) => new IPEndPoint(ipAddress, port);


        private static void ProcessRequest(Socket handler, string request)
        {
            var dto = JsonConvert.DeserializeObject<DtoMaioridade>(request);

            var returnProcess = ServiceLocator.UseService<IMaioridade>()
                .EhMaiorIdade(dto.Nome, dto.Sexo, dto.Idade);

            SendResponse(handler, returnProcess);
        }

        private static void SendResponse(Socket handler, string returnProcess) => handler.Send(Encoding.ASCII.GetBytes(returnProcess));

        private static void CloseServer(Socket handler)
        {
            handler.Shutdown(SocketShutdown.Both);
            handler.Close();
        }
    }
}
