using UnityEngine;
using System.Collections;

public class IntroducaoScript : MonoBehaviour {

    public AudioClip sound1; //Audio do primeiro roteiro
	public AudioClip sound2; //Audio do segundo roteiro

    public float volume;
    AudioSource audio;
    bool soundplayed1 = false; //tocou o roteiro 1?
	bool soundplayed2 = false; //tocou o roteiro 2?
    
	void Start() {
		audio = Camera.main.gameObject.GetComponent<AudioSource>();
    }

	//Audio corresponde ao primeiro Roteiro. "Que legal ganhei dinheiro de preset..."
   	public void IniciarAudio() {
        if (!soundplayed1) {
            audio.PlayOneShot(sound1, volume);
            soundplayed1 = true;
        }
    }

	//Audio corresponde ao segundo Roteiro. "Vou investir esse dinheiro..."
	public void IniciarAudio2(){
		if (!soundplayed2 && soundplayed1) {
			audio.PlayOneShot(sound2, volume);
			soundplayed2 = true;
		}
	}
}
