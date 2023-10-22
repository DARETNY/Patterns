using UnityEngine;

namespace Patterns.Builder_Pattern.Script.So
{
    [CreateAssetMenu(fileName = "Customer", menuName = "Player", order = 0)]
    public class PlayerData : ScriptableObject
    {
         public string playerName = "Player";
        [Range(0, 50)] public int level;
        public int experience;
        public GameObject prefab;

        
    }
}