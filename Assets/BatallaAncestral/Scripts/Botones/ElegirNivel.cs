using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MoreMountains.Tools;

public class ElegirNivel: MonoBehaviour
{
    public void AbrirElegirNivel()
    {
        MMSceneLoadingManager.LoadScene("ElegirNivel");
    }

}
