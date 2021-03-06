﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats.Models
{
   public class DistributionByAgeDetail
    {
       
       public int DistributionByAgeDetailID { get; set; }
       public int DistributionHeaderID { get; set; }
       public int FDPID { get; set; }
       public int MaleLessThan5Years { get; set; }
       public int FemaleLessThan5Years { get; set; }
       public int MaleBetween5And18Years { get; set; }
       public int FemaleBetween5And18Years { get; set; }
       public int MaleAbove18Years { get; set; }
       public int FemaleAbove18Years { get; set; }

       public virtual WoredaStockDistribution WoredaStockDistribution { get; set; }
       public virtual FDP FDP { get; set; }
    }
}
