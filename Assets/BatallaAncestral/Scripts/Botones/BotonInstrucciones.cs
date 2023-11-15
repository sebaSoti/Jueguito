using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MoreMountains.Tools;
public class BotonInstrucciones : MonoBehaviour
{
    public string Instrucciones;
    public void AbrirInstrucciones()
    {
        MMSceneLoadingManager.LoadScene ("Instrucciones");
    }
}
