using UnityEngine;
using UnityEngine.AI;

namespace Interactables
{
    [RequireComponent(typeof(AudioSource))]
    public class Vacuum : MonoBehaviour
    {
        [Header("Vacuum SFX")]
        public AudioClip audioClip;

        private AudioSource _audioSource;
        
        [Space(5)]
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
            _audioSource = GetComponent<AudioSource>();
        }

        void OnTriggerEnter()
        {
            _audioSource.clip = audioClip;
            _audioSource.Play();
            ActivateVacuum = true;
        }
        void OnTriggerExit()
        {
            _audioSource.clip = null;
            _audioSource.Stop();
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
