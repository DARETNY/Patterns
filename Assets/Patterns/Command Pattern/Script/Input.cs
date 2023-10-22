using Patterns.Command_Pattern.Script.Command;
using Patterns.Command_Pattern.Script.Eventhub;
using TMPro;
using UnityEngine;

namespace Patterns.Command_Pattern.Script
{
    public class Input : MonoBehaviour
    {
        private Camera _cameraMain;
        private Commandİnvoker _proggres;
        public Transform spawnedobjects;
        [SerializeField] private TextMeshProUGUI ınfo;

        private void Awake()
        {
            _cameraMain = Camera.main;
            _proggres = new Commandİnvoker();
        }

        private void Start()
        {
            ınfo.gameObject.SetActive(false);
        }


        private void Update()
        {
            if (UnityEngine.Input.GetMouseButtonDown(0))
            {
                Ray ray = _cameraMain.ScreenPointToRay(UnityEngine.Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    _proggres.ExecuteCommand(new SpawnedObjectCommand(hit.point, spawnedobjects.gameObject));
                }
            }
            else if (UnityEngine.Input.GetMouseButtonDown(1))
            {
                _proggres.UndoCommand();
            }
        }


      
    }
}