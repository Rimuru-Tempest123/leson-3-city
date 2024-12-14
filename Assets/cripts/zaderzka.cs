using UnityEngine;

public class zaderzka : MonoBehaviour
{
    // Ётот метод запускаетс€, когда игра начинаетс€
    void Start()
    {
        // ћы говорим Unity подождать 2 секунды и потом выполнить метод ShowMessage
        Invoke("ShowMessage", 2f);
    }

    // Ёто метод, который выполн€етс€ после задержки
    void ShowMessage()
    {
        // ¬ыводим сообщение в консоль
        Debug.Log("ѕрошло 2 секунды!");
    }
}