using System;
using System.Collections.Generic;


namespace toDo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<tareas> ListaTareas = new List<tareas>();

            Random N = new Random();
            int aleat = N.Next(1,10);
            int num = 0;
            Console.WriteLine("Aleatorio: " + aleat);

            for (int i = 0; i < aleat; i++)
            {

                string descripcionEmpleado = Console.ReadLine();

                tareas Ntarea = new tareas();
                Ntarea.Descripcion = descripcionEmpleado;

                num++;
                Ntarea.ID1 = num;

                Console.WriteLine("Ingrese la duracion");
                Ntarea.Duracion =Convert.ToInt32(Console.ReadLine());

                Ntarea.Estado = estadoTarea.pendiente;

                ListaTareas.Add(Ntarea);

                /*Console.WriteLine("Desea agregar otro empleado ? s/n");
                salida = Console.ReadLine();*/
            
            }
        
            foreach (tareas xtarea in ListaTareas)
            {
                Console.WriteLine("ID: " + xtarea.ID1 + "| Descripcion: " + xtarea.Descripcion + "| Duracion: "+ xtarea.Duracion);
                Console.WriteLine("Estado: " + xtarea.Estado);
            }

            for (int i = 0; i < ListaTareas.Count; i++)
            {
                Console.WriteLine("Desea cambiar el estado de la tarea ? s/n");
                string entrada = Console.ReadLine();

                if (entrada == "s")
                {
                    ListaTareas[i].Estado = estadoTarea.realizada;
                }
                
            }


            Console.WriteLine("Ingrese la descripcion de la tarea a buscar");
            string descripcion = Console.ReadLine();
            foreach (tareas xtarea in ListaTareas)
            {
                if (xtarea.Descripcion == descripcion && xtarea.Estado == estadoTarea.realizada)
                {
                     Console.WriteLine("ID: " + xtarea.ID1 + "| Descripcion: " + xtarea.Descripcion + "| Duracion: "+ xtarea.Duracion);
                     Console.WriteLine("Estado: " + xtarea.Estado);
                }
            }
            
            int sumador=0;
            foreach (tareas xtarea in ListaTareas)
            {
                sumador = sumador + xtarea.Duracion;
            }

            Console.WriteLine("La sumatoria de las horas trabajadas por los emppleados son : " + sumador);

        }
    }
}