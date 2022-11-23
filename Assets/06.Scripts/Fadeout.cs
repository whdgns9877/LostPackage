using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Fadeout : MonoBehaviour
{
    public Image ImageFade;
 
    // Start is called before the first frame update
    void Start()
    {
        ImageFade.canvasRenderer.SetAlpha(1f); // 씬이 시작할때의 이미지 투명도 설정 (0~1)
        
        
        fadeout();
        
    }

    // Update is called once per frame
    void fadeout()
    {
        ImageFade.CrossFadeAlpha(0, 3, false); // 1은 시작 투명도에서부터 도달할 도착 투명도 , 3은 도달 할 때까지 걸리는 시간(초)
    }

    


}
