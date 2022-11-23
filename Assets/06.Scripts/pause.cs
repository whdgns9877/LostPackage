using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Pausemenu, PauseButton;

    public void Pause()
    {
        Pausemenu.SetActive(true);
        PauseButton.SetActive(false);
        Time.timeScale = 0;          // pause button에 스크립트를 씌워서 버튼이 눌릴시 시간흐름을 0으로 설정(일시정지) 
    }

    public void Resume()
    {
        Pausemenu.SetActive(false);
        PauseButton.SetActive(true);
        Time.timeScale = 1;         // resume button에 스크립트를 씌워서 버튼이 눌릴시 시간흐름을 1로 원위치(일시정지 해제)
    }

    //public static bool GameIsPaused = false;

    //public GameObject pauseMenuUI;

    //// Update is called once per frame
    //void Update()
    //{
    //    if(GameIsPaused)
    //    {
    //        Resume();
    //    }
    //    else
    //    {
    //        Pause();
    //    }
    //}

    //void Resume()
    //{
    //    pauseMenuUI.SetActive(false);
    //    Time.timeScale = 1f;
    //    GameIsPaused = false;
    //}

    //void Pause()
    //{
    //    pauseMenuUI.SetActive(true);
    //    Time.timeScale = 0f;
    //    GameIsPaused = true;
    //}
}
