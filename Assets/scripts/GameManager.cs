using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject intro; // obtemos el ojeto que con tiene el video de intro desde el editor
    static GameObject gameManager = null; //aqui guardaderemos el objeto game manager, inicia como un objeto vacio
    bool firstTime = true; // variable que nos indica si es la primera vez que se incia el juego

    private void Awake()
    {
        if (gameManager == null) gameManager = gameObject; //  comprobamos que no haya otro game manager, si no hay, guardamos el actual

        if(gameManager != gameObject) // si se crea otro game  manager eliminamos el nuevo y dejamos el primeor que se creo
        {
            Destroy(GetComponent<GameObject>());
            return; // evitamos que el nuevo game manager repruduzca el video otra vez
        }

        DontDestroyOnLoad(gameManager); // hacemos que el game manager no se destruya al cambair de escena
 
        if (firstTime) // comprobamos que es la primera vez que se inicia el juego
        {
            intro.SetActive(true); // activamos el video para que sea visible
            intro.GetComponent<VideoPlayer>().Play(); //  le damos play al video
            firstTime = false; // maracmos que el juego ya esta iniciado para que no se repita el video cuando volavmos al menu
        }
    }


}
