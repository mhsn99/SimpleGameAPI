using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming.TransferObjects.Responses
{
    public class GameDisplayResponse
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public double GamePrice { get; set; }
        public string GameCategory { get; set; }
        public string GamePlatform { get; set; }
        public double GameScore { get; set; }
        public int CompanyId { get; set; }
    }
}
