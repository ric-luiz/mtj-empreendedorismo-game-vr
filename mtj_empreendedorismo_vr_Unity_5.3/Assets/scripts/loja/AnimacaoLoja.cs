using UnityEngine;
using System.Collections;

public class AnimacaoLoja : MonoBehaviour {

	public Animator animatorLoja;
	private Animator animatorCamera;

	void Start () {
		animatorCamera = Camera.main.gameObject.GetComponent<Animator> ();
		//animacao.Play ("porta1");
	}

	//Faz o jogador entrar na loja. Ativa animações da camera e da loja
	public void entrarLoja(){
		animatorLoja.enabled = true;
		animatorCamera.enabled = true;
		animatorCamera.Play ("EntrarLoja");
		animatorLoja.Play ("porta1");
	}

	public void verCarrinho(){
		animatorCamera.enabled = true;
		animatorCamera.Play ("VerCarrinho");
	}
}
