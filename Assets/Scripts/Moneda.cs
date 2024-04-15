using UnityEngine;

public class Moneda : MonoBehaviour
{
    public int puntosGanados = 10;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SistemaPuntos sistemaPuntos = collision.gameObject.GetComponent<SistemaPuntos>();
            if (sistemaPuntos != null)
            {
                sistemaPuntos.AumentarPuntaje(puntosGanados);
            }

            Destroy(gameObject);
        }
    }
}