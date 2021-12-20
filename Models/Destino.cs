using System.ComponentModel.DataAnnotations;

namespace AgenciaComBack.Models
{
    public class Destino
    {
        [Key]
        public int IdDestino { get; set; }
        public string NomeDestino { get; set; }
        public DateTime Date { get; set; }
        public virtual List<Cliente> Clientes { get; set; }
    }
}