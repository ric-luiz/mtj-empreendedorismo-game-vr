using UnityEngine;
using System.Collections;

public class MenuMural : MonoBehaviour {

	private Animator mainCameraAnimator;
	private bool mural = false;
	private bool lepTop = false;
	private bool porta = false;

	void Start () {
		mainCameraAnimator = Camera.main.gameObject.GetComponent<Animator> (); //Pegar animator da camera principal
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Função para realizar a função da camera ir ate o mural
	public void trazerCameraAteMural(){		
		resetarStatus ();
		this.mural = true;
		mainCameraAnimator.enabled = true;
		mainCameraAnimator.Play ("camaToMural");
	}

	//Função para realizar a função da camera ir ate o LepTop
	public void trazerCameraAteLepTop(){
		resetarStatus ();
		this.lepTop = true;
		mainCameraAnimator.enabled = true;
		mainCameraAnimator.Play ("camaToLeptop");
	}

	//Função para realizar a função da camera ir ate a porta
	public void trazerCameraAtePorta(){
		mainCameraAnimator.enabled = true;
		mainCameraAnimator.Play ("camaToPorta");
	}

	//Função para realizar a função da camera ir do Mural para a Cama
	public void trazerCameraAteMuralToCama(){
		if(this.mural){
			mainCameraAnimator.enabled = true;
			mainCameraAnimator.Play ("muralToCama");
		}
	}

	//Função para realizar a função da camera ir do LepTop para a Cama
	public void trazerCameraAteLeptopToCama(){
		if(this.lepTop){
			mainCameraAnimator.enabled = true;
			mainCameraAnimator.Play ("leptopToCama");
		}
	}

	//Reseta os Status de onde a camera está
	void resetarStatus(){
		this.mural = false;
		this.lepTop = false;
		this.porta = false;
	}
}
