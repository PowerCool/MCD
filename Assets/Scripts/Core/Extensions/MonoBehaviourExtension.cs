using UnityEngine;

namespace Core
{
    public static class MonoBehaviourExtension
    {
        public static ApplicationContext GetContext(this MonoBehaviour monoBehaviour)
        {
            return ApplicationContext.Instance;
        }
        
        public static GameContext GetGameContext(this MonoBehaviour monoBehaviour)
        {
            return ApplicationContext.Instance.GetGameContext();
        }
    }
}