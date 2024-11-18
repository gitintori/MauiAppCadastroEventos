using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroEventos.Models
{
    public class Evento
    {
        public string? Nome { get; set; }
        public DateTime DataInicio { get; set; } = DateTime.Now;
        public DateTime DataTermino { get; set; }
        public int? NumeroParticipantes { get; set; }
        public string? Local { get; set; }
        public decimal? CustoPorParticipante { get; set; }

        public int DuracaoEvento
        {
            get
            {
                return (DataTermino - DataInicio).Days;
            }
        }

        public decimal? CustoTotal => NumeroParticipantes * CustoPorParticipante;
    }
}
