using System.Collections;
using UnityEngine;

public class respawn : MonoBehaviour
{
    public GameObject objectToRespawn1; // Объект, который нужно респавнить
    public GameObject objectToRespawn2; // Объект, который нужно респавнить
    public GameObject objectToRespawn3; // Объект, который нужно респавнить
    public GameObject objectToRespawn4; // Объект, который нужно респавнить

    public Vector3 cordinetSpawn = new Vector3( 27,0,2); // Координаты респавна
    public float respawnDelay = 3.0f; // Задержка перед респавном


    private void Start()
    {
        // спавн с интервалом
        InvokeRepeating("RespawnObjects", 1, respawnDelay);

    }

    
    private void RespawnObjects()
    {
        // создать объект, в заданом месте с обычным поворотом 
        Instantiate(objectToRespawn1, cordinetSpawn, Quaternion.identity);
        Instantiate(objectToRespawn2, cordinetSpawn, Quaternion.identity);
        Instantiate(objectToRespawn3, cordinetSpawn, Quaternion.identity);
        Instantiate(objectToRespawn4, cordinetSpawn, Quaternion.identity);
    }
}