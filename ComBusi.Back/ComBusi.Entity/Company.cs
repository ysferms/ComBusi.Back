using System;
using System.Collections.Generic;
using System.Text;

namespace ComBusi.Entity
{
  public class Company : BaseEntity
  {
    public string Name { get; set; }
    public string ShortName { get; set; }

    public int BranchId { get; set; }
    public string Email { get; set; }
    public int CompanyInfoId { get; set; }
    public Branch Branch { get; set; }
    public CompanyInformation CompanyInformation { get; set; }
  }
}
