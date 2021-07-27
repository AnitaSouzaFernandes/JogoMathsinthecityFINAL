using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreLibras11 : MonoBehaviour
{
    public GameObject VLibras11;


    void Start()
    {
        VLibras11.SetActive(false);

    }


    public void ShowVLibras11()
    {

        VLibras11.SetActive(true);

    }

    public void HideVLibras11()
    {
        VLibras11.SetActive(false);

    }
}
