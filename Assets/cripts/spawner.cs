using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] obstacles;
    private int index;
    void Start()
    {
        InvokeRepeating("", 2, 2f);
    }

   
    void Spawn()
    {
     Vector3 pos = new Vector3(30,0,0);   
        index = Random.Range(0,obstacles.Length);
        Instantiate(obstacles[index], pos, obstacles[index].transform.rotation);
    }
}
