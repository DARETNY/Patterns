using System;
using Patterns.Builder_Pattern.Script.So;

namespace Patterns.Builder_Pattern.Script.Logic
{
    public record BuılderSetter : IDisposable // you can use interface or abstract to manage your same objects
    {
        readonly PlayerData _playerData;

        public BuılderSetter(PlayerData playerData)
        {
            this._playerData = playerData;
        }

        public string GetName()
        {
           return _playerData.prefab.gameObject.name = _playerData.playerName;
        }


        public int GetLevel()
        {
            return _playerData.level;
        }

        public int GetExperience()
        {
            return _playerData.experience;
        }

        public void Dispose()
        {
            // TODO release managed resources here
            if (_playerData.prefab == null)
            {
                GC.Collect();
            }
        }
    }
}