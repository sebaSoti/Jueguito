using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BotonJugar : MonoBehaviour
{
    public string Level1;
    public void AbrirSeccionLevelOne()
    {
        SceneManager.LoadScene("Level1");
    }

}
