using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Interactables
{
    public class Vacuum : MonoBehaviour
    {
        [SerializeField] bool activateVacuum = false;
        public bool ActivateVacuum
        {
            get { return activateVacuum;  }
            set { activateVacuum = value; }
        }
        [SerializeField] GameObject _vacuumZone;


        public Transform goal;
        [SerializeField] NavMeshAgent agent;

        // Start is called before the first frame update
        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
            //  agent.destination = goal.position;
        }

        void OnTriggerEnter()
        {
            ActivateVacuum = true;
        }
        void OnTriggerExit()
        {
            ActivateVacuum = false;
        }
        // Update is called once per frame
        void Update()
        {
            if (!ActivateVacuum) return;
            //if (!_vacuumZone.GetComponent<Zone>().InZone) return;

            agent.destination = goal.position;
        }
    }
}
