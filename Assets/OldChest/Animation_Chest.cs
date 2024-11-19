using System.Collections;
using UnityEngine;

public class Animation_Chest : MonoBehaviour
{
    // Animator for controlling the chest animation
    private Animator anim;
    public AudioClip openSound;
    private AudioSource audioSource;

    private bool isOpen = false;

    private void Awake()
    {
        // Grab the Animator component on this GameObject
        anim = GetComponent<Animator>();
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    // Method to open the chest
    public void OpenChest()
    {
        if (isOpen) return; // Prevent multiple openings

        isOpen = true;

        // Play the sound
        if (openSound != null)
        {
            audioSource.PlayOneShot(openSound);
        }

        // Trigger the animation transition
        anim.SetTrigger("closedtoopen");
    }
}
