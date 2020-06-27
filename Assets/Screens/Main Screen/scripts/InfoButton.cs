using UnityEngine;
using UnityEngine.UI;

public class InfoButton : MonoBehaviour
{
    public bool isInfoScene;

    // Start is called before the first frame update
    void Start()
    {
        Button button = GetComponent<Button>();

        button.onClick.AddListener(execute);
    }

    private void execute()
    {
        if(!isInfoScene)
            SceneLoader.loadNewScene("Info");
    }
}
