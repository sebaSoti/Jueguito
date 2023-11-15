using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MoreMountains.Tools;

public class BotonNivel1 : MonoBehaviour
{
    public string Level1;
    public void AbrirNivel1()
    {
        MMSceneLoadingManager.LoadScene ("Level1");
    }

}
