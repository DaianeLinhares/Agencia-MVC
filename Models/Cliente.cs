using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaComBack.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Cidade { get; set; }
        [ForeignKey("Destino")]
        public int DestinoId { get; set; }
        public virtual Destino Destino { get; set; }
    }
}
