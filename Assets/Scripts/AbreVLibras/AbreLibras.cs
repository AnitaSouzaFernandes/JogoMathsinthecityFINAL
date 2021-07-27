using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreLibras : MonoBehaviour
{
    public GameObject VLibras1;


    void Start()
    {
        VLibras1.SetActive(false);

    }


    public void ShowVLibras1()
    {

        VLibras1.SetActive(true);

    }

    public void HideVLibras()
    {
        VLibras1.SetActive(false);

    }
}
