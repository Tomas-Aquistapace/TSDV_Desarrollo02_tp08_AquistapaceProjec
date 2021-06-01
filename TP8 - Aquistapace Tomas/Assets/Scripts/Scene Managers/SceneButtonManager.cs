using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButtonManager : MonoBehaviour
{
    public string sceneToPlay;

    public void PlayScene()
    {
        SceneManager.LoadScene(sceneToPlay);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
