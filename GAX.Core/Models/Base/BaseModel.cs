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
            IsActive = true;
        }

        [ScaffoldColumn(false)]
        public DateTime DateInserted { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DateUpdeted { get; set; }

        [ScaffoldColumn(false)]
        public bool IsActive { get; set; }

    }
}