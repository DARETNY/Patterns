using Patterns.ServiceProvider.Scripts.Interface;
using UnityEngine;

namespace Patterns.ServiceProvider.Scripts.Managers
{
    public class SoundManager : MonoBehaviour, IProviderHandler
    {

        private void Awake()
        {
            ServiceProvider.Register(this);
        }

        public void PlaySound(string soundName)
        {
            Debug.Log($"Playing sound:{soundName}");
        }
    }
}