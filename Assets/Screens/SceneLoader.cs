using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public static void loadNewScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

        Debug.Log("load " + sceneName + " scene");
    }

    public static void AsyncLoadNewScene(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName);
    }

}
