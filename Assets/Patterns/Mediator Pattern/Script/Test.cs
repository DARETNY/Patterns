using Patterns.Mediator_Pattern.Script.MadiatorManager;
using Patterns.Mediator_Pattern.Script.MoveSystem;
using UnityEngine;

namespace Patterns.Mediator_Pattern.Script
{
    public class Test : MonoBehaviour
    {
        private MedManager _medManager;
        private Jumper _jumper;
        private Rotater _rotater;
        [SerializeField] private Transform target;
        private bool _checker;


        private void Awake()
        {
            _medManager = new MedManager();
            _jumper = new Jumper(_medManager, target);
            _rotater = new Rotater(_medManager, target);
        }


        private void Update()
        {
            switch (Input.mouseScrollDelta.y)
            {
                case > 0:
                    _rotater.Dosomething();
                    break;
                case < 0:
                    if (!_checker) _jumper.Dosomething();

                    break;
            }

            if (_medManager.Jumper1 != _jumper || _medManager.Slider1 != _rotater) return;
            Debug.Log("Matchhh");


            _checker = true;
        }
    }
}