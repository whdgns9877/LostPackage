using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<PlayerHealth>().currentHealth <= 20)
        {
            GameObject.Destroy(gameObject);
        }
    }
}
