using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlayerSoundManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip scaredAudioClip;

    public void PlayScaredSoundEffect() {
        audioSource.clip = scaredAudioClip;
        audioSource.Play();
    }
}
