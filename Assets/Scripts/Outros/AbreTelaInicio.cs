using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreTelaInicio : MonoBehaviour
{
    public GameObject TelaInicialPanel;

    public GameObject Texto1;
    public float tempo;
    private bool check;

    void Start()
    {
        TelaInicialPanel.SetActive(false);
        Texto1.SetActive(false);
    }

    public void Update()
    {
        if (Time.time >= tempo && check == true)
        {
            Texto1.SetActive(true);
            check = false;
        }
    }

    public void ShowTelaInicialPanel()
    {

         TelaInicialPanel.SetActive(true);
        tempo = Time.time + 1;
        Texto1.SetActive(false);
        check = true;

    }
    public void HideTelaInicialPanel()
    {
        TelaInicialPanel.SetActive(false);
    }

}
