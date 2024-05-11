using UnityEngine;

// Định nghĩa lớp Node để biểu diễn mỗi nút trong danh sách liên kết
public class Node
{
    public GameObject Data; // GameObject của nút
    public Node Next; // Tham chiếu đến nút tiếp theo trong danh sách

    // Constructor để tạo một nút mới với GameObject cho trước
    public Node(GameObject data)
    {
        Data = data;
        Next = null;
    }
}

// Lớp LinkedList đại diện cho danh sách liên kết đơn
public class LinkedList
{
    public Node Head; // Tham chiếu đến nút đầu tiên trong danh sách

    // Phương thức để thêm một GameObject vào đầu danh sách
    public void AddFirst(GameObject data)
    {
        Node newNode = new Node(data);
        newNode.Next = Head;
        Head = newNode;
    }

    // Phương thức để hiển thị danh sách liên kết (hiển thị vị trí của các GameObject)
    public void DisplayList()
    {
        Node current = Head;
        while (current != null)
        {
            Debug.Log(current.Data.transform.position);
            current = current.Next;
        }
    }
}

// Lớp chương trình để thực thi ví dụ
public class LinkedListExample1 : MonoBehaviour
{
    void Start()
    {
        // Tạo một đối tượng LinkedList
        LinkedList myList = new LinkedList();

        // Thêm các GameObject vào danh sách liên kết
        myList.AddFirst(GameObject.Find("Cube"));
        myList.AddFirst(GameObject.Find("Sphere"));
        myList.AddFirst(GameObject.Find("Cylinder"));

        // Hiển thị danh sách liên kết (hiển thị vị trí của các GameObject)
        myList.DisplayList();
    }
}
