using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public bool useArrows = false; 
    public string inputAxis = "Vertical"; 

    private void Update()
    {
        float move = 0f;

        if (useArrows)
        {
            // Movimiento con ↑ / ↓
            if (Input.GetKey(KeyCode.UpArrow))
                move = speed * Time.deltaTime;
            else if (Input.GetKey(KeyCode.DownArrow))
                move = -speed * Time.deltaTime;
        }
        else
        {
            // Movimiento con Input Manager (ej: "Vertical", "Vertical2")
            move = Input.GetAxisRaw(inputAxis) * speed * Time.deltaTime;
        }

        transform.Translate(0, move, 0);

        // Limitar movimiento dentro de la pantalla
        float yClamp = Mathf.Clamp(transform.position.y, -4f, 4f);
        transform.position = new Vector2(transform.position.x, yClamp);
    }
}