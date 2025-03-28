using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManger : MonoBehaviour
{
    public void GotoMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void GotoNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadSceneAsync(currentSceneIndex+1, LoadSceneMode.Single);
    }

    public void GotoSetting()
    {

    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ReStart()
    {
        var activeScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(activeScene.name);
    }
}
