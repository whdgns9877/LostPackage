using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysLookPlayer_Stage1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.LookAt(new Vector3(0, -1, 0));
    }
}
