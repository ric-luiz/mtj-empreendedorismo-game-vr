using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Linq;

public class ConsultaBancoScript : MonoBehaviour {
    public GameObject saldo_click;
    public GameObject extrato_click;
    public GameObject rendimento_click;
    public GameObject TirarDinheiro; //botão que retira 10 de saldo se clicado
    public int x = 0; // vezes que o botão TirarDinheiro foi clicado
    private bool RendButtonClicked = false; // o botão para calcular o Rendimento foi clicado?
    public Text saldoTexto = null;
    public Text extratoTexto = null;
    public Text rendimentoTexto = null;
    public int saldo = 100; //total de saldo pre-definido
    public double rend; // rendimento 

    void Start()
    {
        saldoTexto = GetComponent<Text>();
        extratoTexto = GetComponent<Text>();
        rendimentoTexto = GetComponent<Text>();
    }
     public void ClicarBotão()
    {
       saldo = saldo - 10; //se clicar no butão Retirar10
        x = x+1; //numero de vezes que o botão foi clicado para apresentar no extrato => Ver ClicarExtrato()
    }
    public void ClicarSaldo() {
        saldo_click.SetActive(!saldo_click.activeSelf);
        saldoTexto.GetComponent<Text>().text = saldo.ToString();
    }
   
    public void ClicarExtrato()
    {
        extrato_click.SetActive(!extrato_click.activeSelf);
        extratoTexto.GetComponent<Text>().text = (string.Concat(Enumerable.Repeat("-10"+"\n",x)) + ("\n" + "Seu saldo é: " + saldo.ToString()));
        //A informação -10 é repetida o numero de vezes que o botão Retirar10 foi clicado

    }
    public void ClicarButtonRendimento() {
        rend = (0.02 * saldo) + saldo; //calculo de 2%
        RendButtonClicked = true; 
    }
    public void ClicarRendimento() {
        rendimento_click.SetActive(!rendimento_click.activeSelf);
        if (RendButtonClicked == true) {
            rendimentoTexto.GetComponent<Text>().text = ("Seu rendimento é: " + rend.ToString());
        }
        else
        {
            rendimentoTexto.GetComponent<Text>().text = ("Seu rendimento é: " + saldo.ToString());
        }

    }

}
