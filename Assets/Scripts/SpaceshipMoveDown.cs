using UnityEngine;

public class SpaceshipMoveDown : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Vector3 startPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
       if(transform.position.z > 10f)
       {
           transform.position = startPosition;
       }
    }
}
