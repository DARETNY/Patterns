using Patterns.ServiceProvider.Scripts.Interface;
using UnityEngine;

namespace Patterns.ServiceProvider.Scripts.Managers
{
    public class GameManager : MonoBehaviour, IProviderHandler
    {
        private void Awake()
        {
            ServiceProvider.Register(this);
        }
    }
}