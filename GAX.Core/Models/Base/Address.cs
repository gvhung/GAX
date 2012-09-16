using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GAX.Core.Models.Base
{
  public class Address : BaseModel
  {
    [DisplayName("Indirizzo")]
    public string Street { get; set; }
    [DisplayName("CAP")]
    public string Cap { get; set; }
    [DisplayName("Città")]
    public string City { get; set; }
    [DisplayName("Provincia")]
    public string District { get; set; }
    [DisplayName("Telefono")]
    public string Telephone { get; set; }
    [DisplayName("FAX")]
    public string Fax { get; set; }
    [DisplayName("eMail")]
    [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Email non valida!")]
    public string Email { get; set; }
    [DisplayName("Web")]
    public string WebAddress { get; set; }
  }
}
