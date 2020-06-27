using UnityEngine;
using UnityEngine.UI;

public class MainButton : MonoBehaviour
{
    public bool isMainScene;
         

    // Start is called before the first frame update
    void Start()
    {
        Button button = GetComponent<Button>();

        button.onClick.AddListener(execute);
    }

    private void execute()
    {
        if(!isMainScene)
            SceneLoader.loadNewScene("Main");
    }

}
