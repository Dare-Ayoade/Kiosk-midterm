using UnityEngine;

public class MoveSpaceship : MonoBehaviour
{
    public float speed = 10f;
    public Vector3 startPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
         if(transform.position.z > 70f)
       {
           transform.position = startPosition;
       }
    }

}
