using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerDamage : MonoBehaviour
{

    [SerializeField] HealthBar healthBar;
    public int health = 10;

    private void Start()
    {
        ApplyDamage(0);
    }

    void ApplyDamage(int damage){
        if (healthBar != null && health > 0){
            health = health - damage;
            healthBar.SetHealth(health);
        } else if (health == 0){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
