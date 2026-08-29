using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    // ปุ่ม Start Game
    public void Startgame()
    {
        SceneManager.LoadScene("Scene01");
    }

    // ปุ่ม Exit
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exit Game");
    }
}