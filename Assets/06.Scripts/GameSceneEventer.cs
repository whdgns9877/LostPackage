using UnityEngine;
using UnityEngine.UI;

public class GameSceneEventer : MonoBehaviour
{
    [SerializeField]
    private Slider _slider;
   

    public void ChangeSliderValue()
    {
        AudioManager.Instance.BgmVolume = _slider.value;
    }
   

    private void Awake()
    {
        AudioManager.Instance.SpawnBgmSpeaker();
    }
      
}
