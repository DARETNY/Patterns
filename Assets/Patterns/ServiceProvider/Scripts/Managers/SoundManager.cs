using Patterns.ServiceProvider.Scripts.Interface;
using UnityEngine;

namespace Patterns.ServiceProvider.Scripts.Managers
{
    public class SoundManager : MonoBehaviour, IProviderHandler
    {
        // private AudioSource _audioSource;
        // [SerializeField] private AudioClip _clip;

        private void Awake()
        {
            ServiceProvider.Register(this);
            // _audioSource = GetComponent<AudioSource>();
        }

        public void PlaySound(string soundName)
        {
            // _audioSource.PlayOneShot(_clip);
            Debug.Log($"Playing sound:{soundName}");
        }
    }
}