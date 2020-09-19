using SCMTestPromotionEngine.Models;
using System.Collections.Generic;

namespace SCMTestPromotionEngine
{
    public class MockDB
    {
        protected List<SkuPricing> skuPricingList = new List<SkuPricing>
        {
            new SkuPricing{Id = 1, SkuName = "A",Price = 50.0, CreatedOn = null ,CreatedBy = "System", ModifiedOn = null, ModifiedBy = null },
            new SkuPricing{Id = 2, SkuName = "B",Price = 30.0, CreatedOn = null ,CreatedBy = "System", ModifiedOn = null, ModifiedBy = null },
            new SkuPricing{Id = 3, SkuName = "C",Price = 20.0, CreatedOn = null ,CreatedBy = "System", ModifiedOn = null, ModifiedBy = null },
            new SkuPricing{Id = 4, SkuName = "D",Price = 15.0, CreatedOn = null ,CreatedBy = "System", ModifiedOn = null, ModifiedBy = null }
        };

        protected List<PromotionType> promotionTypes = new List<PromotionType>
        {
            new PromotionType{PromotionId = 1, ApplicableOnSku = "A", PromotionTypeName = "PromotionType1", CreatedOn = null ,CreatedBy = "System", ModifiedOn = null, ModifiedBy = null },
            new PromotionType{PromotionId = 1, ApplicableOnSku = "B", PromotionTypeName = "PromotionType1", CreatedOn = null ,CreatedBy = "System", ModifiedOn = null, ModifiedBy = null },
            new PromotionType{PromotionId = 2, ApplicableOnSku = "C", PromotionTypeName = "PromotionType2", CreatedOn = null ,CreatedBy = "System", ModifiedOn = null, ModifiedBy = null },
            new PromotionType{PromotionId = 2, ApplicableOnSku = "D", PromotionTypeName = "PromotionType2", CreatedOn = null ,CreatedBy = "System", ModifiedOn = null, ModifiedBy = null }
        };

        protected List<PromotionType1> promotionType1 = new List<PromotionType1>
        {
            new PromotionType1{Id = 1, SkuName = "A", SkuMultiple = 3, PromotionPricing = 130.0, CreatedOn = null ,CreatedBy = "System", ModifiedOn = null, ModifiedBy = null},
            new PromotionType1{Id = 2, SkuName = "B", SkuMultiple = 2, PromotionPricing = 45, CreatedOn = null ,CreatedBy = "System", ModifiedOn = null, ModifiedBy = null}
        };

        protected List<PromotionType2> promotionType2 = new List<PromotionType2>
        {
            new PromotionType2{Id = 1, SkuName = "C", PromotionPricing = 30.0, CreatedOn = null ,CreatedBy = "System", ModifiedOn = null, ModifiedBy = null},
        };
    }
}
