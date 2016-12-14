using UnityEngine;
using System.Collections;

public class IntroducaoScript : MonoBehaviour {

    public AudioClip sound1F;//Audio do primeiro roteiro feminino
    public AudioClip sound1M;//Audio do primeiro roteiro masculino
    public AudioClip sound2F; //Audio do segundo roteiro feminino
    public AudioClip sound2M; //Audio do segundo roteiro masculino

    public float volume;
    AudioSource audio;
    bool soundplayed1F = false; //tocou o roteiro 1 (feminino)?
    bool soundplayed2F = false; //tocou o roteiro 2 (feminino)?
    bool soundplayed1M = false; //tocou o roteiro 1 (masculino)?
    bool soundplayed2M = false; //tocou o roteiro 2 (masculino)?
    bool clickfeminino = false;
    void Start() {
		audio = Camera.main.gameObject.GetComponent<AudioSource>();
    }
    public void TriggerFeminino() {
       
    }
    public void IniciarAudioF() {
        if (clickfeminino == true)
        {
            if (!soundplayed1F)
            {
                audio.PlayOneShot(sound1F, volume);
                soundplayed1F = true;
            }
        }
        else
        {
            if (!soundplayed1M)
            {
                audio.PlayOneShot(sound1M, volume);
                soundplayed1M = true;
            }
        }
       }
    //Audio corresponde ao segundo Roteiro. "Vou investir esse dinheiro..."
    public void IniciarAudio2() {
        if (clickfeminino == true)
        {
            if (!soundplayed2F)
            {
                audio.PlayOneShot(sound2F, volume);
                soundplayed2F = true;
            }
        }
        else
        {
            if (!soundplayed2M)
            {
                audio.PlayOneShot(sound2M, volume);
                soundplayed2M = true;
            }
        }
    }

    }

