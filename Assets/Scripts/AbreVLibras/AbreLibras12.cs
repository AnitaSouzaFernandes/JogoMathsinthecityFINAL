using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreLibras12 : MonoBehaviour
{
    public GameObject VLibras12;


    void Start()
    {
        VLibras12.SetActive(false);

    }


    public void ShowVLibras12()
    {

        VLibras12.SetActive(true);

    }

    public void HideVLibras12()
    {
        VLibras12.SetActive(false);

    }
}
