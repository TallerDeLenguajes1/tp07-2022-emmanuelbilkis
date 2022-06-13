using System;
using System.Collections.Generic;


namespace toDo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<empleados> ListaEmpleados = new List<empleados>();

            string salida = '';
            int num = 0;
            int duracion=0;

            do
            {
                Console.WriteLine("Ingrese la descripcion del empleado");
                string descripcionEmpleado = Console.Readline();

                empleados Nempleado = new empleados();
                Nempleado.descripcion = descripcionEmpleado;
                num++;
                Nempleado.ID = num;

                Console.WriteLine("Ingrese la duracion");
                
            } while (salida != "n");

        }
    }
}