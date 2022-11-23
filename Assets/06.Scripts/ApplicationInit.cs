using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplicationInit : MonoBehaviour
{
    void Awake()
    {
      //  Screen.SetResolution(720, 360, true);
    }
    private void Start()
    {
        SceneManager.LoadScene("Main");
    }
}