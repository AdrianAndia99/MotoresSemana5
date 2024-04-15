using UnityEngine;

public class SeguimientoEnemigo : MonoBehaviour
{
    public GameObject puntoA;
    public GameObject puntoB;
    private Rigidbody2D rigid2D;
    private Transform currentPoint;
    public float speed;

    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        currentPoint = puntoB.transform;
    }

    void Update()
    {
        Vector2 direction = currentPoint.position - transform.position;

        rigid2D.velocity = direction.normalized * speed;

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f)
        {
            if (currentPoint == puntoB.transform)
            {
                currentPoint = puntoA.transform;
            }
            else
            {
                currentPoint = puntoB.transform;
            }
        }
    }
}