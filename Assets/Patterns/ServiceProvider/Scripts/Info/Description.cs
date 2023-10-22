using UnityEngine;

namespace Patterns.ServiceProvider.Scripts.Info
{
    public class Description : MonoBehaviour
    {
        private readonly string _gameInfo = "This is just a short sample for managing services(managers) in Unity" +
                                            " Check the console for more info.";

        private void OnGUI()
        {
            GUILayout.Label("Service Provider", GUILayout.Width(200));
            GUILayout.Label(_gameInfo, GUILayout.ExpandWidth(true));
        }
    }
}