using Core;
using UnityEngine;

namespace Scene
{
    public class TownScene : MonoBehaviour
    {
        private GameContext _gameContext;
        private void Start()
        {
            _gameContext = this.GetGameContext();
            _gameContext.OnJoinPlayer += OnJoinPlayer;
            _gameContext.LoadPlayers();
        }

        private void OnDestroy()
        {
            _gameContext.OnJoinPlayer -= OnJoinPlayer;
        }

        private void OnJoinPlayer(PlayerEntity playerEntity)
        {
        
        }
    }
}
