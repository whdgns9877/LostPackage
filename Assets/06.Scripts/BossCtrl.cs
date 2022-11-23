using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossCtrl : MonoBehaviour
{
    public GameObject HitEffect;
    AudioSource audioSource;
    public Collider enemycollider;
    CharacterStatus status;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        status = GetComponent<CharacterStatus>();
    }

    void Update()
    {
        if (status.HP <= 0)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void DecreaseHP()
    {
        Instantiate(HitEffect, transform.position, transform.rotation);
        status.HP -= 50;
    }

  
    public void Destroy()
    {
        if (status.HP <= 0)
        {
            ScoreScript.scoreValue += 10;
            enemycollider.enabled = false;
            Destroy(gameObject, 5);
            //Invoke("Clear", 7);
        }
    }

    void Clear()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
