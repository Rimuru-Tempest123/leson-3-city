using UnityEngine;

public class zaderzka : MonoBehaviour
{
    // ���� ����� �����������, ����� ���� ����������
    void Start()
    {
        // �� ������� Unity ��������� 2 ������� � ����� ��������� ����� ShowMessage
        Invoke("ShowMessage", 2f);
    }

    // ��� �����, ������� ����������� ����� ��������
    void ShowMessage()
    {
        // ������� ��������� � �������
        Debug.Log("������ 2 �������!");
    }
}