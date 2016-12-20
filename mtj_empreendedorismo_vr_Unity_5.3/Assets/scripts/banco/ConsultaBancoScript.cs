using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Linq;

public class ConsultaBancoScript : MonoBehaviour {
    public GameObject saldo_click;
    public GameObject extrato_click;
    public GameObject rendimento_click;
    public GameObject TirarDinheiro;
    public int x = 0;
    public Text saldoTexto = null;
    public Text extratoTexto = null;
    public Text rendimentoTexto = null;
    public int saldo = 100;

    void Start()
    {
        saldoTexto = GetComponent<Text>();
        extratoTexto = GetComponent<Text>();
        rendimentoTexto = GetComponent<Text>();
    }
    public void ClicarSaldo() {
        saldo_click.SetActive(!saldo_click.activeSelf);
        saldoTexto.text = saldo.ToString();
    }
    public void ClicarBotão()
    {
       saldo = saldo - 10;
        x = x+1;
    }
    public void ClicarExtrato()
    {
        extrato_click.SetActive(!extrato_click.activeSelf);
        extratoTexto.text = (string.Concat(Enumerable.Repeat("-10"+"\n",x)) + ("\n" + "Seu saldo é: " + saldo.ToString()));

    }
    //testar extrato
    //poupança

}
