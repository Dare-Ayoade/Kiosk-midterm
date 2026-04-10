using UnityEngine;

public class ToggleObject : MonoBehaviour
{
    public GameObject objectToToggle;
    public void ToggleVisibility()
    {
        if (objectToToggle != null)
        {
            objectToToggle.SetActive(!objectToToggle.activeInHierarchy); 
        }
    }
}
