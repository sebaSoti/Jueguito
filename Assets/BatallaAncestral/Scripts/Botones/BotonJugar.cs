using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MoreMountains.Tools;

public class BotonJugar : MonoBehaviour
{
    public string Level1;
    public void AbrirSeccionLevelOne()
    {
        MMSceneLoadingManager.LoadScene ("ElegirNivel");
    }

}
