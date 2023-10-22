using System;
using System.Collections.Generic;
using Patterns.ServiceProvider.Scripts.Interface;
using Patterns.ServiceProvider.Scripts.Managers;

namespace Patterns.ServiceProvider.Scripts
{
    public static class ServiceProvider
    {
        private static readonly Dictionary<Type, IProviderHandler> Providers = new();


        private static T GetManager<T>() where T : class, IProviderHandler
        {
            if (Providers.ContainsKey(typeof(T)))
                return (T)Providers[typeof(T)];

            return null;
        }

        public static void Register<T>(T target) where T : class, IProviderHandler
        {
            Providers.Add(typeof(T), target);
        }

        // this is easy way to reach all manager whic are registered
        public static GameManager GetGameManager => GetManager<GameManager>();
        public static SoundManager GetSoundManager => GetManager<SoundManager>();
    }
}