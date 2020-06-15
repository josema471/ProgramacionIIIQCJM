using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace gimnasioservidor
{
    class Program
    {
        
            // Datos Recibidos Desde ElCliente.  
        public static string data = null;

        public static void StartListening()
        {
            // Bufer de Datos paralosdatos recibidos  
            byte[] bytes = new Byte[1024];

            // Establece el punto deentrada final para el socket.  
            // Dns.GetHostName devuelve el nombre del host donde correr la aplicacion
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];

            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 11000);

            // Crea un Socket TCP/IP x.  
            Socket listener = new Socket(IPAddress.Any.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);


            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                // Inicia a escuchas miestras llegan conexiones.  
                while (true)
                {
                    Console.WriteLine("Esperando por ceonexiones ...");
                    // el Programa es suspendido mientras espera oconexiones de entrada .  
                    Socket handler = listener.Accept();
                    data = null;

                    // La conexion de entrada necesita ser procesada.  

                    int bytesRec = handler.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec);


                    // Muestra los datos en la consola .  
                    Console.WriteLine("Texto recibido: {0}", data);
                    string[] transformacion = data.Split(',');
                    gimnasio o = gimnasio.getinstance();
                    string respuesta = "";

                    string Operacion = transformacion[0];
                    double a = double.Parse(transformacion[1]);
                    string b = transformacion[2];
                    string c = transformacion[3];
                    double d = double.Parse(transformacion[4]);
                    double e = double.Parse(transformacion[5]);
                    double f = double.Parse(transformacion[6]);
                    Sexo sexo;
                    Enum.TryParse(c, out sexo);

               

                    switch (Operacion)
                    {
                        case "1":
                            atleta irving = new atleta(a, b,sexo,d,e,f );
                            o.Insertaratleta(irving);
                            break;
                        case "2":

                            break;
                        case "3":

                            
                            break;


                    }



                    // Prepara los datos para responder  al cliente.  
                    byte[] msg = Encoding.ASCII.GetBytes(respuesta);

                    handler.Send(msg);
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPresion ENTER para continuar...");
            Console.Read();

        }

        public static int Main(String[] args)
        {
            StartListening();
            return 0;
        }





    }
    

}


    

