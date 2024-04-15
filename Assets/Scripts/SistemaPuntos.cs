using UnityEngine;
using UnityEngine.Events;

public class SistemaPuntos : MonoBehaviour
{
    public delegate void PuntajeActualizado(int nuevoPuntaje);
    public static event PuntajeActualizado OnPuntajeActualizado;
    public UnityEvent<int> OnPuntajeCambiado;

    public int puntaje = 0;

    void Start()
    {
        puntaje = PlayerPrefs.GetInt("PuntajeGuardado", 0);
        ActualizarPuntaje();

    }
    public void AumentarPuntaje(int puntos)
    {
        puntaje += puntos;
        ActualizarPuntaje();
    }
    void ActualizarPuntaje()
    {
        PlayerPrefs.SetInt("PuntajeGuardado", puntaje);
        PlayerPrefs.Save();
        OnPuntajeActualizado?.Invoke(puntaje);
    }
}