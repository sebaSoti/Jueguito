using System.Collections;
using System.Collections.Generic;
using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TMPro;
using UnityEngine;


public class ContadorVidasUI : MonoBehaviour
{
    [SerializeField]
    private TMP_Text contador;

    // Start is called before the first frame update
    void Start()
    {
        // Inicia el contador de vidas en 20
        GameManager.Instance.CurrentLives = 5;
    }

    // Update is called once per frame
    void Update()
    {
        // Actualiza el texto del contador con el valor actual de vidas
        contador.SetText(GameManager.Instance.CurrentLives.ToString());

        // Verifica si las vidas han llegado a cero
        if (GameManager.Instance.CurrentLives <= 0)
        {
            // Muestra un mensaje en la consola
            Debug.Log("Perdiste");

            // Carga la escena "ElegirNivel"
            MMSceneLoadingManager.LoadScene("ElegirNivel");
        }
    }
}



