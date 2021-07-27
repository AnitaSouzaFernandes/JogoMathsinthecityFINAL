using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculoPontos : MonoBehaviour
{
   
    public int erros;
    public int acertos;

    public Text Acertos;
    public Text Erros;
    public Text Acertos2;
    public Text Erros2;


    public AudioSource src0;
    public AudioSource src1;
    public AudioSource src2;
    public AudioSource src3;
    public AudioSource src4;
    public AudioSource src5;
    public AudioSource src6;
    public AudioSource src7;
    public AudioSource src8;
    public AudioSource src9;
    public AudioSource src10;
    public AudioSource src11;
    public AudioSource src12;
    public AudioSource src13;
    public AudioSource src14;
    public AudioSource src15;
    public AudioSource src16;
    public AudioSource src17;
    public AudioSource src18;
    public AudioSource src19;
    public AudioSource src20;
    public AudioSource src21;
    public AudioSource src22;
    public AudioSource src23;
    public AudioSource src24;
    public AudioSource src25;
    public AudioSource src26;
    public AudioSource src27;
    public AudioSource src28;
    public AudioSource src29;
    public AudioSource src30;
    public AudioSource src31;
    public AudioSource src32;
    public AudioSource src33;
    public AudioSource src34;
    public AudioSource src35;
    public AudioSource src36;
    public AudioSource src37;
    public AudioSource src38;
    public AudioSource src39;
    public AudioSource src40;

    void Start()
    {
        erros = 0;
        acertos = 0;

    }

    public void acerto()
    {
        if (acertos == 0 || (acertos > 0 && acertos < 20))
        {
            acertos = acertos + 1;
            Acertos.text = acertos.ToString();
            Acertos2.text = acertos.ToString();

        }
        else if (acertos > 20)
        {
            acertos = 20;
            Acertos.text = acertos.ToString();
            Acertos2.text = acertos.ToString();

        }

    }


    public void erro()
    {
        erros = erros + 1;
        Erros.text = erros.ToString();
        Erros2.text = erros.ToString();

        
    }

    public void ApareceSom()
    {

        if (erros == 0)
        {
            src0.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 1)
        {
            src1.Play(0);
            Debug.Log(erros.ToString());

        }
        else if (erros == 2)
        {
            src2.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 3)
        {
            src3.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 4)
        {
            src4.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 5)
        {
            src5.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 6)
        {
            src6.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 7)
        {
            src7.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 8)
        {
            src8.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 9)
        {
            src9.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 10)
        {
            src10.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 11)
        {
            src11.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 12)
        {
            src12.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 13)
        {
            src13.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 14)
        {
            src14.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 15)
        {
            src15.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 16)
        {
            src16.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 17)
        {
            src17.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 18)
        {
            src18.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 19)
        {
            src19.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 20)
        {
            src20.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 21)
        {
            src21.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 22)
        {
            src22.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 23)
        {
            src23.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 24)
        {
            src24.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 25)
        {
            src25.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 26)
        {
            src26.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 27)
        {
            src27.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 28)
        {
            src28.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 29)
        {
            src29.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 30)
        {
            src30.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 31)
        {
            src31.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 32)
        {
            src32.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 33)
        {
            src33.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 34)
        {
            src34.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 35)
        {
            src35.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 36)
        {
            src36.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 37)
        {
            src37.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 38)
        {
            src38.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 39)
        {
            src39.Play(0);
            Debug.Log(erros.ToString());
        }
        else if (erros == 40)
        {
            src40.Play(0);
            Debug.Log(erros.ToString());
        }
    }

}
