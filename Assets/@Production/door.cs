using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class door : MonoBehaviour
{
    public int LeveltoLoad;
    private gameMaster gm;

    private void Start()
    {
        gm = GameObject.Find("MainGame").GetComponent<gameMaster>();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            gm.inputText.text = ("[E] To Enter");
            if (Input.GetKeyDown("e"))
            {
                Application.LoadLevel(LeveltoLoad);
            }
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (Input.GetKeyDown("e"))
            {
                Application.LoadLevel(LeveltoLoad);
            }
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            gm.inputText.text = (" ");
        }
    }

}
