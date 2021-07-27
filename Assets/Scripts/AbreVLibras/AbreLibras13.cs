using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreLibras13 : MonoBehaviour
{
    public GameObject VLibras13;


    void Start()
    {
        VLibras13.SetActive(false);

    }


    public void ShowVLibras13()
    {

        VLibras13.SetActive(true);

    }

    public void HideVLibras13()
    {
        VLibras13.SetActive(false);

    }
}
