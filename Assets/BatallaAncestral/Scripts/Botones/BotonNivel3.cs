using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MoreMountains.Tools;

public class BotonNivel3 : MonoBehaviour
{
    public string Level3;
    public void AbrirNivel3()
    {
        MMSceneLoadingManager.LoadScene ("Level3");
    }

}
