using UnityEngine;

namespace Core
{
    public class PlayerModel : MonoBehaviour
    {
        private WeaponsModel _weaponsModel;
        private ArmorsModel _armorsModel;
        
        private void Awake()
        {
            _weaponsModel = gameObject.AddComponent<WeaponsModel>();
            _armorsModel = gameObject.AddComponent<ArmorsModel>();
        }
    }
}