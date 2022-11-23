using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;
public class EnemyCtrl : MonoBehaviour
{
    public GameObject HitEffect;
    AudioSource audioSource;
    NavMeshAgent nvAgent;
    private Animator anim;
    public Collider enemycollider;
    CharacterStatus status;
    EnemyAI enemyAi;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        nvAgent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        status = GetComponent<CharacterStatus>();
        enemyAi = GetComponent<EnemyAI>();
        anim.SetBool("isRun", true);
        anim.SetBool("isAttack", false);
        anim.SetBool("isHit", false);
        anim.SetBool("isDie", false);

    }

    public void DecreaseHP()
    {
        Instantiate(HitEffect, transform.position, transform.rotation);
        anim.SetBool("isHit", true);
        Invoke("HitStop", 0.5f);
        status.HP -= 50;
    }

    public void HitStop()
    {
        anim.SetBool("isHit", false);
    }

    public void Destroy()
    {
        if (status.HP <= 0)
        {
            nvAgent.isStopped = true;
            nvAgent.SetDestination(transform.position);
            ScoreScript.scoreValue += 10;
            enemycollider.enabled = false;
            anim.SetBool("isAttack", false);
            anim.SetBool("isDie", true);
            Destroy(gameObject, 5);
        }
    }
}