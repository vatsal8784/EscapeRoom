using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Animation_Chest : MonoBehaviour {
    //create player for finding the controller and Anim for animator
    Player player;
    Animator anim;

    //Awake would setup the values when the game started
    private void Awake()
    {
        //grab the player object from player 
        player = GameObject.Find("Player").GetComponent<Player>();
        //grab the animator object from it is own project
        anim = GetComponent<Animator>();
    }

    //function that would call when the chest is interact with the key
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            //trigger the animation to true so that it will play the animation
            //anim.SetBool("Open_chest", true);
            anim.SetTrigger("closedtoopen");
        }
    }
}
