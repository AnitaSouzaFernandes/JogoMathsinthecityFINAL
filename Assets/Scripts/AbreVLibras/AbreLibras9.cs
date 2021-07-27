using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreLibras9 : MonoBehaviour
{
    public GameObject VLibras9;


    void Start()
    {
        VLibras9.SetActive(false);

    }


    public void ShowVLibras9()
    {

        VLibras9.SetActive(true);

    }

    public void HideVLibras9()
    {
        VLibras9.SetActive(false);

    }
}
