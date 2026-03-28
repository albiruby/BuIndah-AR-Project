using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource audioSource;

    private AudioClip currentClip;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void PlayOrToggle(AudioClip newClip)
    {
        if (currentClip == newClip)
        {
            if (audioSource.isPlaying)
                audioSource.Pause();
            else
                audioSource.Play();
        }
        else
        {
            audioSource.Stop();
            currentClip = newClip;
            audioSource.clip = newClip;
            audioSource.Play();
        }
    }
}