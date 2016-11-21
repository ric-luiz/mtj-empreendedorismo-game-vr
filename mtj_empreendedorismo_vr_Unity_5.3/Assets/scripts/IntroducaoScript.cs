using UnityEngine;
using System.Collections;

public class IntroducaoScript : MonoBehaviour {

    public AudioClip sound;
    public float volume;
    AudioSource audio;
    public bool soundplayed = false;
    void Start() {
        audio = GetComponent<AudioSource>();
    }
   public void OnEnterTrigger() {
        if (!soundplayed) {
            audio.PlayOneShot(sound, volume);
            soundplayed = true;
        }
    }
}
