using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{

    private int hitNumber;
    int killCount;
    public string killCounter;

    void Start()
    {
        //killCounter = GetComponent<TMPro.TextMeshProUGUI>().text;
        killCount = 0;
        Debug.Log(killCount);
    }

    private void OnEnable(){
        hitNumber = 0;
    }

    // Start is called before the first frame update
    void OnCollisionEnter(Collision other)
    {


        if(other.transform.CompareTag("bullet")){
            hitNumber++;
        }

        if(hitNumber == 3){
            killCount = killCount + 1;
            //killCounter = killCount.ToString();
            gameObject.SetActive(false);    
            Debug.Log(killCount);      
        }

    }
}
