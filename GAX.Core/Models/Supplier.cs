using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using GAX.Core.Models.Base;

namespace GAX.Core.Models
{
    public class Supplier : Address
    {
        [Key]
        public int SupplierId { get; set; }

        [Required(ErrorMessage = "Il nome è richiesto!")]
        [DisplayName("Nome")]
        [StringLength(160)]
        public string Name { get; set; }

        //[Required(ErrorMessage = "La descrizione è richiesta!")]
        [DisplayName("Descr")]
        [StringLength(8)]
        public string ShortDescription { get; set; }

        [DisplayName("Codice Fiscale")]
        public string FiscalCode { get; set; }

        [DisplayName("Partita IVA")]
        public string VatNumber { get; set; }

        [DisplayName("Note")]
        public string Note { get; set; }
    }
}