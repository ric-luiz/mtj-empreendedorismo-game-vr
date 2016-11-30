using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AnimacaoBanco : MonoBehaviour {

	private Animator mainCameraAnimator;
	bool foiParaCaixa = false;

	void Start(){
		mainCameraAnimator = Camera.main.gameObject.GetComponent<Animator> (); //Pegar animator da camera principal
	}

	public void TrazerCameraToCaixa(){
		if(!foiParaCaixa){
			foiParaCaixa = true;
			mainCameraAnimator.enabled = true;
			mainCameraAnimator.Play ("andarToCaixa");	
		}
	}
		
	public void voltarQuarto(){
		SceneManager.LoadScene ("quarto",LoadSceneMode.Single);
	}
}
