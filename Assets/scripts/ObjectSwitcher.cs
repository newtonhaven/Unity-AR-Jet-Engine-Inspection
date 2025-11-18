using UnityEngine;

public class ObjectSwitcher : MonoBehaviour
{
    [SerializeField] private GameObject[] objects;

    public void ShowObject(int index)
    {
        // Disable all objects
        foreach (var obj in objects)
            obj.SetActive(false);

        // Enable one
        if (index >= 0 && index < objects.Length)
            objects[index].SetActive(true);
    }
}
