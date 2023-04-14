using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    [SerializeField] string _nextLevelName;
    public void LoadGame()
    {
        SceneManager.LoadScene(_nextLevelName);
    }
}
