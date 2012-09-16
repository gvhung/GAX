using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GAX.Core.Business.Interfaces;
using GAX.Core.Data;
using GAX.Core.Models;

namespace GAX.Core.Business
{
  public class SiteManager : ISiteManager
  {
    private readonly GaxEntities _db = new GaxEntities();

    public IEnumerable<SiteSection> GetActiveSections()
    {
      return _db.SiteSections.Where(s => s.IsActive);
    }

    public void Dispose()
    {
      _db.Dispose();
    }
  }
}
