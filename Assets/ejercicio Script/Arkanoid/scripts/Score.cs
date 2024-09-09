using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    int score = 0;
    public Text scoreText; //se puede llamar tex si esta la libreria uai
    
    void Start()
    {
        ActualizarTexto();
    }
    public void Contador(int sumPoint) //funcion
    {
        score += sumPoint;
        ActualizarTexto();
    }
    void ActualizarTexto() //funcion
    {
        scoreText.text = "Score: " + score; // llama al texto y el punto text y entra a las opcion de texto
                                            //le sumo un stream asi tranformo el int en str
    }
}
