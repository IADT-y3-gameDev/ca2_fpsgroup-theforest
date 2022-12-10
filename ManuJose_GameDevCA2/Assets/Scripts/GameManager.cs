using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameOver = false;
    public void endGame()
    {
        if(gameOver == false){
            gameOver = true;
            Debug.Log("GAME OVER");
        }

    }
}
