using System;
using System.Collections.Generic;
using System.Text;

namespace SCMTestPromotionEngine.Models
{
    public class PromotionType
    {
        public int PromotionId { get; set; }
        public string ApplicableOnSku { get; set; }
        public string PromotionTypeName { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}
