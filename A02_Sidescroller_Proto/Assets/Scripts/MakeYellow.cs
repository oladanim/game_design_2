using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeYellow : MonoBehaviour
{
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {

            GameObject.Find("GameMachine").GetComponent<GameMachine>().PlayerState = 4;
            GameObject.Find("GameMachine").GetComponent<GameMachine>().ChangePlayerState();

            //alternatively, you can declare a variable that holds our GameMachine game object
            //then declare another variable that accesses the GameMachine script on it
            //so you can accesss the script directly

            /*
            GameObject GameMachine_GameObject = GameObject.Find("GameMachine");
            GameMachine GameMachine_GameObject_Script = GameMachine_GameObject.GetComponent<GameMachine>();
            GameMachine_GameObject_Script.PlayerState = 1;
            */

            //UNCOMMENT WIN CONDITION
            //GameObject.Find("GameMachine").GetComponent<GameMachine>().TotalCoins++;

            //UNCOMMENT WIN CONDITION
            //GameObject.Find("GameMachine").GetComponent<GameMachine>().CheckWinCondition();

            Destroy(gameObject);
        }

    }

}
