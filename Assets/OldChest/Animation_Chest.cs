using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Chest : MonoBehaviour
{
    // Animator for controlling the chest animation
    private Animator anim;
    public AudioClip openSound;
    private AudioSource audioSource;

    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        // Grab the Animator component on this GameObject
        anim = GetComponent<Animator>();
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    // Trigger function when the chest detects the "Key" object
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object has the "Key" tag
        if (other.gameObject.CompareTag("Key"))
        {
            // Play the sound
            if (openSound != null)
            {
                audioSource.PlayOneShot(openSound);
            }
            // Trigger the animation transition
            anim.SetTrigger("closedtoopen");
            this.enabled = false; // Disable the script after use
        }
    }



}
