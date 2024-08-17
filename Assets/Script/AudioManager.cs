using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    [SerializeField] public AudioClip score_Clip;
    [SerializeField] public AudioClip jump_Clip;
    [SerializeField] public AudioSource audio_Source;
    [SerializeField] public AudioClip die_Clip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        audio_Source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayScoreClip()
    {
        audio_Source.PlayOneShot(score_Clip);
    }
    public void PlayJumpClip()
    {
        audio_Source.PlayOneShot(jump_Clip);
    }
    public void PlayDieClip()
    {
        audio_Source.PlayOneShot(die_Clip);
        
    }
}
