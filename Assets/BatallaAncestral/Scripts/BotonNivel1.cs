using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BotonNivel1 : MonoBehaviour
{
    public string Level1;
    public void AbrirNivel1()
    {
        SceneManager.LoadScene("Level1");
    }

}
