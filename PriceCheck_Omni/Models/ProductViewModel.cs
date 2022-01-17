using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PriceCheck_Omni.Models
{
    public class ProductViewModel
    {
        public string product_group_description { get; set; }
        public string stock_category_description { get; set; }
        public string stock_code { get; set; }
        public string stock_description { get; set; }
        public string unit_of_measure { get; set; }
        public int pack { get; set; }
        public string bar_code { get; set; }
        public string vat_code { get; set; }
        public string revenue_account { get; set; }
        public string purchases_account { get; set; }
        public double cost_price { get; set; }
        public int cost_price_per { get; set; }
        public int unit_volume { get; set; }
        public int unit_weight { get; set; }
        public string selling_price_currency { get; set; }
        public int selling_price_excl { get; set; }
        public double selling_price_incl { get; set; }
        public double selling_price_markup { get; set; }
        public string selling_price_measure { get; set; }
        public int selling_price_per { get; set; }
        public double incl_unit_selling_price { get; set; }
        public int level { get; set; }
        public object customer_currency { get; set; }
        public object customer_discount { get; set; }
        public object customer_discount_type { get; set; }
        public object customer_price_excl { get; set; }
        public object customer_price_incl { get; set; }
        public object customer_price { get; set; }
        public object customer_price_per { get; set; }
        public object customer_unit_price_excl { get; set; }
        public object customer_unit_price_incl { get; set; }
        public string stock_memo { get; set; }
        public int available { get; set; }
        public int reorder_qty { get; set; }
    }
}