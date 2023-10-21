using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadSceneByIndex(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void LoadNextScene()
    {
        LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadPreviousScene()
    {
        LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex - 1);
        Debug.Log(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
