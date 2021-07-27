using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreLibras15 : MonoBehaviour
{
    public GameObject VLibras15;


    void Start()
    {
        VLibras15.SetActive(false);

    }


    public void ShowVLibras15()
    {

        VLibras15.SetActive(true);

    }

    public void HideVLibras15()
    {
        VLibras15.SetActive(false);

    }
}
