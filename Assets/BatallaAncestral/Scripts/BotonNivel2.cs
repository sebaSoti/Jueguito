using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BotonNivel2 : MonoBehaviour
{
    public string Level2;
    public void AbrirNivel2()
    {
        SceneManager.LoadScene("Level2");
    }

}
