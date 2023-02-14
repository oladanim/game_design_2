using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheese : MonoBehaviour
{
    public void OnTriggerEnter(Collider col)
    {
        if ((col.gameObject.tag == "Player") && (PlayerState == 1) )
        {

            Debug.Log("You Win!");
            GameObject.FindWithTag("tag_Win").GetComponent<MeshRenderer>().enabled = true;

        }

    }

}
