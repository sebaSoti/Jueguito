using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MoreMountains.Tools;
public class BotonCreditos : MonoBehaviour
{
    public string Creditos;
    public void AbrirSeccionCreditos()
    {
        MMSceneLoadingManager.LoadScene ("Creditos");
    }
}
