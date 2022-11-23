using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;

    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        scoreValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "score: " + scoreValue;        // 게임화면에 텍스트를 "Score: (현재 점수)"로 표시
        if (scoreValue >= 50)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);   // 점수가 100이상일 경우 다음씬으로 전환
    }
}
