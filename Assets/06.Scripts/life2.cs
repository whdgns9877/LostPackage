﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<PlayerHealth>().currentHealth <= 60)
        {
            GameObject.Destroy(gameObject);
        }
    }
}
