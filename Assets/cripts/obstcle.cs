using UnityEngine;

public class obstcle : MonoBehaviour
{

    public float speed = 20; 
    void Update()
    {
     transform.Translate(Vector3.left * Time.deltaTime * speed);   
    }
}
