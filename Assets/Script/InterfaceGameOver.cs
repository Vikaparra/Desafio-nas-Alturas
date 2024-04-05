using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceGameOver : MonoBehaviour
{
    [SerializeField]
    private Text valorRecorde;
    [SerializeField]
    private Image posicaoMedalha;
    [SerializeField]
    private Sprite medalhaOuro;
    [SerializeField]
    private Sprite medalhaPrata;
    [SerializeField]
    private Sprite medalhaBronze;
    [SerializeField]
    private GameObject imagemGameOver;
    private int recorde;
    private Pontuacao pontuacao;

    private void Start()
    {
        this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();
    }
    public void MostrarInterface()
    {
        this.AtualizarInterfaceGrafica();
        this.imagemGameOver.SetActive(true);
    }

    public void EsconderInterface()
    {
        this.imagemGameOver.SetActive(false);
    }
    private void AtualizarInterfaceGrafica()
    {
        this.recorde = PlayerPrefs.GetInt("recorde");
        this.valorRecorde.text = recorde.ToString();

        this.VerificarCorMedalha();
    }

    private void VerificarCorMedalha()
    {
        if (this.pontuacao.Pontos > this.recorde - 2)
        {
            this.posicaoMedalha.sprite = this.medalhaOuro;
        }
        else if (this.pontuacao.Pontos > this.recorde / 2)
        {
            this.posicaoMedalha.sprite = this.medalhaPrata;
        }
        else
        {
            this.posicaoMedalha.sprite = this.medalhaBronze;
        }
    }
}
