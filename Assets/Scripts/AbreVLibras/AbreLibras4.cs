using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreLibras4 : MonoBehaviour
{
    public GameObject VLibras4;


    void Start()
    {
        VLibras4.SetActive(false);

    }


    public void ShowVLibras4()
    {

        VLibras4.SetActive(true);

    }

    public void HideVLibras4()
    {
        VLibras4.SetActive(false);

    }
}
