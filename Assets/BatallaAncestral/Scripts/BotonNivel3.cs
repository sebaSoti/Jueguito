using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BotonNivel3 : MonoBehaviour
{
    public string Level3;
    public void AbrirNivel3()
    {
        SceneManager.LoadScene("Level3");
    }

}
