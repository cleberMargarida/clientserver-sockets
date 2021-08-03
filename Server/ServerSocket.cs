using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    public class ServerSocket
    {
        public static int Main(String[] args)
        {
            StartServer();
            return 0;
        }

        public static void StartServer()
        {

            // Get Host IP Address that is used to establish a connection  
            // In this case, we get one IP address of localhost that is IP : 127.0.0.1  
            // If a host has multiple addresses, you will get a list of addresses  
            IPHostEntry host = Dns.GetHostEntry("localhost");
            IPAddress ipAddress = host.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);


            try
            {

                // Cria um Socket que usará o protocolo TCP     
                Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                // Um Socket deve ser associado a um endpoint usando o método Bind  
                listener.Bind(localEndPoint);
                // Especifica quantas solicitações um Socket pode escutar antes de dar uma resposta de Servidor ocupado.    
                listener.Listen(1);

                Console.WriteLine("Aguardando por conexão...");
                Socket handler = listener.Accept();

                // Mensagem recebida do client.    
                String Mensagem = null;
                byte[] bytes = null;

                while (true)
                {
                    bytes = new byte[1024];
                    int bytesRec = handler.Receive(bytes);
                    Mensagem += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    if (Mensagem.IndexOf("<EOF>") > -1)
                    {
                        break;
                    }
                }

                Console.WriteLine("Mensagem recebida : {0}", Mensagem);

                byte[] msg = Encoding.ASCII.GetBytes(Mensagem);
                handler.Send(msg);
                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\n Aperte uma tecla para continuar...");
            Console.ReadKey();

        }
    }
}
