using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using GAX.Core.Models.Base;

namespace GAX.Core.Models
{
  public class SiteSection : BaseModel
  {
    [Key]
    public int SiteSectionId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ActionName { get; set; }
    public string ControllerName { get; set; }
  }
}
