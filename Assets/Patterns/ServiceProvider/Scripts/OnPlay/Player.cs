using UnityEngine;

namespace Patterns.ServiceProvider.Scripts.OnPlay
{
    public class Player : MonoBehaviour
    {
        private void Start()
        {
            ServiceProvider.GetSoundManager.PlaySound("Soud data is here");
        }
    }
}