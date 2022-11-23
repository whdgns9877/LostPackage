using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossMoveCtrl : MonoBehaviour
{
    CharacterStatus cs;
    EnemyCtrl enemyctrl;
    public Transform[] points;
    public int nextIdx = 1;
    public float speed = 10.0f;
    public float damping = 5.0f;

    private Transform tr;
    // Start is called before the first frame update
    void Start()
    {
        cs = GetComponent<CharacterStatus>();
        enemyctrl = GetComponent<EnemyCtrl>();
        tr = GetComponent<Transform>();
        points = GameObject.Find("BossWayPointGroup").GetComponentsInChildren<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion rot = Quaternion.LookRotation(points[nextIdx].position - tr.position);
        tr.rotation = Quaternion.Slerp(tr.rotation, rot, Time.deltaTime * damping);
        tr.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "WAY_POINT")
        {
            nextIdx = (++nextIdx >= points.Length) ? 1 : nextIdx;
        }
    }
    void DestroyBoss()
    {
        if(cs.HP <= 0)
        {
            Destroy(gameObject, 5.0f);
           
        }
    }
  
}
