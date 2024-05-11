using UnityEngine;

// Lớp Node để biểu diễn mỗi nút trong danh sách liên kết kép
public class Node2
{
    public GameObject Data; // GameObject của nút
    public Node2 Previous; // Tham chiếu đến nút trước đó trong danh sách
    public Node2 Next; // Tham chiếu đến nút tiếp theo trong danh sách

    // Constructor để tạo một nút mới với GameObject cho trước
    public Node2(GameObject data)
    {
        Data = data;
        Previous = null;
        Next = null;
    }
}

// Lớp DoublyLinkedList đại diện cho danh sách liên kết kép
public class DoublyLinkedList
{
    public Node2 Head; // Tham chiếu đến nút đầu tiên trong danh sách
    public Node2 Tail; // Tham chiếu đến nút cuối cùng trong danh sách

    // Phương thức để thêm một GameObject vào cuối danh sách
    public void AddLast(GameObject data)
    {
        Node2 newNode = new Node2(data);
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            newNode.Previous = Tail;
            Tail.Next = newNode;
            Tail = newNode;
        }
    }

    // Phương thức để hiển thị danh sách liên kết (hiển thị vị trí của các GameObject)
    public void DisplayList()
    {
        Node2 current = Head;
        while (current != null)
        {
            Debug.Log(current.Data.transform.position);
            current = current.Next;
        }
    }
}

// Lớp chương trình để thực thi ví dụ
public class Program : MonoBehaviour
{
    void Start()
    {
        // Tạo một đối tượng DoublyLinkedList
        DoublyLinkedList myList = new DoublyLinkedList();

        // Thêm các GameObject vào danh sách liên kết
        myList.AddLast(GameObject.Find("Cube"));
        myList.AddLast(GameObject.Find("Sphere"));
        myList.AddLast(GameObject.Find("Cylinder"));

        // Hiển thị danh sách liên kết (hiển thị vị trí của các GameObject)
        myList.DisplayList();
    }
}
