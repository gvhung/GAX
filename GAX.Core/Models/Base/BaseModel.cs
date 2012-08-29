using System;
using System.ComponentModel.DataAnnotations;

namespace GAX.Core.Models.Base
{
  public class BaseModel
  {
    public BaseModel()
    {
      DateInserted = DateTime.Now;
      DateUpdeted = DateTime.Now;
    }

    [ScaffoldColumn(false)]
    public DateTime DateInserted { get; set; }

    [ScaffoldColumn(false)]
    public DateTime DateUpdeted { get; set; }
  }
}