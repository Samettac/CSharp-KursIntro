using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    internal class PlayerManager : IPlayerManager
    {
        IPlayerCheckService _playerCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public void Add(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player) == true)
            {
                Console.WriteLine(player.FirstName + " Added");
            }
            else
            {
                Console.WriteLine("Invalid Person");
            }
            
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName + " Updated");
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + " Deleted");
        }
    }
}
