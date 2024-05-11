using UnityEngine;
using System.Collections.Generic;

public class ListExample : MonoBehaviour
{
    // Danh sách các GameObject
    List<GameObject> objectList = new List<GameObject>();

    void Start()
    {
        // Thêm các đối tượng GameObject vào danh sách
        AddObjectsToList();

        // Hiển thị thông tin của từng đối tượng trong danh sách
        DisplayObjectInfo();
    }

    void AddObjectsToList()
    {
        // Thêm các đối tượng GameObject vào danh sách
        objectList.Add(GameObject.Find("Cube"));
        objectList.Add(GameObject.Find("Sphere"));
        objectList.Add(GameObject.Find("Cylinder"));
    }

    void DisplayObjectInfo()
    {
        // Hiển thị thông tin của từng đối tượng trong danh sách
        foreach (GameObject obj in objectList)
        {
            if (obj != null)
            {
                Debug.Log("Object Name: " + obj.name);
                Debug.Log("Object Position: " + obj.transform.position);
            }
        }
    }
}
