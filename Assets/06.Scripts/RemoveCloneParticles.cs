using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveCloneParticles : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
#pragma warning disable CS0618 // 형식 또는 멤버는 사용되지 않습니다.
        Destroy(gameObject, t: gameObject.GetComponent<ParticleSystem>().duration + 1f);
#pragma warning restore CS0618 // 형식 또는 멤버는 사용되지 않습니다.
    }
}
