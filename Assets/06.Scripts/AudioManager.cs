using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager _instance = null;
    public static AudioManager Instance { get; private set; } 

    private float _bgmVolume = 0.0f;
    public float BgmVolume
    {
        get { return _bgmVolume; }
        set
        {
            _bgmVolume = value;
            PlayerPrefs.SetFloat("BgmVolume", value);

            if (!ReferenceEquals(_bgmSource, null))
            {
                _bgmSource.volume = value;
            }
        }
    }

    [SerializeField]
    private GameObject _bgmSpeaker;

    private bool _spawnBgmSpeaker = false;
    private AudioSource _bgmSource;

    private void Awake()
    {
       
            Instance = this;
            _bgmVolume = PlayerPrefs.GetFloat("BgmVolume");
            DontDestroyOnLoad(this);
    }
    public void SpawnBgmSpeaker()
    {
        if (!_spawnBgmSpeaker)
        {
            GameObject bgmSpeaker = Instantiate(_bgmSpeaker);
            _bgmSource = bgmSpeaker.GetComponent<AudioSource>();
            _bgmSource.volume = BgmVolume;
            _bgmSource.Play();
            DontDestroyOnLoad(bgmSpeaker);
            _spawnBgmSpeaker = true;
        }
    }

    public void BGMStop()
    {
        _bgmSource.Stop();
    }

    public void BGMPlay()
    {
        _bgmSource.Play();
    }
}

