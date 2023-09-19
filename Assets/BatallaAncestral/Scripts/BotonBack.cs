using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonBack : MonoBehaviour
{
    public string Home;
    public void DevolverseAHome()
    {
        SceneManager.LoadScene("Home");
    }
    
}
