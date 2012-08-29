using System.ComponentModel.DataAnnotations;

namespace GAX.Core.Models
{
  public class Supplier : BaseModel
  {
    [Key]
    public int ID { get; set; }
    public string Name { get; set; }
  }
}