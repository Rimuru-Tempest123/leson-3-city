using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 5f; // Сила прыжка
    private bool isGrounded = true; // Персонаж на земле

    private Rigidbody rb;

    void Start()
    {
        // Получаем(берём компонент и кладём в переменную рб) компонент Rigidbody
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Проверяем, нажата ли кнопка прыжка и персонаж на земле
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            JumpRb(); // Выполняем прыжок - запускаем наш метод
        }
    }

    void JumpRb()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // Добавляем силу вверх
        isGrounded = false; // Теперь он в воздухе
    }

    void OnCollisionEnter(Collision other)
    {
        // Проверяем столкновение с землей
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true; // Персонаж снова на земле
        }
    }
}
