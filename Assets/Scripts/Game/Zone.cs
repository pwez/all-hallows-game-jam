using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


namespace Interactables
{
    public class Zone : MonoBehaviour
    {
        [SerializeField] Vacuum _vacuum;
        [SerializeField] bool inZone = false;
        public bool InZone
        {
            get { return inZone; }
            set { inZone = value; }
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void onTriggerEnter(Collider other)
        {
            InZone = true;
        }
        private void OnTriggerExit(Collider other)
        {
            _vacuum.ActivateVacuum = false;
            InZone = false;
        }
    }
}