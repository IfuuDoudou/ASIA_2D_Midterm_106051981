using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void Nextlevel(string nameLV)
    {
        SceneManager.LoadScene(nameLV);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}