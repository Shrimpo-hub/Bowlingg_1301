using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Bowling : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private int forcePower = 10;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // กด Space เพื่อยิงลูก
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Shootball();
        }

        // กด D เพื่อเลื่อนไปขวา
        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            MoveRight();
        }

        // กด A เพื่อเลื่อนไปซ้าย
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            MoveLeft();
        }
    }

    // ยิงลูก Bowling
    public void Shootball()
    {
        rb.AddForce(Vector3.forward * forcePower, ForceMode.Impulse);
    }

    // ไปทางขวา
    private void MoveRight()
    {
        transform.position += new Vector3(0.5f, 0f, 0f);
    }

    // ไปทางซ้าย
    private void MoveLeft()
    {
        transform.position += new Vector3(-0.5f, 0f, 0f);
    }

    // ปุ่ม Restart
    public void Restart()
    {
        SceneManager.LoadScene("Scene01");
    }

    // ปุ่มกลับ Main Menu
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
