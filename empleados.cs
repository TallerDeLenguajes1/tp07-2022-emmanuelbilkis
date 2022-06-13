using System;
using System.Collections.Generic;

namespace toDo
{
    public enum estadoTarea
    {
        pendiente = 0,
        haciendo = 1,
        realizada = 2 
        
    }
    public class tareas
    {
        private int ID;
        private string descripcion;
        private int duracion; // entre 10 y 100
        private estadoTarea estado;

        public int ID1 { get => ID; set => ID = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public estadoTarea Estado { get => estado; set => estado = value; }
    }    
}