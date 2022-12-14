using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour
{

    Slider healthSlider;

    // Start is called before the first frame update
    void Start()
    {
        healthSlider = GetComponent<Slider>();
    }
    
    public void SetMaxHealth(int maxHealth)
    {
        healthSlider.maxValue = maxHealth;
        healthSlider.value = maxHealth;
    }

    public void SetHealth(int health)
    {
        healthSlider.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
