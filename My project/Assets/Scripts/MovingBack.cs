using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float initialMoveSpeed = 1f; // Начальная скорость движения влево
    public float accelerationRate = 0.05f; // Величина ускорения
    private float currentMoveSpeed; // Текущая скорость движения влево

    private void Start()
    {
        currentMoveSpeed = initialMoveSpeed;
    }

    private void Update()
    {
        // Получаем текущую позицию объекта
        Vector3 currentPosition = transform.position;

        // Вычисляем новую позицию, сдвинутую влево с учетом текущей скорости
        Vector3 newPosition = currentPosition + Vector3.right * currentMoveSpeed * Time.deltaTime;

        // Применяем новую позицию к объекту
        transform.position = newPosition;

        // Увеличиваем текущую скорость с каждым кадром
        currentMoveSpeed += accelerationRate * Time.deltaTime;
    }

    public void Death()
    {
        currentMoveSpeed = 0f;
    }
}
