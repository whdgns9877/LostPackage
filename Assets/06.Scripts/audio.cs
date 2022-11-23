using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    //static이 아니면 스크립트 생성시마다
    //새로운 인스턴스가 만들어지므로 싱글톤 불가
    static audio instance;

    // Start is called before the first frame update

   

    public static audio Instance
    {
        get
        {
            return instance;
        }
    }
    private void Awake()
    {
        if (instance == null)   //instance가 null이면 오브젝트 유지
        {

            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else  //instance가 null이 아니면 오브젝트 파괴
        {
            Destroy(this.gameObject);
        }
    }
}





//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class audio : MonoBehaviour
//{

//    // Start is called before the first frame update
//    void Start()
//    {

//        DontDestroyOnLoad(gameObject);
//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }
//}
