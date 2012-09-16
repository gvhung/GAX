using System.ComponentModel.DataAnnotations;
using GAX.Core.Models.Base;
using System.Web.Mvc;
using System.ComponentModel;

namespace GAX.Core.Models
{
    public class Product : BaseModel
    {
        [Key]
        public int ProductId { get; set; }

        [ScaffoldColumn(false)]
        public int SupplierId { get; set; }

        [Required(ErrorMessage = "Il nome è richiesto!")]
        [DisplayName("Nome")]
        [StringLength(160)]
        public string Name { get; set; }

        public Supplier Supplier { get; set; }
    }
}