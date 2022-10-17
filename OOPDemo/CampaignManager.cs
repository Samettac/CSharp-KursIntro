using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    internal class CampaignManager : ICampaignManager
    {
        public void Add()
        {
            Console.WriteLine("New campaign is added");
        }

        public void Delete()
        {
            Console.WriteLine("Campaign is deleted");
        }

        public void Update()
        {
            Console.WriteLine("Campaign is updated");
        }
    }
}
