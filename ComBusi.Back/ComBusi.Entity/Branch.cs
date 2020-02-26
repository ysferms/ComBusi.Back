using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ComBusi.Entity
{
  public class Branch : BaseEntity
  {
    [StringLength(25)]
    [MaxLength(25)]
    public string Name { get; set; }

  }
}
