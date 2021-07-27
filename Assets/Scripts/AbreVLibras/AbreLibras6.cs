using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreLibras6 : MonoBehaviour
{
    public GameObject VLibras6;


    void Start()
    {
        VLibras6.SetActive(false);

    }


    public void ShowVLibras6()
    {

        VLibras6.SetActive(true);

    }

    public void HideVLibras6()
    {
        VLibras6.SetActive(false);

    }
}
