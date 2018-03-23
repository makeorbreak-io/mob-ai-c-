using System;
using System.Collections.Generic;
using mob_ai_csharp.multipaint;

namespace mob_ai_csharp
{
    public class Bot : IBot
    {
        public List<string> ActionTypes = new List<string>() { "shoot", "walk" };

        public List<List<int>> ActionDirections = new List<List<int>>()
        {
            new List<int>{-1, -1}, // NorthWest
            new List<int>{ 0, -1}, // North
            new List<int>{ 1, -1}, // Northeast
            new List<int>{-1,  0}, // West
            new List<int>{ 1,  0}, // East
            new List<int>{ 1,  1}, // Southwest
            new List<int>{ 0,  1}, // South
            new List<int>{ 1,  1}, // Southeast
        };

        private string PlayerId;
        public Random R;

        private static void Main(string[] args)
        {
            Runner.Run(new Bot());
        }

        public void SetPlayerId(string playerId)
        {
            this.PlayerId = playerId;
            this.R = new Random();
        }

        public Move NexMove(Board boardState)
        {
            Move move = new Move();

            move.Type = this.ActionTypes[R.Next(2)];
            move.Direction = this.ActionDirections[this.R.Next(8)];

            return move;
        }
    }
}