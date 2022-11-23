using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveStage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("MoveScene", 5);
    }

    // Update is called once per frame
    public void MoveScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
