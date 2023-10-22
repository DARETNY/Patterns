using System.Collections;
using Patterns.Builder_Pattern.Script.Logic;
using Patterns.Builder_Pattern.Script.So;
using UnityEngine;

namespace Patterns.Builder_Pattern.Script.Main
{
    public class Test : MonoBehaviour
    {
        [SerializeField] private PlayerData player1;



        [SerializeField] private PlayerData player2;

        private BuılderSetter _playerData;
        private BuılderSetter _player1Data;


        private void Awake()
        {
            _playerData = new BuılderSetter(player1);
            _player1Data = new BuılderSetter(player2);
        }

        private void Start()
        {
            ShowInfo(_player1Data);
            Creat(player2.prefab).transform.position = transform.right;
            Creat(player1.prefab).transform.position = transform.forward;
            ShowInfo(_playerData);
           
        }

        private GameObject Creat(GameObject go)
        {
            var spawned = Instantiate(go, Vector3.zero, Quaternion.identity);
            spawned.transform.SetParent(this.transform);
            return spawned;
        }

        private void ShowInfo(BuılderSetter buılderSetter)
        {
            var playerName = buılderSetter.GetName().ToUpperInvariant();
            var level = buılderSetter.GetLevel();
            var experience = buılderSetter.GetExperience();

            Debug.Log($"Name: {playerName},Level: {level},Exp: {experience}");
        }
    }
}