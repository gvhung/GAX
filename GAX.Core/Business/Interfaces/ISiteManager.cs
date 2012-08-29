using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GAX.Core.Models;

namespace GAX.Core.Business.Interfaces
{
  public interface ISiteManager : IDisposable
  {
    IEnumerable<SiteSection> GetActiveSections();
  }
}
