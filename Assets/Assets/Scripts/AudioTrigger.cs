using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    [Header("要撥放的音效")]
    public AudioSource audioSource;

    private AudioClip soundClip;

    private bool Playable = true;//偵測是否撥放

    void Awake()
    {
        soundClip = audioSource.clip;//同步AudioSource的Sound Clip
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!Playable) return;//防止重複撥放

        audioSource.Play();
        Playable = false;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Playable = true;
    }
}