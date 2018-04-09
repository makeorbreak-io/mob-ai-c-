using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mob_ai_csharp.multipaint
{
    public static class Runner
    {
        public static void Run(IBot bot)
        {
            bot.SetPlayerId(JsonConvert.DeserializeObject<Ready>(Console.ReadLine()).player_id);

            Console.WriteLine("{\"ready\":true}");

            while (true)
            {
                var msg = JsonConvert.DeserializeObject<Board>(Console.ReadLine());

                var move = bot.NextMove(msg);

                // Anonymous type to adjust with provided API
                var action = new
                {
                    direction = move.Direction,
                    type = move.Type,
                    turns_left = msg.turns_left
                };

                Console.WriteLine(JsonConvert.SerializeObject(action));
            }
        }
    }
}
