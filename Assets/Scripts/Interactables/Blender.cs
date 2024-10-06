using UnityEngine;

namespace Interactables {
    
    [RequireComponent(typeof(AudioSource))]
    public class Blender : MonoBehaviour {

        [Header("Parameters")] 
        public AudioClip blendingAudioClip;

        private Animator _animator;
        private AudioSource _audioSource;

        private void Awake() {
            _audioSource = GetComponent<AudioSource>();
            _animator = GetComponent<Animator>();
        }

        public void Start() {
            _animator.Play("being-scary");
            TurnOff();
        }

        public void TurnOn() {
            _audioSource.clip = blendingAudioClip;
            _audioSource.time = 1.3f;
            _audioSource.Play();
        }
        
        public void TurnOff() {
            _audioSource.Stop();
            _audioSource.clip = null;
        }
        
    }

}