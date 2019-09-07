using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColmadoFact.Models
{   [Table("Productos")]
  public  class Producto
    {
        public int Id { get; set; }
        [StringLength(250)]
        public string Descripcion { get; set; }
        [StringLength(250)]
        public string Detalle { get; set; }
        public decimal Precio { get; set; }
        public decimal PrecioLimite { get; set; }
        [StringLength(50)]
        public string Referencia { get; set; }
        public bool Activo { get; set; }
        public DateTime FRegistro { get; set; }
        public decimal Impuesto { get; set; }
        public bool Caduca { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio1 { get; set; }
        public decimal Precio2 { get; set; }
        public decimal Precio3 { get; set; }
        public bool EsCombo { get; set; }
        public int CategoriaId { get; set; }
        public int MarcaId { get; set; }
        [ForeignKey("CategoriaId")]
        public virtual Categoria Categoria { get; set; }
        [ForeignKey("MarcaId")]
        public virtual Marca Marca { get; set; }

    }
}
