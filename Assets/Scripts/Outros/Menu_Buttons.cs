using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_Buttons : MonoBehaviour
{
    public GameObject MenuPanel;
    public Button Som;
    public Sprite SomOn;
    public Sprite SomOff;
    public Button button;
  
    public GameObject Texto1;
    public float tempo;
    private bool check;

    public AudioSource Texto1TelaInicial;
    public AudioSource Texto2TelaInicial;
    public AudioSource Texto3TelaInicial;

    public AudioSource T2exto1TelaInicial;
    public AudioSource T2exto2TelaInicial;
    public AudioSource T2exto3TelaInicial;

    public AudioSource Texto1TelaFases;
    public AudioSource Texto2TelaFases;
    public AudioSource Texto3TelaFases;
    public AudioSource Texto4TelaFases;
    public AudioSource Texto5TelaFases;
    public AudioSource Texto6TelaFases;
    public AudioSource Texto7TelaFases;
    public AudioSource Texto8TelaFases;
    public AudioSource Texto9TelaFases;
    public AudioSource Texto10TelaFases;
    public AudioSource Texto11TelaFases;
    public AudioSource Texto12TelaFases;
    public AudioSource Texto13TelaFases;
    public AudioSource Texto15TelaFases;

    public AudioSource T2exto1TelaFases;
    public AudioSource T2exto2TelaFases;
    public AudioSource T2exto3TelaFases;
    public AudioSource T2exto4TelaFases;
    public AudioSource T2exto5TelaFases;
    public AudioSource T2exto6TelaFases;
    public AudioSource T2exto7TelaFases;
    public AudioSource T2exto8TelaFases;
    public AudioSource T2exto9TelaFases;
    public AudioSource T2exto10TelaFases;
    public AudioSource T2exto11TelaFases;
    public AudioSource T2exto12TelaFases;
    public AudioSource T2exto13TelaFases;
    public AudioSource T2exto15TelaFases;

    public AudioSource F2inalizaFase4;
    public AudioSource F2inalizaFase3;
    public AudioSource F2inalizaFase2;
    public AudioSource F2inalizaFase1;

    public AudioSource FinalizaFase4;
    public AudioSource FinalizaFase3;
    public AudioSource FinalizaFase2;
    public AudioSource FinalizaFase1;

    public AudioSource DonaDeiseTxt1;
    public AudioSource DonaDeiseTxt2;
    public AudioSource DonaDeiseTxt3;
    public AudioSource DonaDeiseTxt4;
    public AudioSource DonaDeiseTxt5;
    public AudioSource DonaDeiseTxt6;
    public AudioSource DonaDeiseTxt7;
    public AudioSource DonaDeiseTxt8;
    public AudioSource DonaDeiseTxt9;
    public AudioSource DonaDeiseTxt10;
    public AudioSource DonaDeiseTxt11;
    public AudioSource DonaDeiseTxt12;
    public AudioSource DonaDeiseTxt13;
    public AudioSource DonaDeiseTxt14;
    public AudioSource DonaDeiseTxt15;
    public AudioSource DonaDeiseTxt16;
    public AudioSource DonaDeiseTxt17;
    public AudioSource DonaDeiseTxt18;
    public AudioSource DonaDeiseTxt19;
    public AudioSource DonaDeiseTxt20;
    public AudioSource DonaDeiseTxt21;
    public AudioSource DonaDeiseTxt22;
    public AudioSource DonaDeiseTxt23;
    public AudioSource DonaDeiseTxt24;
    public AudioSource DonaDeiseTxt25;

    public AudioSource DonaDeise2Txt1;
    public AudioSource DonaDeise2Txt2;
    public AudioSource DonaDeise2Txt3;
    public AudioSource DonaDeise2Txt4;
    public AudioSource DonaDeise2Txt5;
    public AudioSource DonaDeise2Txt6;
    public AudioSource DonaDeise2Txt7;
    public AudioSource DonaDeise2Txt8;
    public AudioSource DonaDeise2Txt9;
    public AudioSource DonaDeise2Txt10;
    public AudioSource DonaDeise2Txt11;
    public AudioSource DonaDeise2Txt12;
    public AudioSource DonaDeise2Txt13;
    public AudioSource DonaDeise2Txt14;
    public AudioSource DonaDeise2Txt15;
    public AudioSource DonaDeise2Txt16;
    public AudioSource DonaDeise2Txt17;
    public AudioSource DonaDeise2Txt18;
    public AudioSource DonaDeise2Txt19;
    public AudioSource DonaDeise2Txt20;
    public AudioSource DonaDeise2Txt21;
    public AudioSource DonaDeise2Txt22;
    public AudioSource DonaDeise2Txt23;
    public AudioSource DonaDeise2Txt24;
    public AudioSource DonaDeise2Txt25;



    public AudioSource SeuValdirTxt1;
    public AudioSource SeuValdirTxt2;
    public AudioSource SeuValdirTxt3;
    public AudioSource SeuValdirTxt4;
    public AudioSource SeuValdirTxt5;
    public AudioSource SeuValdirTxt6;
    public AudioSource SeuValdirTxt7;
    public AudioSource SeuValdirTxt8;
    public AudioSource SeuValdirTxt9;
    public AudioSource SeuValdirTxt10;
    public AudioSource SeuValdirTxt11;
    public AudioSource SeuValdirTxt12;
    public AudioSource SeuValdirTxt13;
    public AudioSource SeuValdirTxt14;
    public AudioSource SeuValdirTxt15;
    public AudioSource SeuValdirTxt16;
    public AudioSource SeuValdirTxt17;
    public AudioSource SeuValdirTxt18;
    public AudioSource SeuValdirTxt19;
    public AudioSource SeuValdirTxt20;
    public AudioSource SeuValdirTxt21;
    public AudioSource SeuValdirTxt22;
    public AudioSource SeuValdirTxt23;
    public AudioSource SeuValdirTxt24;

    public AudioSource SeuValdir2Txt1;
    public AudioSource SeuValdir2Txt2;
    public AudioSource SeuValdir2Txt3;
    public AudioSource SeuValdir2Txt4;
    public AudioSource SeuValdir2Txt5;
    public AudioSource SeuValdir2Txt6;
    public AudioSource SeuValdir2Txt7;
    public AudioSource SeuValdir2Txt8;
    public AudioSource SeuValdir2Txt9;
    public AudioSource SeuValdir2Txt10;
    public AudioSource SeuValdir2Txt11;
    public AudioSource SeuValdir2Txt12;
    public AudioSource SeuValdir2Txt13;
    public AudioSource SeuValdir2Txt14;
    public AudioSource SeuValdir2Txt15;
    public AudioSource SeuValdir2Txt16;
    public AudioSource SeuValdir2Txt17;
    public AudioSource SeuValdir2Txt18;
    public AudioSource SeuValdir2Txt19;
    public AudioSource SeuValdir2Txt20;
    public AudioSource SeuValdir2Txt21;
    public AudioSource SeuValdir2Txt22;
    public AudioSource SeuValdir2Txt23;
    public AudioSource SeuValdir2Txt24;

    public AudioSource PrefeitaMarcelaTxt1;
    public AudioSource PrefeitaMarcelaTxt2;
    public AudioSource PrefeitaMarcelaTxt3;
    public AudioSource PrefeitaMarcelaTxt4;
    public AudioSource PrefeitaMarcelaTxt5;
    public AudioSource PrefeitaMarcelaTxt6;
    public AudioSource PrefeitaMarcelaTxt7;
    public AudioSource PrefeitaMarcelaTxt8;
    public AudioSource PrefeitaMarcelaTxt9;
    public AudioSource PrefeitaMarcelaTxt10;
    public AudioSource PrefeitaMarcelaTxt11;
    public AudioSource PrefeitaMarcelaTxt12;
    public AudioSource PrefeitaMarcelaTxt13;
    public AudioSource PrefeitaMarcelaTxt14;
    public AudioSource PrefeitaMarcelaTxt15;
    public AudioSource PrefeitaMarcelaTxt16;
    public AudioSource PrefeitaMarcelaTxt17;
    public AudioSource PrefeitaMarcelaTxt18;
    public AudioSource PrefeitaMarcelaTxt19;
    public AudioSource PrefeitaMarcelaTxt20;
    public AudioSource PrefeitaMarcelaTxt21;
    public AudioSource PrefeitaMarcelaTxt22;
    public AudioSource PrefeitaMarcelaTxt23;
    public AudioSource PrefeitaMarcelaTxt24;
    public AudioSource PrefeitaMarcelaTxt25;

    public AudioSource PrefeitaMarcela2Txt1;
    public AudioSource PrefeitaMarcela2Txt2;
    public AudioSource PrefeitaMarcela2Txt3;
    public AudioSource PrefeitaMarcela2Txt4;
    public AudioSource PrefeitaMarcela2Txt5;
    public AudioSource PrefeitaMarcela2Txt6;
    public AudioSource PrefeitaMarcela2Txt7;
    public AudioSource PrefeitaMarcela2Txt8;
    public AudioSource PrefeitaMarcela2Txt9;
    public AudioSource PrefeitaMarcela2Txt10;
    public AudioSource PrefeitaMarcela2Txt11;
    public AudioSource PrefeitaMarcela2Txt12;
    public AudioSource PrefeitaMarcela2Txt13;
    public AudioSource PrefeitaMarcela2Txt14;
    public AudioSource PrefeitaMarcela2Txt15;
    public AudioSource PrefeitaMarcela2Txt16;
    public AudioSource PrefeitaMarcela2Txt17;
    public AudioSource PrefeitaMarcela2Txt18;
    public AudioSource PrefeitaMarcela2Txt19;
    public AudioSource PrefeitaMarcela2Txt20;
    public AudioSource PrefeitaMarcela2Txt21;
    public AudioSource PrefeitaMarcela2Txt22;
    public AudioSource PrefeitaMarcela2Txt23;
    public AudioSource PrefeitaMarcela2Txt24;
    public AudioSource PrefeitaMarcela2Txt25;

    public AudioSource I2ntro1F4;
    public AudioSource I2ntro2F4;
    public AudioSource Intro1F4;
    public AudioSource Intro2F4;

    public AudioSource Desafio2F4texto2;
    public AudioSource Desafio2F4texto3;
    public AudioSource Desafio2F4texto4;

    public AudioSource Desafio2F42texto2;
    public AudioSource Desafio2F42texto3;
    public AudioSource Desafio2F42texto4;

    public AudioSource DonaOlga2Txt1;
    public AudioSource DonaOlga2Txt2;
    public AudioSource DonaOlga2Txt3;
    public AudioSource DonaOlga2Txt4;
    public AudioSource DonaOlga2Txt5;

    public AudioSource DonaOlgaTxt1;
    public AudioSource DonaOlgaTxt2;
    public AudioSource DonaOlgaTxt3;
    public AudioSource DonaOlgaTxt4;
    public AudioSource DonaOlgaTxt5;

    public AudioSource ProfessoraJoanaTxt1;
    public AudioSource ProfessoraJoanaTxt2;
    public AudioSource ProfessoraJoanaTxt3;
    public AudioSource ProfessoraJoanaTxt4;

    public AudioSource ProfessoraJoana2Txt1;
    public AudioSource ProfessoraJoana2Txt2;
    public AudioSource ProfessoraJoana2Txt3;
    public AudioSource ProfessoraJoana2Txt4;

    public AudioSource ProfessorCezarTxt1;
    public AudioSource ProfessorCezarTxt2;
    public AudioSource ProfessorCezarTxt3;
    public AudioSource ProfessorCezarTxt4;
    public AudioSource ProfessorCezarTxt5;
    public AudioSource ProfessorCezarTxt6;
    public AudioSource ProfessorCezarTxt7;
    public AudioSource ProfessorCezarTxt8;

    public AudioSource ProfessorCezar2Txt1;
    public AudioSource ProfessorCezar2Txt2;
    public AudioSource ProfessorCezar2Txt3;
    public AudioSource ProfessorCezar2Txt4;
    public AudioSource ProfessorCezar2Txt5;
    public AudioSource ProfessorCezar2Txt6;
    public AudioSource ProfessorCezar2Txt7;
    public AudioSource ProfessorCezar2Txt8;

    public AudioSource ProfessorPauloTxt1;
    public AudioSource ProfessorPauloTxt2;
    public AudioSource ProfessorPauloTxt3;
    public AudioSource ProfessorPauloTxt4;
    public AudioSource ProfessorPauloTxt5;

    public AudioSource ProfessorPaulo2Txt1;
    public AudioSource ProfessorPaulo2Txt2;
    public AudioSource ProfessorPaulo2Txt3;
    public AudioSource ProfessorPaulo2Txt4;
    public AudioSource ProfessorPaulo2Txt5;

    public void Update()
    {
        if (Time.time >= tempo && check == true)
        {
            Texto1.SetActive(true);
            check = false;
        }
    }

    void Start()
    {

        MenuPanel.SetActive(false);
        //Som.interactable = true;
        //Voz.interactable = true;
    }

    public void ShowMenuPanel()
    {
            
        tempo = Time.time + 1;
        Texto1.SetActive(false);
        check = true;
        MenuPanel.SetActive(true);

        Texto1TelaInicial.Pause();
        Texto2TelaInicial.Pause();
        Texto3TelaInicial.Pause();

        T2exto1TelaInicial.Pause();
        T2exto2TelaInicial.Pause();
        T2exto3TelaInicial.Pause();

        Texto1TelaFases.Pause();
        Texto2TelaFases.Pause();
        Texto3TelaFases.Pause();
        Texto4TelaFases.Pause();
        Texto5TelaFases.Pause();
        Texto6TelaFases.Pause();
        Texto7TelaFases.Pause();
        Texto8TelaFases.Pause();
        Texto9TelaFases.Pause();
        Texto10TelaFases.Pause();
        Texto11TelaFases.Pause();
        Texto12TelaFases.Pause();
        Texto13TelaFases.Pause();
        Texto15TelaFases.Pause();

        T2exto1TelaFases.Pause();
        T2exto2TelaFases.Pause();
        T2exto3TelaFases.Pause();
        T2exto4TelaFases.Pause();
        T2exto5TelaFases.Pause();
        T2exto6TelaFases.Pause();
        T2exto7TelaFases.Pause();
        T2exto8TelaFases.Pause();
        T2exto9TelaFases.Pause();
        T2exto10TelaFases.Pause();
        T2exto11TelaFases.Pause();
        T2exto12TelaFases.Pause();
        T2exto13TelaFases.Pause();
        T2exto15TelaFases.Pause();


        FinalizaFase1.Pause();
        FinalizaFase2.Pause();
        FinalizaFase3.Pause();
        FinalizaFase4.Pause();

        F2inalizaFase1.Pause();
        F2inalizaFase2.Pause();
        F2inalizaFase3.Pause();
        F2inalizaFase4.Pause();

        DonaDeiseTxt1.Pause();
        DonaDeiseTxt2.Pause();
        DonaDeiseTxt3.Pause();
        DonaDeiseTxt4.Pause();
        DonaDeiseTxt5.Pause();
        DonaDeiseTxt6.Pause();
        DonaDeiseTxt7.Pause();
        DonaDeiseTxt8.Pause();
        DonaDeiseTxt9.Pause();
        DonaDeiseTxt10.Pause();
        DonaDeiseTxt11.Pause();
        DonaDeiseTxt12.Pause();
        DonaDeiseTxt13.Pause();
        DonaDeiseTxt14.Pause();
        DonaDeiseTxt15.Pause();
        DonaDeiseTxt16.Pause();
        DonaDeiseTxt17.Pause();
        DonaDeiseTxt18.Pause();
        DonaDeiseTxt19.Pause();
        DonaDeiseTxt20.Pause();
        DonaDeiseTxt21.Pause();
        DonaDeiseTxt22.Pause();
        DonaDeiseTxt23.Pause();
        DonaDeiseTxt24.Pause();
        DonaDeiseTxt25.Pause();

        DonaDeise2Txt1.Pause();
        DonaDeise2Txt2.Pause();
        DonaDeise2Txt3.Pause();
        DonaDeise2Txt4.Pause();
        DonaDeise2Txt5.Pause();
        DonaDeise2Txt6.Pause();
        DonaDeise2Txt7.Pause();
        DonaDeise2Txt8.Pause();
        DonaDeise2Txt9.Pause();
        DonaDeise2Txt10.Pause();
        DonaDeise2Txt11.Pause();
        DonaDeise2Txt12.Pause();
        DonaDeise2Txt13.Pause();
        DonaDeise2Txt14.Pause();
        DonaDeise2Txt15.Pause();
        DonaDeise2Txt16.Pause();
        DonaDeise2Txt17.Pause();
        DonaDeise2Txt18.Pause();
        DonaDeise2Txt19.Pause();
        DonaDeise2Txt20.Pause();
        DonaDeise2Txt21.Pause();
        DonaDeise2Txt22.Pause();
        DonaDeise2Txt23.Pause();
        DonaDeise2Txt24.Pause();
        DonaDeise2Txt25.Pause();

        SeuValdirTxt1.Pause();
        SeuValdirTxt2.Pause();
        SeuValdirTxt3.Pause();
        SeuValdirTxt4.Pause();
        SeuValdirTxt5.Pause();
        SeuValdirTxt6.Pause();
        SeuValdirTxt7.Pause();
        SeuValdirTxt8.Pause();
        SeuValdirTxt9.Pause();
        SeuValdirTxt10.Pause();
        SeuValdirTxt11.Pause();
        SeuValdirTxt12.Pause();
        SeuValdirTxt13.Pause();
        SeuValdirTxt14.Pause();
        SeuValdirTxt15.Pause();
        SeuValdirTxt16.Pause();
        SeuValdirTxt17.Pause();
        SeuValdirTxt18.Pause();
        SeuValdirTxt19.Pause();
        SeuValdirTxt20.Pause();
        SeuValdirTxt21.Pause();
        SeuValdirTxt22.Pause();
        SeuValdirTxt23.Pause();
        SeuValdirTxt24.Pause();

        SeuValdir2Txt1.Pause();
        SeuValdir2Txt2.Pause();
        SeuValdir2Txt3.Pause();
        SeuValdir2Txt4.Pause();
        SeuValdir2Txt5.Pause();
        SeuValdir2Txt6.Pause();
        SeuValdir2Txt7.Pause();
        SeuValdir2Txt8.Pause();
        SeuValdir2Txt9.Pause();
        SeuValdir2Txt10.Pause();
        SeuValdir2Txt11.Pause();
        SeuValdir2Txt12.Pause();
        SeuValdir2Txt13.Pause();
        SeuValdir2Txt14.Pause();
        SeuValdir2Txt15.Pause();
        SeuValdir2Txt16.Pause();
        SeuValdir2Txt17.Pause();
        SeuValdir2Txt18.Pause();
        SeuValdir2Txt19.Pause();
        SeuValdir2Txt20.Pause();
        SeuValdir2Txt21.Pause();
        SeuValdir2Txt22.Pause();
        SeuValdir2Txt23.Pause();
        SeuValdir2Txt24.Pause();

        PrefeitaMarcelaTxt1.Pause();
        PrefeitaMarcelaTxt2.Pause();
        PrefeitaMarcelaTxt3.Pause();
        PrefeitaMarcelaTxt4.Pause();
        PrefeitaMarcelaTxt5.Pause();
        PrefeitaMarcelaTxt6.Pause();
        PrefeitaMarcelaTxt7.Pause();
        PrefeitaMarcelaTxt8.Pause();
        PrefeitaMarcelaTxt9.Pause();
        PrefeitaMarcelaTxt10.Pause();
        PrefeitaMarcelaTxt11.Pause();
        PrefeitaMarcelaTxt12.Pause();
        PrefeitaMarcelaTxt13.Pause();
        PrefeitaMarcelaTxt14.Pause();
        PrefeitaMarcelaTxt15.Pause();
        PrefeitaMarcelaTxt16.Pause();
        PrefeitaMarcelaTxt17.Pause();
        PrefeitaMarcelaTxt18.Pause();
        PrefeitaMarcelaTxt19.Pause();
        PrefeitaMarcelaTxt20.Pause();
        PrefeitaMarcelaTxt21.Pause();
        PrefeitaMarcelaTxt22.Pause();
        PrefeitaMarcelaTxt23.Pause();
        PrefeitaMarcelaTxt24.Pause();
        PrefeitaMarcelaTxt25.Pause();

        PrefeitaMarcela2Txt1.Pause();
        PrefeitaMarcela2Txt2.Pause();
        PrefeitaMarcela2Txt3.Pause();
        PrefeitaMarcela2Txt4.Pause();
        PrefeitaMarcela2Txt5.Pause();
        PrefeitaMarcela2Txt6.Pause();
        PrefeitaMarcela2Txt7.Pause();
        PrefeitaMarcela2Txt8.Pause();
        PrefeitaMarcela2Txt9.Pause();
        PrefeitaMarcela2Txt10.Pause();
        PrefeitaMarcela2Txt11.Pause();
        PrefeitaMarcela2Txt12.Pause();
        PrefeitaMarcela2Txt13.Pause();
        PrefeitaMarcela2Txt14.Pause();
        PrefeitaMarcela2Txt15.Pause();
        PrefeitaMarcela2Txt16.Pause();
        PrefeitaMarcela2Txt17.Pause();
        PrefeitaMarcela2Txt18.Pause();
        PrefeitaMarcela2Txt19.Pause();
        PrefeitaMarcela2Txt20.Pause();
        PrefeitaMarcela2Txt21.Pause();
        PrefeitaMarcela2Txt22.Pause();
        PrefeitaMarcela2Txt23.Pause();
        PrefeitaMarcela2Txt24.Pause();
        PrefeitaMarcela2Txt25.Pause();

        I2ntro1F4.Pause();
        I2ntro2F4.Pause();

        Intro1F4.Pause();
        Intro1F4.Pause();

        Desafio2F4texto2.Pause();
        Desafio2F4texto3.Pause();
        Desafio2F4texto4.Pause();

        Desafio2F42texto2.Pause();
        Desafio2F42texto3.Pause();
        Desafio2F42texto4.Pause();

        DonaOlgaTxt1.Pause();
        DonaOlgaTxt1.Pause();
        DonaOlgaTxt1.Pause();
        DonaOlgaTxt1.Pause();
        DonaOlgaTxt1.Pause();

        DonaOlga2Txt1.Pause();
        DonaOlga2Txt2.Pause();
        DonaOlga2Txt3.Pause();
        DonaOlga2Txt4.Pause();
        DonaOlga2Txt5.Pause();

        ProfessoraJoanaTxt1.Pause();
        ProfessoraJoanaTxt1.Pause();
        ProfessoraJoanaTxt1.Pause();
        ProfessoraJoanaTxt1.Pause();

        ProfessoraJoana2Txt1.Pause();
        ProfessoraJoana2Txt1.Pause();
        ProfessoraJoana2Txt1.Pause();
        ProfessoraJoana2Txt1.Pause();

        ProfessorCezarTxt1.Pause();
        ProfessorCezarTxt2.Pause();
        ProfessorCezarTxt3.Pause();
        ProfessorCezarTxt4.Pause();
        ProfessorCezarTxt5.Pause();
        ProfessorCezarTxt6.Pause();
        ProfessorCezarTxt7.Pause();
        ProfessorCezarTxt8.Pause();

        ProfessorCezar2Txt1.Pause();
        ProfessorCezar2Txt2.Pause();
        ProfessorCezar2Txt3.Pause();
        ProfessorCezar2Txt4.Pause();
        ProfessorCezar2Txt5.Pause();
        ProfessorCezar2Txt6.Pause();
        ProfessorCezar2Txt7.Pause();
        ProfessorCezar2Txt8.Pause();

        ProfessorPauloTxt1.Pause();
        ProfessorPauloTxt2.Pause();
        ProfessorPauloTxt3.Pause();
        ProfessorPauloTxt4.Pause();
        ProfessorPauloTxt5.Pause();

        ProfessorPaulo2Txt1.Pause();
        ProfessorPaulo2Txt2.Pause();
        ProfessorPaulo2Txt3.Pause();
        ProfessorPaulo2Txt4.Pause();
        ProfessorPaulo2Txt5.Pause();

}

    public void HideMenuPanel()
    {
        MenuPanel.SetActive(false);
        Texto1TelaInicial.Play(1);
        Texto2TelaInicial.Play(1);
        Texto3TelaInicial.Play(1);

        T2exto1TelaInicial.Play(1);
        T2exto2TelaInicial.Play(1);
        T2exto3TelaInicial.Play(1);

        Texto1TelaFases.Play(1);
        Texto2TelaFases.Play(1);
        Texto3TelaFases.Play(1);
        Texto4TelaFases.Play(1);
        Texto5TelaFases.Play(1);
        Texto6TelaFases.Play(1);
        Texto7TelaFases.Play(1);
        Texto8TelaFases.Play(1);
        Texto9TelaFases.Play(1);
        Texto10TelaFases.Play(1);
        Texto11TelaFases.Play(1);
        Texto12TelaFases.Play(1);
        Texto13TelaFases.Play(1);
        Texto15TelaFases.Play(1);

        T2exto1TelaFases.Play(1);
        T2exto2TelaFases.Play(1);
        T2exto3TelaFases.Play(1);
        T2exto4TelaFases.Play(1);
        T2exto5TelaFases.Play(1);
        T2exto6TelaFases.Play(1);
        T2exto7TelaFases.Play(1);
        T2exto8TelaFases.Play(1);
        T2exto9TelaFases.Play(1);
        T2exto10TelaFases.Play(1);
        T2exto11TelaFases.Play(1);
        T2exto12TelaFases.Play(1);
        T2exto13TelaFases.Play(1);
        T2exto15TelaFases.Play(1);

        FinalizaFase1.Play(1);
        FinalizaFase2.Play(1);
        FinalizaFase3.Play(1);
        FinalizaFase4.Play(1);

        F2inalizaFase1.Play(1);
        F2inalizaFase2.Play(1);
        F2inalizaFase3.Play(1);
        F2inalizaFase4.Play(1);

        DonaDeiseTxt1.Play(1);
        DonaDeiseTxt2.Play(1);
        DonaDeiseTxt3.Play(1);
        DonaDeiseTxt4.Play(1);
        DonaDeiseTxt5.Play(1);
        DonaDeiseTxt6.Play(1);
        DonaDeiseTxt7.Play(1);
        DonaDeiseTxt8.Play(1);
        DonaDeiseTxt9.Play(1);
        DonaDeiseTxt10.Play(1);
        DonaDeiseTxt11.Play(1);
        DonaDeiseTxt12.Play(1);
        DonaDeiseTxt13.Play(1);
        DonaDeiseTxt14.Play(1);
        DonaDeiseTxt15.Play(1);
        DonaDeiseTxt16.Play(1);
        DonaDeiseTxt17.Play(1);
        DonaDeiseTxt18.Play(1);
        DonaDeiseTxt19.Play(1);
        DonaDeiseTxt20.Play(1);
        DonaDeiseTxt21.Play(1);
        DonaDeiseTxt22.Play(1);
        DonaDeiseTxt23.Play(1);
        DonaDeiseTxt24.Play(1);
        DonaDeiseTxt25.Play(1);

        DonaDeise2Txt1.Play(1);
        DonaDeise2Txt2.Play(1);
        DonaDeise2Txt3.Play(1);
        DonaDeise2Txt4.Play(1);
        DonaDeise2Txt5.Play(1);
        DonaDeise2Txt6.Play(1);
        DonaDeise2Txt7.Play(1);
        DonaDeise2Txt8.Play(1);
        DonaDeise2Txt9.Play(1);
        DonaDeise2Txt10.Play(1);
        DonaDeise2Txt11.Play(1);
        DonaDeise2Txt12.Play(1);
        DonaDeise2Txt13.Play(1);
        DonaDeise2Txt14.Play(1);
        DonaDeise2Txt15.Play(1);
        DonaDeise2Txt16.Play(1);
        DonaDeise2Txt17.Play(1);
        DonaDeise2Txt18.Play(1);
        DonaDeise2Txt19.Play(1);
        DonaDeise2Txt20.Play(1);
        DonaDeise2Txt21.Play(1);
        DonaDeise2Txt22.Play(1);
        DonaDeise2Txt23.Play(1);
        DonaDeise2Txt24.Play(1);
        DonaDeise2Txt25.Play(1);

        SeuValdirTxt1.Play(1);
        SeuValdirTxt2.Play(1);
        SeuValdirTxt3.Play(1);
        SeuValdirTxt4.Play(1);
        SeuValdirTxt5.Play(1);
        SeuValdirTxt6.Play(1);
        SeuValdirTxt7.Play(1);
        SeuValdirTxt8.Play(1);
        SeuValdirTxt9.Play(1);
        SeuValdirTxt10.Play(1);
        SeuValdirTxt11.Play(1);
        SeuValdirTxt12.Play(1);
        SeuValdirTxt13.Play(1);
        SeuValdirTxt14.Play(1);
        SeuValdirTxt15.Play(1);
        SeuValdirTxt16.Play(1);
        SeuValdirTxt17.Play(1);
        SeuValdirTxt18.Play(1);
        SeuValdirTxt19.Play(1);
        SeuValdirTxt20.Play(1);
        SeuValdirTxt21.Play(1);
        SeuValdirTxt22.Play(1);
        SeuValdirTxt23.Play(1);
        SeuValdirTxt24.Play(1);

        SeuValdir2Txt1.Play(1);
        SeuValdir2Txt2.Play(1);
        SeuValdir2Txt3.Play(1);
        SeuValdir2Txt4.Play(1);
        SeuValdir2Txt5.Play(1);
        SeuValdir2Txt6.Play(1);
        SeuValdir2Txt7.Play(1);
        SeuValdir2Txt8.Play(1);
        SeuValdir2Txt9.Play(1);
        SeuValdir2Txt10.Play(1);
        SeuValdir2Txt11.Play(1);
        SeuValdir2Txt12.Play(1);
        SeuValdir2Txt13.Play(1);
        SeuValdir2Txt14.Play(1);
        SeuValdir2Txt15.Play(1);
        SeuValdir2Txt16.Play(1);
        SeuValdir2Txt17.Play(1);
        SeuValdir2Txt18.Play(1);
        SeuValdir2Txt19.Play(1);
        SeuValdir2Txt20.Play(1);
        SeuValdir2Txt21.Play(1);
        SeuValdir2Txt22.Play(1);
        SeuValdir2Txt23.Play(1);
        SeuValdir2Txt24.Play(1);

        PrefeitaMarcelaTxt1.Play(1);
        PrefeitaMarcelaTxt2.Play(1);
        PrefeitaMarcelaTxt3.Play(1);
        PrefeitaMarcelaTxt4.Play(1);
        PrefeitaMarcelaTxt5.Play(1);
        PrefeitaMarcelaTxt6.Play(1);
        PrefeitaMarcelaTxt7.Play(1);
        PrefeitaMarcelaTxt8.Play(1);
        PrefeitaMarcelaTxt9.Play(1);
        PrefeitaMarcelaTxt10.Play(1);
        PrefeitaMarcelaTxt11.Play(1);
        PrefeitaMarcelaTxt12.Play(1);
        PrefeitaMarcelaTxt13.Play(1);
        PrefeitaMarcelaTxt14.Play(1);
        PrefeitaMarcelaTxt15.Play(1);
        PrefeitaMarcelaTxt16.Play(1);
        PrefeitaMarcelaTxt17.Play(1);
        PrefeitaMarcelaTxt18.Play(1);
        PrefeitaMarcelaTxt19.Play(1);
        PrefeitaMarcelaTxt20.Play(1);
        PrefeitaMarcelaTxt21.Play(1);
        PrefeitaMarcelaTxt22.Play(1);
        PrefeitaMarcelaTxt23.Play(1);
        PrefeitaMarcelaTxt24.Play(1);
        PrefeitaMarcelaTxt25.Play(1);

        PrefeitaMarcela2Txt1.Play(1);
        PrefeitaMarcela2Txt2.Play(1);
        PrefeitaMarcela2Txt3.Play(1);
        PrefeitaMarcela2Txt4.Play(1);
        PrefeitaMarcela2Txt5.Play(1);
        PrefeitaMarcela2Txt6.Play(1);
        PrefeitaMarcela2Txt7.Play(1);
        PrefeitaMarcela2Txt8.Play(1);
        PrefeitaMarcela2Txt9.Play(1);
        PrefeitaMarcela2Txt10.Play(1);
        PrefeitaMarcela2Txt11.Play(1);
        PrefeitaMarcela2Txt12.Play(1);
        PrefeitaMarcela2Txt13.Play(1);
        PrefeitaMarcela2Txt14.Play(1);
        PrefeitaMarcela2Txt15.Play(1);
        PrefeitaMarcela2Txt16.Play(1);
        PrefeitaMarcela2Txt17.Play(1);
        PrefeitaMarcela2Txt18.Play(1);
        PrefeitaMarcela2Txt19.Play(1);
        PrefeitaMarcela2Txt20.Play(1);
        PrefeitaMarcela2Txt21.Play(1);
        PrefeitaMarcela2Txt22.Play(1);
        PrefeitaMarcela2Txt23.Play(1);
        PrefeitaMarcela2Txt24.Play(1);
        PrefeitaMarcela2Txt25.Play(1);

        I2ntro1F4.Play(1);
        I2ntro2F4.Play(1);

        Intro1F4.Play(1);
        Intro1F4.Play(1);

        Desafio2F4texto2.Play(1);
        Desafio2F4texto3.Play(1);
        Desafio2F4texto4.Play(1);

        Desafio2F42texto2.Play(1);
        Desafio2F42texto3.Play(1);
        Desafio2F42texto4.Play(1);

        DonaOlgaTxt1.Play(1);
        DonaOlgaTxt1.Play(1);
        DonaOlgaTxt1.Play(1);
        DonaOlgaTxt1.Play(1);
        DonaOlgaTxt1.Play(1);

        DonaOlga2Txt1.Play(1);
        DonaOlga2Txt2.Play(1);
        DonaOlga2Txt3.Play(1);
        DonaOlga2Txt4.Play(1);
        DonaOlga2Txt5.Play(1);

        ProfessoraJoanaTxt1.Play(1);
        ProfessoraJoanaTxt1.Play(1);
        ProfessoraJoanaTxt1.Play(1);
        ProfessoraJoanaTxt1.Play(1);

        ProfessoraJoana2Txt1.Play(1);
        ProfessoraJoana2Txt1.Play(1);
        ProfessoraJoana2Txt1.Play(1);
        ProfessoraJoana2Txt1.Play(1);

        ProfessorCezarTxt1.Play(1);
        ProfessorCezarTxt2.Play(1);
        ProfessorCezarTxt3.Play(1);
        ProfessorCezarTxt4.Play(1);
        ProfessorCezarTxt5.Play(1);
        ProfessorCezarTxt6.Play(1);
        ProfessorCezarTxt7.Play(1);
        ProfessorCezarTxt8.Play(1);

        ProfessorCezar2Txt1.Play(1);
        ProfessorCezar2Txt2.Play(1);
        ProfessorCezar2Txt3.Play(1);
        ProfessorCezar2Txt4.Play(1);
        ProfessorCezar2Txt5.Play(1);
        ProfessorCezar2Txt6.Play(1);
        ProfessorCezar2Txt7.Play(1);
        ProfessorCezar2Txt8.Play(1);

        ProfessorPauloTxt1.Play(1);
        ProfessorPauloTxt2.Play(1);
        ProfessorPauloTxt3.Play(1);
        ProfessorPauloTxt4.Play(1);
        ProfessorPauloTxt5.Play(1);

        ProfessorPaulo2Txt1.Play(1);
        ProfessorPaulo2Txt2.Play(1);
        ProfessorPaulo2Txt3.Play(1);
        ProfessorPaulo2Txt4.Play(1);
        ProfessorPaulo2Txt5.Play(1);
    }

    public void HabilitaSom()
    {
        if (PlayerPrefs.GetInt("Som") == 1)
        {
            PlayerPrefs.SetInt("Som", -1);
            AudioListener.volume = 1;
            button.image.sprite = SomOn;
        } 
        else
        {
            PlayerPrefs.SetInt("Som", 1);
            AudioListener.volume = 0;
            button.image.sprite = SomOff;
        }
    }

}
