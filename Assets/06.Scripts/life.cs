using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(FindObjectOfType<PlayerHealth>().currentHealth <= 80)
         {
            GameObject.Destroy(gameObject);
        }
    }
}
