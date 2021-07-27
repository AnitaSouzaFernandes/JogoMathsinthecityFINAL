using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbreTexto2 : MonoBehaviour
{
    public GameObject Texto2;

    void Start()
    {
        Texto2.SetActive(false);
    }

    public void ShowTexto2Image()
    {
        Texto2.SetActive(true);

    }
    public void HideTexto2Image()
    {
        Texto2.SetActive(false);

    }

}
