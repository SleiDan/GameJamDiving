using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Скорость перемещения персонажа

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float moveDirection = Input.GetAxis("Horizontal"); // Получаем ввод горизонтального направления (-1 для влево, 1 для вправо)

        // Применяем скорость перемещения к rigidbody персонажа
        rb.velocity = new Vector2(moveDirection * moveSpeed, rb.velocity.y);
    }
}
