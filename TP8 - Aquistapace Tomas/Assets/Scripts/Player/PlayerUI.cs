﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerUI : MonoBehaviour
{
    public string scene;

    public void GoToScene()
    {
        SceneManager.LoadScene(scene);
    }
}
