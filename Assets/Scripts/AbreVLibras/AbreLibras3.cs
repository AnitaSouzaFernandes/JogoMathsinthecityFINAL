using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreLibras3 : MonoBehaviour
{
    public GameObject VLibras3;


    void Start()
    {
        VLibras3.SetActive(false);

    }


    public void ShowVLibras3()
    {

        VLibras3.SetActive(true);

    }

    public void HideVLibras3()
    {
        VLibras3.SetActive(false);

    }
}
