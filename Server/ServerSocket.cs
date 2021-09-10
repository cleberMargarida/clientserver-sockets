using Data;
using Data.Entity;
using Logic.Assignatures.DTO;
using Logic.Assignatures.Interface;
using Logic.Utilities;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Server
{
    public class ServerSocket
    {
        private static int _port = 11000;
        protected static IPAddress _ipAddress  => Dns.GetHostEntry("localhost").AddressList.First();
        protected static IPEndPoint _iPEndPoint => new IPEndPoint(_ipAddress, _port);
        protected static Socket _socket => new Socket(_ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp)
            .Modify(x => x.Bind(_iPEndPoint))
            .Modify(x => x.Listen());

        public static void StartServer()
        {
            var thread = new Thread(ProcessClient).Modify(x => x.Start());

            void ProcessClient()
            {
                var handler = _socket.Accept();
                var clientRequest = GetRequest(handler, new byte[1024]);
                ProcessRequest(handler, clientRequest);
            }
        }

        private static string GetRequest(Socket handler, byte[] buffer) => Encoding.ASCII.GetString(buffer, 0, handler.Receive(buffer));
        
        private static void ProcessRequest(Socket handler, string request)
        {
            ///{"nome": "Cleber","sexo": "M","idade": 22}
            var dto = request.Deserialize<DtoMaioridade>();

            DataPersistence<Maioridade>.Create(Transform.InEntity(dto));

            var returnProcess = ServiceLocator.UseService<IMaioridade>().GetResponse(dto);

            SendResponse(handler, returnProcess);
        }

        private static void SendResponse(Socket handler, string returnProcess) => handler.Send(Encoding.ASCII.GetBytes(returnProcess));
    }
}