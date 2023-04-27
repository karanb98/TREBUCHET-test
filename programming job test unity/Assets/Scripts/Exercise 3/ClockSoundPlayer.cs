using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockSoundPlayer : MonoBehaviour
{
    public AudioClip clockAddedSound;

    private AudioSource audioSource;

    private void Start()
    {
        // Get the AudioSource component.
        audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        // Listen to the onClockAdded event.
        FindObjectOfType<ClockManagerNew>().onClockAdded.AddListener(PlayClockAddedSound);
    }

    private void OnDisable()
    {
        // Stop listening to the onClockAdded event.
        FindObjectOfType<ClockManagerNew>().onClockAdded.RemoveListener(PlayClockAddedSound);
    }

    private void PlayClockAddedSound()
    {
        // Play the clock added sound.
        audioSource.PlayOneShot(clockAddedSound);
    }
}
