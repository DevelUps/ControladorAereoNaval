using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladorAereoNaval
{
    internal class Program
    {
        static void Main(string[] args)
        // Controlador Aéreo Naval. Este fragmento de código en C# verifica si un vehículo aéreo de combate no tripulado llamado EDI está listo para despegar. Para determinar esto, se solicita al usuario ingresar el nivel de energía de EDI y el estado de sus turbinas derecha e izquierda. Si ambas turbinas están funcionando y el nivel de energía es mayor o igual a 75, o si al menos una de las turbinas está funcionando y el nivel de energía es igual a 100, se muestra un mensaje indicando que el equipo STEALTH debe prepararse para el despegue. De lo contrario, se muestra un mensaje indicando que la misión debe ser abortada porque EDI no está listo para despegar.

float nivelEnergia;
        bool turbinaR, turbinaL;

        Console.Write("Equipo STEALTH, confirmar niveles de energía de EDI (Vehículo aéreo de combate no tripulado): ");
nivelEnergia = Convert.ToSingle(Console.ReadLine());

Console.Write("Equipo STEALTH, confirmar estado de la turbina derecha de EDI (true/false): ");
turbinaR = Convert.ToBoolean(Console.ReadLine());

Console.Write("Equipo STEALTH, confirmar estado de la turbina izquierda de EDI (true/false): ");
turbinaL = Convert.ToBoolean(Console.ReadLine());

if ((((turbinaR && turbinaL) == true) && (nivelEnergia >= 75)) || (((turbinaR || turbinaL) == true) && (nivelEnergia == 100)))
{
    Console.WriteLine("Equipo STEALTH, prepárese para despegar con EDI.");
}
else
{
    Console.WriteLine("Equipo STEALTH, abortar misión. EDI no está listo para despegar.");
}



                    




        }
    }
}
