using QLMobileShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopingOnline.Models.BUS
{
    public class ShopOnlineBus
    {
        public static IEnumerable<Product> DanhSach()
        {
            var db = new QLMobileShopConnectionDB();
            return db.Query<Product>("select * from Products where ProductStatus = 1");
        }

        public static Product Detail(String a)
        {
            var db = new QLMobileShopConnectionDB();
            string s = "select * from Products where ProductsID = '" + a + "'";
            return db.SingleOrDefault<Product> (s);
        }

    }
}