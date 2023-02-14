using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMachine : MonoBehaviour
{

    public int PlayerState = 0;

    //UNCOMMENT ANIMATION
    //Animator anim;

    public int Cheese = 0;

    void Start()
    {
        PlayerState = 0;

        //UNCOMMENT ANIMATION
        //anim = GameObject.FindWithTag("tag_Arrow").GetComponent<Animator>();
    }

    private void Update()
    {
        //UNCOMMENT WIN CONDITION
        Debug.Log (Cheese);
    }

    // Function made public with 'internal'
   
   internal void ChangePlayerState()
    {
        if (PlayerState == 1)
        {
            GameObject.Find("GameMachine").GetComponent<GameMachine>().Cheese++;
          /*  {
            enter_sound.Play();
            stay_sound.Play();
            }
            */
        }

    }


    //UNCOMMENT WIN CONDITION
    
   internal void CheckWinCondition()
    {
        if (Cheese >=1)
        {
            Debug.Log("You Win!");
            GameObject.FindWithTag("tag_Win").GetComponent<MeshRenderer>().enabled = true;
        }
    }
  
}
