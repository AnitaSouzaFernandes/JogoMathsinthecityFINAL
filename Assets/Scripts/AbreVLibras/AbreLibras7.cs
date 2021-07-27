using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreLibras7 : MonoBehaviour
{
    public GameObject VLibras7;


    void Start()
    {
        VLibras7.SetActive(false);

    }


    public void ShowVLibras7()
    {

        VLibras7.SetActive(true);

    }

    public void HideVLibras7()
    {
        VLibras7.SetActive(false);

    }
}
