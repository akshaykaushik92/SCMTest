using SCMTestPromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCMTestPromotionEngine
{
    public class DataAccessLayer : MockDB
    {
        public List<SkuPricing> GetPricing()
        {
            return this.skuPricingList;
        }

        public List<PromotionType> GetPromotionId(string skuType)
        {
            return this.promotionTypes.Where(x => x.ApplicableOnSku == skuType).ToList();
        }

        public List<PromotionType1> GetPromotionType1()
        {
            return this.promotionType1;
        }

        public List<PromotionType2> GetPromotionType2()
        {
            return this.promotionType2;
        }
    }
}
