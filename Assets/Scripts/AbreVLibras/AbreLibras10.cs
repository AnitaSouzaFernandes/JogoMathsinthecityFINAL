using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreLibras10 : MonoBehaviour
{
    public GameObject VLibras10;


    void Start()
    {
        VLibras10.SetActive(false);

    }


    public void ShowVLibras10()
    {

        VLibras10.SetActive(true);

    }

    public void HideVLibras10()
    {
        VLibras10.SetActive(false);

    }
}
