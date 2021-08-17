Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Namespace Client
    Public Class ClientSocket
        Public Shared Sub Main(ByVal args As String())
            StartClient()
        End Sub

        Public Shared Sub StartClient()
            Dim bytes As Byte() = New Byte(1023) {}

            Try
                Dim host As IPHostEntry = Dns.GetHostEntry("localhost")
                Dim ipAddress As IPAddress = host.AddressList(0)
                Dim remoteEP As IPEndPoint = New IPEndPoint(ipAddress, 11000)
                Dim sender As Socket = New Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp)

                Try
                    sender.Connect(remoteEP)
                    Console.WriteLine("Socket conectado em {0}", sender.RemoteEndPoint.ToString())
                    Console.WriteLine("Api - Rest/Json; Cole abaixo o Json da requisicao")
                    Dim request = Console.ReadLine()
                    Dim msg As Byte() = Encoding.ASCII.GetBytes(request)
                    Dim bytesSent As Integer = sender.Send(msg)
                    Dim bytesRec As Integer = sender.Receive(bytes)
                    Console.WriteLine(Encoding.ASCII.GetString(bytes, 0, bytesRec))
                    Console.WriteLine("Press any key to exit")
                    Console.ReadLine()
                    sender.Shutdown(SocketShutdown.Both)
                    sender.Close()
                Catch ane As ArgumentNullException
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString())
                Catch se As SocketException
                    Console.WriteLine("SocketException : {0}", se.ToString())
                Catch e As Exception
                    Console.WriteLine("Unexpected exception : {0}", e.ToString())
                End Try

            Catch e As Exception
                Console.WriteLine(e.ToString())
            End Try
        End Sub
    End Class
End Namespace