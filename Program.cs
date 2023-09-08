using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Ingresar el numero del mes");
            int Meses= Convert.ToInt32(Console.ReadLine());

            string mMes;

            switch (Meses){
                case 1:
                    mMes = "Enero";
                    break;
                case 2: 
                    mMes = "Febrero";
                    break;
                case 3:
                    mMes = "Marzo";
                    break;
                case 4: 
                    mMes = "Abril";
                    break;
                case 5:
                    mMes = "Mayo";
                    break;
                case 6:
                   mMes = "Junio";
                   break; 
                default:
                   mMes = "Este codigo solo no puede ser nombre, solo debe ingresar un numero del 1 al 6";
                   break;
            }

            Console.WriteLine("Ponga el nombre del mes: " + mMes);
        }
    }
}
