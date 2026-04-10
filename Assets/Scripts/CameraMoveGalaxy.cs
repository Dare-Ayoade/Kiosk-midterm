using UnityEngine;

public class CameraMoveGalaxy : MonoBehaviour
{
    public float cameraSpeed = 0.5f;
    public float rotationSpeed = 0.005f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * cameraSpeed * Time.deltaTime);
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime);
       

    }
}
