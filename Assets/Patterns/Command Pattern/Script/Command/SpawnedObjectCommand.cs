using Patterns.Command_Pattern.Script.Interface;
using UnityEngine;

namespace Patterns.Command_Pattern.Script.Command
{
    internal class SpawnedObjectCommand : ICommand
    {
        private Vector3 _position;
        private GameObject _spawnedObject;

        public SpawnedObjectCommand(Vector3 position, GameObject spawnedObject)
        {
            _position = position;
            _spawnedObject = spawnedObject;
        }

        public void Execute()
        {
            _spawnedObject = Object.Instantiate(_spawnedObject, _position, Quaternion.identity);
            Color materialColor = new Color(Random.value, Random.value, Random.value);
            if (_spawnedObject.TryGetComponent(out Renderer renderer))
            {
                renderer.material.color = materialColor;
            }
        }

        public void Undo()
        {
            if (!_spawnedObject.activeInHierarchy) return;
            Object.Destroy(_spawnedObject);
        }
    }
}