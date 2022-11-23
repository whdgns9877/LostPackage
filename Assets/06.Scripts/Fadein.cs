using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Fadein : MonoBehaviour
{
    public Image ImageFade;
    public Image buttonFade;
    public Image button2Fade;
    public float Imagetime;
    public float buttontime;
    // Start is called before the first frame update
    void Start()
    {
        ImageFade.canvasRenderer.SetAlpha(0.0f); // 씬이 시작할때의 이미지 투명도 설정 (0~1)
        buttonFade.canvasRenderer.SetAlpha(0.0f);
        button2Fade.canvasRenderer.SetAlpha(0.0f);
        fadeIn();
        buttonfadein();
    }

    // Update is called once per frame
    void fadeIn()
    {
        ImageFade.CrossFadeAlpha(1, Imagetime, false); // 1은 시작 투명도에서부터 도달할 도착 투명도 , 3은 도달 할 때까지 걸리는 시간(초)
    }

    void buttonfadein()
    {
        buttonFade.CrossFadeAlpha(1, buttontime, false);
        button2Fade.CrossFadeAlpha(1, buttontime, false);
    }

    
}
