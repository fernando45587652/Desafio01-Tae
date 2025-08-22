using UnityEngine;

public class CPUController : MonoBehaviour
{
    public float speed = 8f;

    void Update()
    {
        float move = 0f;

        // --- CONTROL MANUAL (W / S) ---
        if (Input.GetKey(KeyCode.W))
        {
            move = speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            move = -speed * Time.deltaTime;
        }

        // Aplicar movimiento
        transform.Translate(0, move, 0);

        // Limitar movimiento en el eje Y
        transform.position = new Vector3(
            transform.position.x,
            Mathf.Clamp(transform.position.y, -4f, 4f),
            transform.position.z
        );
    }
}