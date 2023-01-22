using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // importar esta libreria para cambiar entre escenas (niveles o pamtallas)

public class level : MonoBehaviour
{
    

    public void CambiarNivel(int level)
    {
        SceneManager.LoadScene(level); // cmambiamos de escena segun el nivel que le pasamos

        /*
         Para agregar escenas
        1. Ve a Unity
        2. Ve a la pestaña File
        3. Ve al apartado Build Settings
        4. Agrega la escena nueva en Build Scenes
         */
    }
}
