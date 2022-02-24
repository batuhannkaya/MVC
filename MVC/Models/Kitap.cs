using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Kitap
    {
      public int SeriNo { get; set; }
      public string KitapAdi { get; set; }
      public string YazarAdi { get; set; }
      public int Yaş { get; set; }
        
    }
}