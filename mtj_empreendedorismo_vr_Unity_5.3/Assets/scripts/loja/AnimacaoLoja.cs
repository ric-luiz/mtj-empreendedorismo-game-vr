using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AnimacaoLoja : MonoBehaviour {
	//placas de voltar a serem ativadas e desativadas
	public GameObject placaVoltarCarrinho;

	//Animator dos objetos
	public Animator animatorLoja;
	private Animator animatorCamera;

	void Start () {
		animatorCamera = Camera.main.gameObject.GetComponent<Animator> ();
	}

	//Faz o jogador entrar na loja. Ativa animações da camera e da loja
	public void entrarLoja(){
		habilitarAnimatorLoja ();
		habilitarAnimatorCamera();
		animatorCamera.Play ("EntrarLoja");
		animatorLoja.Play ("porta1");
	}

	//Faz o Personagem chegar ate o carrinho
	public void verCarrinho(){
		habilitarAnimatorCamera();
		placaVoltarCarrinho.SetActive(true);
		animatorCamera.Play ("VerCarrinho");
	}

	// faz a animação para o jogador voltar para o inicio da loja
	public void voltarDoCarrinho(){
		habilitarAnimatorCamera();
		placaVoltarCarrinho.SetActive(false);
		animatorCamera.Play ("VoltarDoCarrinho");
	}

	public void voltarQuarto(){
		SceneManager.LoadScene ("quarto",LoadSceneMode.Single);
	}

	private void habilitarAnimatorCamera(){
		animatorCamera.enabled = true;
	}

	private void habilitarAnimatorLoja(){
		animatorLoja.enabled = true;
	}		
}
