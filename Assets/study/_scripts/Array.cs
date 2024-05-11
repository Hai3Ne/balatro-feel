using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    ArrayList list;

    void Start()
    {
        // Khởi tạo ArrayList
        list = new ArrayList();

        // Thêm các phần tử vào ArrayList
        list.Add(1);
        list.Add("Hello");
        list.Add(3.14f);

        // In ra các phần tử trong ArrayList
        foreach (object item in list)
        {
            Debug.Log(item);
        }
    }
}
