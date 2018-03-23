using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mob_ai_csharp.multipaint
{
    public interface IBot
    {
        void SetPlayerId(string playerId);

        Move NexMove(Board boardState);
    }
}