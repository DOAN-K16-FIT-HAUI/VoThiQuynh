namespace CafeShop.Config
{
    public static class Config
    {
        private const string strUrlServer = @"https://localhost:7116/";
        public static string Connection()
        {
            string conn = @"Data Source=DESKTOP-QTH837P\SQLEXPRESS;Initial Catalog=CafeShop;User ID=sa;Password=1;Trust Server Certificate=True";
            return conn;
        }

        public static string ImageUrl()
        {
            string imageUrl = strUrlServer;
            return imageUrl;
        }

        public static string ProductImageUrl()
        {
            string imageUrl = $"{strUrlServer}Images/Product/";
            return imageUrl;
        }

        public static string GoodsReceiptUrl()
        {
            string imageUrl = $"{strUrlServer}GoodsReceipt/";
            return imageUrl;
        }

        public static string GoodsIssuetUrl()
        {
            string imageUrl = $"{strUrlServer}GoodsIssues/";
            return imageUrl;
        }
    }
}
