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
            _animator.Play("idle");
            TurnOff();
        }

        public void TurnOn() {
            _audioSource.clip = blendingAudioClip;
            _audioSource.time = 1.3f;
            _audioSource.Play();
            _animator.Play("being-scary");
        }
        
        public void TurnOff() {
            _audioSource.Stop();
            _audioSource.clip = null;
            _animator.Play("idle");
        }

        public void Disable() {
            Destroy(gameObject);
        }

    }

}