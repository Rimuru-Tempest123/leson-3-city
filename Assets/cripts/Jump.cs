using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 5f; // ���� ������
    private bool isGrounded = true; // �������� �� �����

    private Rigidbody rb;

    void Start()
    {
        // ��������(���� ��������� � ����� � ���������� ��) ��������� Rigidbody
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // ���������, ������ �� ������ ������ � �������� �� �����
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            JumpRb(); // ��������� ������ - ��������� ��� �����
        }
    }

    void JumpRb()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // ��������� ���� �����
        isGrounded = false; // ������ �� � �������
    }

    void OnCollisionEnter(Collision other)
    {
        // ��������� ������������ � ������
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true; // �������� ����� �� �����
        }
    }
}
