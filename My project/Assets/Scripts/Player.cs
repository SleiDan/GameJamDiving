 using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float initialMoveSpeed = 1f; // Начальная скорость движения
    public float accelerationRate = 0.1f; // Величина ускорения
    private Rigidbody2D rb;
    private Animator animator;
    private float currentMoveSpeed; // Текущая скорость движения
    private float moveDirectionX;
    private float moveDirectionY;

    private enum MovementState { idle, swim, back }
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        currentMoveSpeed = initialMoveSpeed;
    }

    private void Update()
    {
        /*float moveDirection = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(rb.velocity.x, moveDirection * currentMoveSpeed);*/
        float moveDirectionX = Input.GetAxis("Horizontal"); // Получаем ввод горизонтального направления (-1 для влево, 1 для вправо)
        float moveDirectionY = Input.GetAxis("Vertical");   // Получаем ввод вертикального направления (-1 для вниз, 1 для вверх)

        MovementState state;

        if (moveDirectionX > 0f && moveDirectionY == 0f)
        {
            state = MovementState.swim;
        }
        else if (moveDirectionX < 0f)
        {
            state = MovementState.back;
        }
        else
        {
            state = MovementState.idle;
        }
        animator.SetInteger("state", (int)state);

        // Применяем скорость перемещения к rigidbody персонажа
        rb.velocity = new Vector2(moveDirectionX * currentMoveSpeed, moveDirectionY * currentMoveSpeed);
        
        // Увеличиваем текущую скорость с каждым кадром
        currentMoveSpeed += accelerationRate * Time.deltaTime;
    }

    private void UpdateAnimationState()
    {
        
    }
    // Добавляем метод для получения позиции игрока
    public Vector2 GetPosition()
    {
        return rb.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
        }
    }

    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        animator.SetTrigger("death");

        //Time.timeScale = 0f;
    }
    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
