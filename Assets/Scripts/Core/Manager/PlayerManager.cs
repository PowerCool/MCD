using System.Collections.Generic;

namespace Core
{
    public class PlayerManager
    {
        private readonly PlayerEntity[] _players = new[] {new PlayerEntity()};
        public IEnumerable<PlayerEntity> GetPlayers()
        {
            return _players;
        }
    }
}