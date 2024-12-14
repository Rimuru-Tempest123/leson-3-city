using UnityEngine;

public class Tp : MonoBehaviour
{
    private Vector3 startPos;
    public SpriteRenderer backgroundSprite;
    public float moveSpeed = 1f;
    private void Start()
    {
        startPos = transform.position;  
    }
    void Update()
    {
        // Транслируем фон влево
        backgroundSprite.transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);

        // Ограничиваем перемещение фона
        if (backgroundSprite.transform.position.x < startPos.x-backgroundSprite.bounds.size.x/2)
        {
            // Возвращаем фон в начало
            backgroundSprite.transform.position = startPos;
        }
    }
}