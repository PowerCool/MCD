using System;
using UnityEngine;

namespace Core
{
    [RequireComponent(typeof(GameContext))]
    public class ApplicationContext : MonoBehaviour, IContext
    {
        public static ApplicationContext Instance;

        private GameContext _gameContext;

        private void Awake()
        {
            if (Instance != null) return;
            Instance = this;
            DontDestroyOnLoad(this);

            _gameContext = GetComponent<GameContext>();
        }

        public GameContext GetGameContext()
        {
            return _gameContext;
        }
    }
}