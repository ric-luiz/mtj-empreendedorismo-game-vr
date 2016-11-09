using UnityEngine;
using System.Collections;

public class AnimacaoCamera : MonoBehaviour {

	public Animator controladorAnimacao;

	void Start () {
		controladorAnimacao.enabled = true;
		controladorAnimacao.Play ("camaToLeptop");
	}		

}
