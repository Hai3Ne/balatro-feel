using UnityEngine;
using System.Collections.Generic;

public class DictionaryExample : MonoBehaviour
{
    // Dictionary để lưu trữ đối tượng GameObject dựa vào tên của chúng
    Dictionary<string, GameObject> objectDictionary = new Dictionary<string, GameObject>();

    void Start()
    {
        // Thêm các đối tượng GameObject vào Dictionary
        AddObjectsToDictionary();

        // Truy cập và hiển thị thông tin của các đối tượng trong Dictionary
        DisplayObjectInfo("Cube");
        DisplayObjectInfo("Sphere");
        DisplayObjectInfo("Cylinder");
    }

    void AddObjectsToDictionary()
    {
        // Lấy đối tượng GameObject từ Scene và thêm vào Dictionary dựa vào tên của chúng
        GameObject cube = GameObject.Find("Cube");
        GameObject sphere = GameObject.Find("Sphere");
        GameObject cylinder = GameObject.Find("Cylinder");

        objectDictionary.Add("Cube", cube);
        objectDictionary.Add("Sphere", sphere);
        objectDictionary.Add("Cylinder", cylinder);
    }

    void DisplayObjectInfo(string objectName)
    {
        // Kiểm tra xem Dictionary có chứa đối tượng với tên được chỉ định không
        if (objectDictionary.ContainsKey(objectName))
        {
            // Lấy đối tượng từ Dictionary dựa vào tên
            GameObject obj = objectDictionary[objectName];

            // Hiển thị thông tin của đối tượng
            Debug.Log("Object Name: " + obj.name);
            Debug.Log("Object Position: " + obj.transform.position);
        }
        else
        {
            Debug.Log("Object with name " + objectName + " not found in dictionary.");
        }
    }
}
