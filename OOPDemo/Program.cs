namespace OOPDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Id = 1;
            player1.FirstName = "Samet";
            player1.LastName = "Taşcı";
            player1.YearOfBirth = "2002";
            player1.IdentityNo = "11111111111";

            IPlayerManager playerManager = new PlayerManager(new PlayerCheckManager());
            playerManager.Add(player1);
            playerManager.Update(player1);
            playerManager.Delete(player1);

            Campaign campaign1 = new Campaign();
            campaign1.Id = 2;
            campaign1.CampaignName = "Black Friday";
            campaign1.RateOfDiscount = 10;

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(player1, campaign1);
        }
    }
}