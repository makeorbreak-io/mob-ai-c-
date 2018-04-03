using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mob_ai_csharp.multipaint
{
    public class Board
    {
        public int turns_left { get; set; }

        public int width { get; set; }

        public int height { get; set; }

        public List<List<string>> colors { get; set; }

        public List<Dictionary<string, Move>> previous_actions { get; set; }

        public Dictionary<string, List<int>> player_positions { get; set; }
    }
}
