using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonCreditos : MonoBehaviour
{
    public string Creditos;
    public void AbrirSeccionCreditos()
    {
        SceneManager.LoadScene("Creditos");
    }
}
