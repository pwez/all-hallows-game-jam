using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Interactables
{
    public class Vacuum : MonoBehaviour
    {

        public Transform goal;
        [SerializeField] NavMeshAgent agent;

        // Start is called before the first frame update
        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
            agent.destination = goal.position;
        }

        // Update is called once per frame
        void Update()
        {
            agent.destination = goal.position;
        }
    }
}
