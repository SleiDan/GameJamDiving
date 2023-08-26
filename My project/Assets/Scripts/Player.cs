using UnityEngine;

public class Player : MonoBehaviour
{
    public float initialMoveSpeed = 1f; // Начальная скорость движения
    public float accelerationRate = 0.1f; // Величина ускорения
    private Rigidbody2D rb;
    private float currentMoveSpeed; // Текущая скорость движения

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentMoveSpeed = initialMoveSpeed;
    }

    private void Update()
    {
        float moveDirection = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(rb.velocity.x, moveDirection * currentMoveSpeed);

        // Увеличиваем текущую скорость с каждым кадром
        currentMoveSpeed += accelerationRate * Time.deltaTime;
    }

    // Добавляем метод для получения позиции игрока
    public Vector2 GetPosition()
    {
        return rb.position;
    }
}
