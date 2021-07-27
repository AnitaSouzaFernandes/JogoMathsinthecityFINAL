using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreLibras1 : MonoBehaviour
{
    public GameObject Libras1;


    void Start()
    {
        Libras1.SetActive(false);

    }


    public void ShowLibras1()
    {

        Libras1.SetActive(true);

    }

    public void HideLibras1()
    {
        Libras1.SetActive(false);

    }
}
