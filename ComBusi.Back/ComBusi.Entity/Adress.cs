using System;
using System.Collections.Generic;
using System.Text;

namespace ComBusi.Entity
{
  public class Adress : BaseEntity
  {
    public int CountryId { get; set; }
    public int  CityId { get; set; }
    public string OpenAdress { get; set; }

    public Country Country { get; set; }
    public City City { get; set; }
  }
}
