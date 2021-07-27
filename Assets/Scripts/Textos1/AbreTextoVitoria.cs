using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreTextoVitoria : MonoBehaviour
{
    public GameObject PanelTelaVitoria;
    public GameObject GameController;
    public GameObject Texto2;

    void Start()
    {
        Texto2.SetActive(false);
    }

    public void ShowTexto2Image()
    {
        Texto2.SetActive(true);

        if (PanelTelaVitoria.activeSelf == true)
        {
            GameController.GetComponent<CalculoPontos>().ApareceSom();
        }
    }
    public void HideTexto2Image()
    {
        Texto2.SetActive(false);
    }
}
