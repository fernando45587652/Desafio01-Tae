using UnityEngine;

public class BallController : MonoBehaviour
{
    public float initialSpeed = 5f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        LaunchBall();
    }

    void LaunchBall()
    {
        // Dirección aleatoria al inicio
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(-1f, 1f);
        rb.velocity = new Vector2(x, y).normalized * initialSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Opción: aumentar un poco la velocidad con cada rebote
        rb.velocity *= 1.05f;
    }

    public void ResetBall()
    {
        rb.velocity = Vector2.zero;
        transform.position = Vector2.zero;
        Invoke("LaunchBall", 1f); // espera 1s antes de lanzar otra vez
    }
}
