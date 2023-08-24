using UnityEngine;

public class MoveUp : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f; // Скорость движения вверх

    private void Update()
    {
        // Перемещаем объект вверх на заданную скорость
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
    }
}
