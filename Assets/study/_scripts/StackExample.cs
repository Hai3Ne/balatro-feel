using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StackExample : MonoBehaviour
{
    Stack<string> stack;

    void Start()
    {
        // Khởi tạo Stack
        stack = new Stack<string>();

        // Thêm các phần tử vào ngăn xếp
        PushItems();

        // Xử lý ngăn xếp
        ProcessStack();
    }

    void PushItems()
    {
        // Thêm các phần tử vào ngăn xếp
        stack.Push("Task 1");
        stack.Push("Task 2");
        stack.Push("Task 3");
    }

    void ProcessStack()
    {
        // Xử lý các phần tử trong ngăn xếp cho đến khi ngăn xếp trống
        while (stack.Count > 0)
        {
            // Lấy phần tử trên cùng của ngăn xếp
            string task = stack.Pop();

            // Xử lý công việc
            Debug.Log("Processing task: " + task);

        }
    }
}
