using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MoreMountains.Tools;
public class BotonBack : MonoBehaviour
{
    public string Home;
    public void DevolverseAHome()
    {
       MMSceneLoadingManager.LoadScene ("Home");
    }
    
}
