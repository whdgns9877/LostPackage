using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth singleton;
    public float currentHealth;
    public float maxHealth = 100f;
   
   

    private void Awake()
    {
        singleton = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
        currentHealth = maxHealth;
        
        
    }


    public void PlayerDamage(float damage)
    {
        currentHealth -= damage;
        

       
        if(currentHealth<=0)
        {
            SceneManager.LoadScene("Game_Over");
        }
    }

   
   

}
