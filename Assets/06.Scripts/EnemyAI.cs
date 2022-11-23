using UnityEngine;
using System.Collections;
using UnityEngine.AI;
using System;

public class EnemyAI : MonoBehaviour
{
    EnemyCtrl enemyCtrl;
    CharacterStatus status;
    public Transform target;
    NavMeshAgent nvAgent;
    private Animator anim;

    static float health = 100f;
    public bool canAttack = true;

    [SerializeField]
    float attackTime = 0.8f;
    public float damageAmount;
    

 
    // Use this for initialization
    void Start()
    {
        enemyCtrl = GetComponent<EnemyCtrl>();
        nvAgent = GetComponent<NavMeshAgent>();
        status = GetComponent<CharacterStatus>();
        anim = GetComponent<Animator>();
        anim.SetBool("isRun", true);
        anim.SetBool("isAttack", false);
        anim.SetBool("isHit", false);
        anim.SetBool("isDie", false);
    }

    // Update is called once per frame

    void Update()
    {
       // this.gameObject.transform.LookAt(new Vector3(0,-1,0));
        nvAgent.SetDestination(target.position);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AttackPlayer();
            anim.SetFloat("AttackSpeed", 0.75f);
            
        }
    }
    void Die()
    {
        if (status.HP <= 0)
        {
            gameObject.GetComponent<NavMeshAgent>().isStopped = true;
        }
    }

    void AttackPlayer()
    {
        gameObject.GetComponent<NavMeshAgent>().isStopped = true;
        anim.SetBool("isRun", false);
        anim.SetBool("isAttack", true);

        StartCoroutine(AttackTime());
        nvAgent.avoidancePriority = 49;
    }

    IEnumerator AttackTime()
    {
        while (health >= 0)
        {
            canAttack = false;
            yield return new WaitForSeconds(0.5f);
            PlayerHealth.singleton.PlayerDamage(damageAmount);
            yield return new WaitForSeconds(attackTime);
            canAttack = true;

            if(status.HP<=0)
            {
                break;
            }
        }

    }
}


