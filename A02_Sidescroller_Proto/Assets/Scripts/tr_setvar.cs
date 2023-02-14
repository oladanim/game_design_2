using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tr_setvar : MonoBehaviour
{
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            GameObject.Find("GameMachine").GetComponent<GameMachine>().PlayerState = 1;
            GameObject.Find("GameMachine").GetComponent<GameMachine>().ChangePlayerState();
            

        }

    }
}
