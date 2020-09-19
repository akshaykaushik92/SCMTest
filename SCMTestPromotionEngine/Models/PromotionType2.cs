using System;
using System.Collections.Generic;
using System.Text;

namespace SCMTestPromotionEngine.Models
{
    public class PromotionType2
    {
        public int Id { get; set; }
        public string SkuName { get; set; }
        public double PromotionPricing { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}
