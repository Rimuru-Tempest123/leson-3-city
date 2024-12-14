using System.Collections;
using UnityEngine;

public class respawn : MonoBehaviour
{
    public GameObject objectToRespawn1; // ������, ������� ����� ����������
    public GameObject objectToRespawn2; // ������, ������� ����� ����������
    public GameObject objectToRespawn3; // ������, ������� ����� ����������
    public GameObject objectToRespawn4; // ������, ������� ����� ����������

    public Vector3 cordinetSpawn = new Vector3( 27,0,2); // ���������� ��������
    public float respawnDelay = 3.0f; // �������� ����� ���������


    private void Start()
    {
        // ����� � ����������
        InvokeRepeating("RespawnObjects", 1, respawnDelay);

    }

    
    private void RespawnObjects()
    {
        // ������� ������, � ������� ����� � ������� ��������� 
        Instantiate(objectToRespawn1, cordinetSpawn, Quaternion.identity);
        Instantiate(objectToRespawn2, cordinetSpawn, Quaternion.identity);
        Instantiate(objectToRespawn3, cordinetSpawn, Quaternion.identity);
        Instantiate(objectToRespawn4, cordinetSpawn, Quaternion.identity);
    }
}