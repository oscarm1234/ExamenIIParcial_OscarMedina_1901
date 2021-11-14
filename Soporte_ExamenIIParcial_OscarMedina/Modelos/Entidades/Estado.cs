using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soporte_ExamenIIParcial_OscarMedina.Modelos.Entidades
{
    public class Estado
    {
        public int Id { get; set; }
        public string TicketEstado { get; set; }
        public string Prioridad { get; set; }
        public bool DisponibleTicket { get; set; }
    }
}
