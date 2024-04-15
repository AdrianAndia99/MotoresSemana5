using UnityEngine;
public class CambioColor : MonoBehaviour
{
    public GameObject jugador;

    void OnMouseDown()
    {
        Color colorSprite = GetComponent<SpriteRenderer>().color;
        jugador.GetComponent<SpriteRenderer>().color = colorSprite;
    }
}