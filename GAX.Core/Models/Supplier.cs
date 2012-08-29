using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using GAX.Core.Models.Base;

namespace GAX.Core.Models
{
  public class Supplier : Address
  {
    [Key]
    public int ID { get; set; }

    [DisplayName("Attivo")]
    public bool IsActive { get; set; }

    [DisplayName("Nome")]
    [Required(ErrorMessage = "Il nome è richiesto!")]
    [StringLength(160)]
    public string Name { get; set; }

    [DisplayName("Breve descrizione")]
    [StringLength(15)]
    public string ShortDescription { get; set; }

    [DisplayName("Codice Fiscale")]
    public string FiscalCode { get; set; }

    [DisplayName("Partita IVA")]
    public string VatNumber { get; set; }

    [DisplayName("Note")]
    public string Note { get; set; }
  }
}