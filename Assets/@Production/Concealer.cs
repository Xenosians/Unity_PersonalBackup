using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Concealer : MonoBehaviour
{
    /*private GameObject secretRoom = null;
    private GameObject playerObj = null;*/
    /*public float Opacity = .5f;*/ 
    public GameObject concealer;
    

  
    /*private void Start()
    {
        if (playerObj == null)
            playerObj = GameObject.FindGameObjectWithTag("Player");
        if (secretRoom == null)
            secretRoom = GameObject.FindGameObjectWithTag("SecretRoom");
    }*/

    private void OnTriggerEnter2D(Collider2D SecretRoom)
    {
        if (SecretRoom.CompareTag("Player") && !SecretRoom.isTrigger)
        {
            concealer.SetActive(false);
        }
    }
    private void OnTriggerExit2D(Collider2D SecretRoom)
    {
        if (SecretRoom.CompareTag("Player") && !SecretRoom.isTrigger)
        {
            concealer.SetActive(true);
        }
    }
    /*private void increaseOpacity()
    {
        Opacity += 1.0f;
    }

    private void decreaseOpacity()
    {
        Opacity -= 1.0f;
    }*/
   

  

}
