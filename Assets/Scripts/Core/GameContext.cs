using System;
using UnityEngine;

namespace Core
{
    public class GameContext: MonoBehaviour
    {
        public event Action<PlayerEntity> OnJoinPlayer;
        
        private PlayerManager _playerManager;
        public PlayerManager PlayerManager => _playerManager;

        [Header("Players")]
        [SerializeField] private GameObject playerPrefab;

        private void Awake()
        {
            _playerManager = new PlayerManager();
        }

        public void LoadPlayers()
        {
            var players = _playerManager.GetPlayers();
            foreach (var player in players)
            {
                var playerGameObject = Instantiate(playerPrefab, Vector3.zero, Quaternion.identity);
                OnJoinPlayer?.Invoke(player);

            }
        }
    }
}