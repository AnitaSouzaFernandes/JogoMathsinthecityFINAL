using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbreTexto1TI : MonoBehaviour
{
    public GameObject Texto1;


    void Start()
    {
        Texto1.SetActive(false);
    }


    public void ShowTexto1Image()
    {

        Texto1.SetActive(true);

    }

    public void HideTexto1Image()
    {
        Texto1.SetActive(false);

    }
}
