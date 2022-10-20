using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InventoryManagerAPI.Models

{
    [Table("Materiais")]
    public class Material
    {
        public int MaterialId { get; private set; }
        public int CategoriaId { get; set; }
        public int EstoqueId { get; set; }
        public int FornecedorId { get; set; }
        public int UnidadeId { get; set; }
        public int Valor { get; set; }
        public int Peso { get; set; }
        public int Dimensao { get; set; }
        public string Serie { get; set; }
        public string Descricao { get; set; }

    }
}
