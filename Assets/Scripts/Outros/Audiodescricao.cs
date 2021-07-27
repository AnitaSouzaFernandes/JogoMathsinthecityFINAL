using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audiodescricao : MonoBehaviour
{
    public GameObject Panel;
    public Button Sim;
    public Button Nao;


    void Start()
    {
        Panel.SetActive(true);
    }

    public void HidePanel()
    {
        Panel.SetActive(false);

    }
}
