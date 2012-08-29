using System.ComponentModel.DataAnnotations;

namespace GAX.Core.Models
{
  public class Product : BaseModel
  {
    [Key]
    public int ID { get; set; }
    public string Name { get; set; }
    public Supplier Supplier { get; set; }
  }
}