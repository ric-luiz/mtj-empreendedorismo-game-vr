using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class AnimacaoController : MonoBehaviour {
    private Animator mainCameraAnimator;
	private bool mural = false;
	private bool lepTop = false;
	private bool porta = false;

    private bool jogoIniciado = false; //O jogador já clicou no botão start?
	private bool SegundoAudioIntrodutorioPassado = false; //O audia 2 da introdução foi passado?

	//as 2 variaveis são referentes ao leptop
	public GameObject leptopBrilho;
	public GameObject leptopTela;
    //Creditos
    public GameObject Creditos_Click;

	void Start () {
		mainCameraAnimator = Camera.main.gameObject.GetComponent<Animator> (); //Pegar animator da camera principal
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
		
	//Quando o jogador clica no posit start
	public void iniciar(){
		if(!this.jogoIniciado){
			this.jogoIniciado = true; //jogo iniciado
			leptopTela.SetActive (true); //habilita a tela
			leptopBrilho.SetActive (true); //habilita o brilho do lepTop
			trazerCameraAteMuralToCama();
        }
	}
	//Quando o jogador clica na opção exit nas opções do leptop
	public void sairProximaCena(){
		SceneManager.LoadScene ("limbo",LoadSceneMode.Single);
	}

	//Troca de cena. Vai para a cena do banco
	public void sairToBanco(){
		SceneManager.LoadScene ("banco",LoadSceneMode.Single);
	}

    public void creditos() {
		Creditos_Click.SetActive(!Creditos_Click.activeSelf);        
    }
}
