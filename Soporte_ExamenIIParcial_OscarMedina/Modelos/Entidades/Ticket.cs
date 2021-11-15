using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soporte_ExamenIIParcial_OscarMedina.Modelos.Entidades
{
   public  class Ticket
    {
        public int Id { get; set; }
        public string IdNumeroTicket { get; set; }
        public string EstadoTicket { get; set; }

        public string Asunto { get; set; }
    }
}
