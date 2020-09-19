using System;
using System.Collections.Generic;
using System.Text;

namespace SCMTestPromotionEngine.Models
{
    public class SkuPricing
    {
        public int Id { get; set; }
        public string SkuName { get; set; }
        public double Price { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}
