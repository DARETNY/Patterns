using UnityEngine;

namespace Patterns.Builder_Pattern.Scripts.Command
{
    public class Car
    {
        #region Variables -> You can use So or struct if you want

        public string Model { get; set; }
        public string Color { get; set; }
        public float Speed { get; set; }
        public float Acceleration { get; set; }

        #endregion

        public void ShowInfo()
        {
            Debug.Log($"Model: {Model}, Color: {Color}, Speed: {Speed}, Acceleration: {Acceleration} ");
        }
    }
}