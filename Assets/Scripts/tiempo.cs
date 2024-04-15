using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class tiempo : MonoBehaviour
{
    public TextMeshProUGUI texto;
    private float Tiempo = 0f;

    void Update()
    {
        Tiempo = Tiempo + Time.deltaTime;
        ActualizarTiempo();
    }

    void ActualizarTiempo()
    {
        texto.text = "Tiempo: " + ((int)Tiempo).ToString();
    }

    public void CambiarNivel2()
    {
        PlayerPrefs.SetFloat("Tiempo", Tiempo);
        SceneManager.LoadScene("Juego2");
    }
}