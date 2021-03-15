using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACartaQueSaiuFoi : MonoBehaviour
{
    int NaipeMinimo;
    int NaipeMaximo;
    int FiguraMinima;
    int FiguraMaxima;
    int nNaipe;
    int nFigura;
    string Figura;
    string Naipe;

    // Start is called before the first frame update

    void Start()
    {
        Iniciar();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CalculaEImprime();
        }
    }

    void CalculaEImprime()
    {
        nFigura = Random.Range(FiguraMinima, FiguraMaxima);
        nNaipe = Random.Range(NaipeMinimo, NaipeMaximo);

        if (nFigura ==1)
        {
            Figura = "Às";
        }

        else if (nFigura == 2)
        {
            Figura = "Dois";
        }

        else if (nFigura == 3)
        {
            Figura = "Três";
        }

        else if (nFigura == 4)
        {
            Figura = "Quatro";
        }

        else if (nFigura == 5)
        {
            Figura = "Cinco";
        }

        else if (nFigura == 6)
        {
            Figura = "Seis";
        }

        else if (nFigura == 7)
        {
            Figura = "Sete";
        }

        else if (nFigura == 8)
        {
            Figura = "Oito";
        }

        else if (nFigura == 9)
        {
            Figura = "Nove";

        }
        else if (nFigura == 10)
        {
            Figura = "Dez";
        }

        else if (nFigura == 11)
        {
            Figura = "Dama";
        }

        else if (nFigura == 12)
        {
            Figura = "Valete";
        }

        else if (nFigura == 13)
        {
            Figura = "Rei";
        }

        if(nNaipe == 1)
        {
            Naipe = "Copas";
        }

        else if (nNaipe == 1)
        {
            Naipe = "Espadas";
        }

        else if (nNaipe == 1)
        {
            Naipe = "Paus";
        }

        else if (nNaipe == 1)
        {
            Naipe = "Ouros";
        }

        Debug.Log("A carta que saiu foi " + Figura + " de " + Naipe + "!");

        Iniciar();
    }
    void Iniciar()
    {
        NaipeMinimo = 1;
        NaipeMaximo = 4;
        FiguraMinima = 1;
        FiguraMaxima = 13;

        NaipeMaximo = NaipeMaximo + 1;
        FiguraMaxima = FiguraMaxima + 1;

        Debug.Log("Esse é o jogo: A CARTA QUE SAIU FOI...");
        Debug.Log("Para retirar uma carta, pressione a tecla de espaço.");
    }
}


