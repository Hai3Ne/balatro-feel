using UnityEngine;
using System.Collections;

public class QueueExample : MonoBehaviour
{
    Queue queue;

    void Start()
    {
        // Khởi tạo Queue
        queue = new Queue();

        // Thêm các phần tử vào hàng đợi
        EnqueueItems();

        // Xử lý hàng đợi
        ProcessQueue();
    }

    void EnqueueItems()
    {
        // Thêm các phần tử vào hàng đợi
        queue.Enqueue("Task 1");
        queue.Enqueue("Task 2");
        queue.Enqueue("Task 3");
    }

    void ProcessQueue()
    {
        // Xử lý các phần tử trong hàng đợi cho đến khi hàng đợi trống
        while (queue.Count > 0)
        {
            // Lấy phần tử đầu tiên ra khỏi hàng đợi
            string task = (string)queue.Dequeue();

            // Xử lý công việc
            Debug.Log("Processing task: " + task);

        }
    }
}
