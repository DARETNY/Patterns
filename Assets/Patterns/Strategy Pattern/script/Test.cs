using System;
using Patterns.Strategy_Pattern.script.Abstarct.DamageTypes;
using Patterns.Strategy_Pattern.script.Commands;
using UnityEngine;

namespace Patterns.Strategy_Pattern.script
{
    public class Test : MonoBehaviour
    {
        private RifleGun _rifleGun;
        private MeleGun _mele;

        private const ushort Health = 100;
        [SerializeField] private ChooseGun chooseGun;


        private void Awake()
        {
            switch (chooseGun)
            {
                case ChooseGun.Rifle:
                    _rifleGun = new RifleGun(new IceDamage(), Health);
                    break;
                case ChooseGun.Mele:
                    _mele = new MeleGun(new ToxicDamage(), Health);
                    break;
                default:
                    throw new ("Invalid Model Type");
            }
        }

        private void Start()
        {
            CurrentHealth();
        }

        bool İsAlive() => CurrentHealth() > 0;

        private ushort CurrentHealth()
        {
            return (ushort)(Health - (chooseGun == ChooseGun.Rifle ? _rifleGun.TryAttack() : _mele.TryAttack()));
        }


        private enum ChooseGun
        {
            Rifle,
            Mele
        }
    }
}