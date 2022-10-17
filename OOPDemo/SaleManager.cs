using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    internal class SaleManager
    {
        public void Sale(Player player, Campaign campaign)
        {
            Console.WriteLine(player.FirstName + " Alışverişinize " + campaign.CampaignName +
                " Kampanyası nedeni ile %" + campaign.RateOfDiscount + " indirim uygulanmıştır.");
        }
    }
}
