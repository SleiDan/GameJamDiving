using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float moveSpeed = 1f; // Скорость движения влево

    private void Update()
    {
        // Получаем текущую позицию объекта
        Vector3 currentPosition = transform.position;

        // Вычисляем новую позицию, сдвинутую влево
        Vector3 newPosition = currentPosition + Vector3.right * moveSpeed * Time.deltaTime;

        // Применяем новую позицию к объекту
        transform.position = newPosition;
    }
}
