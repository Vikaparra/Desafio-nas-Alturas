using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour
{
    private float cronometro;
    [SerializeField] //faz aparecer na unity
    private float tempoParaGerarFacil = 5;
    [SerializeField] //faz aparecer na unity
    private float tempoParaGerarDificil = 1;
    [SerializeField] //faz aparecer na unity
    private GameObject manualDeInstrucoes;
    private ControleDeDificuldade controleDeDificuldade;
    private bool parado = false;

    private void Awake(){
        this.cronometro = this.tempoParaGerarFacil;
    }

    private void Start() {
        this.controleDeDificuldade = GameObject.FindObjectOfType<ControleDeDificuldade>();
    }

    void Update()
    {
        if (this.parado){
            return;
        }

        this.cronometro -= Time.deltaTime;
        if(this.cronometro <= 0){
            GameObject.Instantiate(this.manualDeInstrucoes, this.transform.position, Quaternion.identity);
            this.cronometro = Mathf.Lerp( this.tempoParaGerarFacil, this.tempoParaGerarDificil, this.controleDeDificuldade.Dificuldade);
        }
    }

    public void Parar(){
        this.parado = true;
    }
    public void Recomecar(){
        this.parado = false;
    }
}
