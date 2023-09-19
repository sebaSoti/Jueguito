using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonInstrucciones : MonoBehaviour
{
    public string Instrucciones;
    public void AbrirInstrucciones()
    {
        SceneManager.LoadScene("Instrucciones");
    }
}
