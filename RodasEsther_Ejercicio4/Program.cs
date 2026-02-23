using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Ingrese una de las opcciones: 1. Malware\r\n2. Phishing\r\n3. Acceso no autorizado\r\n4. Fuga de información");
int incidente = int .Parse(Console.ReadLine());
Console.WriteLine("Ingrese una de las opcciones: 1. PC\r\n2. Servidor\r\n3. Base de datos\r\n4. Red");
int Activo = int .Parse(Console.ReadLine());
Console.WriteLine("Persistencia detectada S/N");
string persistencia = Console.ReadLine();
Console.WriteLine("Numero de usuarios afectados");
int usuarios = int.Parse(Console.ReadLine());
string tipoIncidente = "";
string tipoActivo = "";
string severidad = "";
string respuesta = "";
