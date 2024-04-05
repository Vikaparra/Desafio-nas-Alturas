using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDoComputador : MonoBehaviour
{
    private Aviao aviao;
    [SerializeField]
    private float tempoEspera;
    // Start is called before the first frame update
    void Start()
    {
        this.aviao = this.GetComponent<Aviao>();
        StartCoroutine(this.Impulsionar());
    }

    // Update is called once per frame
    private IEnumerator Impulsionar()
    {
        while (true)
        {
            yield return new WaitForSeconds(tempoEspera);
            this.aviao.DarImpulso();
        }
    }
}
