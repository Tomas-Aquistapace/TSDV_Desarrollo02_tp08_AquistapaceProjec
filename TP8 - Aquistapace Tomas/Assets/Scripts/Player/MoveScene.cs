using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    public string scene;

    public void GoToScene()
    {
        SceneManager.LoadScene(scene);
    }
}
