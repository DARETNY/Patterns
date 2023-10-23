using System;
using Patterns.Builder_Pattern.Scripts.Base;
using Patterns.Builder_Pattern.Scripts.Command;
using UnityEngine;

namespace Patterns.Builder_Pattern.Scripts.PlayMode
{
    public class CarSummon : MonoBehaviour
    {
        [SerializeField] private ModelType modelType;
        private SedanModels _sedanModels;
        private JeepModels _jeepModels;


        private void Start()
        {
            switch (modelType)
            {
                case ModelType.Sedan:
                    ICarBuılder sedanBuilder = new SedanModels();
                    Car sedanCar = sedanBuilder.Construct().SetModel().SetColor().SetSpeed().SetAcceleration().GetCar();
                    sedanCar.ShowInfo();

                    break;
                case ModelType.Jeep:
                    ICarBuılder truckBuilder = new JeepModels();
                    Car truckCar = truckBuilder.Construct().SetModel().SetColor().GetCar();
                    truckCar.ShowInfo(); 
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            //Sedan tipinde bir araba oluşturmak için

//Truck tipinde bir araba oluşturmak için
        }
    }

    public enum ModelType
    {
        Sedan,
        Jeep
    }
}