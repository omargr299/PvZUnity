using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video; // importar esta libreria para poder usar el reproductor de video
public class intro : MonoBehaviour
{   
    VideoPlayer player; // reproductor de video (contiene infomacion del video)
    [SerializeField] GameObject canvas; // objeto que contiene la interfaz

    private void Awake() // funcion que se activa cuando el elemento este cargado
    {
        player = GetComponent<VideoPlayer>(); // obtenemos el componente video player del elemento intro
  
    }
    
    void Update() //funcion que se activa cada frame
    {
        if (!player.isPlaying) // comprobamos en cada frame si el video se esta reproduciendo
        {
            // cuando no se este reporduciendo ocultamos el video y la interfaz
            canvas.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
