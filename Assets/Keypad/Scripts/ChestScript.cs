using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
public class ChestScript : MonoBehaviour {

    [SerializeField] private GameObject chest;
    
    public void OpenChest() {
        if (chest != null)
            {
                Animation_Chest chestScript = chest.GetComponent<Animation_Chest>();
                if (chestScript != null)
                {
                    chestScript.OpenChest();
                }
            }

    }

    

}