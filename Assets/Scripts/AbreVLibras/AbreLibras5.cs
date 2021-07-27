using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreLibras5 : MonoBehaviour
{
    public GameObject VLibras5;


    void Start()
    {
        VLibras5.SetActive(false);

    }


    public void ShowVLibras5()
    {

        VLibras5.SetActive(true);

    }

    public void HideVLibras5()
    {
        VLibras5.SetActive(false);

    }
}
