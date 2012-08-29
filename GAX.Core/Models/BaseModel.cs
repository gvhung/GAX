using System;

namespace GAX.Core.Models
{
  public class BaseModel
  {
    public BaseModel()
    {
      DateInserted = DateTime.Now;
      DateUpdeted = DateTime.Now;
    }

    public DateTime DateInserted { get; set; }
    public DateTime DateUpdeted { get; set; }
  }
}