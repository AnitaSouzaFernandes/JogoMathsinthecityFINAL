using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreLibras2 : MonoBehaviour
{
    public GameObject VLibras2;


    void Start()
    {
        VLibras2.SetActive(false);

    }


    public void ShowVLibras2()
    {

        VLibras2.SetActive(true);

    }

    public void HideVLibras2()
    {
        VLibras2.SetActive(false);

    }
}
