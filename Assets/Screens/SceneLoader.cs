using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void loadNewScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

        Debug.Log("load " + sceneName + " scene");
    }

}
