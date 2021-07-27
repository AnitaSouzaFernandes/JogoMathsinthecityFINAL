using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreLibras14 : MonoBehaviour
{
    public GameObject VLibras14;


    void Start()
    {
        VLibras14.SetActive(false);

    }


    public void ShowVLibras14()
    {

        VLibras14.SetActive(true);

    }

    public void HideVLibras14()
    {
        VLibras14.SetActive(false);

    }
}
