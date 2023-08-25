using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float moveDirection = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(rb.velocity.x, moveDirection * moveSpeed);
    }

    // Добавляем метод для получения позиции игрока
    public Vector2 GetPosition()
    {
        return rb.position;
    }
}
