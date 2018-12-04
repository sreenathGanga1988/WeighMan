using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeighMan.Model
{
    class DbModel
    {
    }
    public class WeighConfigMaster
    {

        [Key]
        public int WeighConfigMasterId { get; set; }
       
        public String camera { get; set; }      
        public String device { get; set; }
        public String status { get; set; }
      
    }

    public class WeightData
    {

        [Key]
        public int WeightDataId { get; set; }

        public String EntryDate { get; set; }
        public String Picture { get; set; }
        public String WeightofLoad { get; set; }

    }
}
