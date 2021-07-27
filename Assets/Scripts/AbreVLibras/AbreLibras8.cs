using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreLibras8 : MonoBehaviour
{
    public GameObject VLibras8;


    void Start()
    {
        VLibras8.SetActive(false);

    }


    public void ShowVLibras8()
    {

        VLibras8.SetActive(true);

    }

    public void HideVLibras8()
    {
        VLibras8.SetActive(false);

    }
}
