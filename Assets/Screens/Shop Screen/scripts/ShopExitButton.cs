using UnityEngine;
using UnityEngine.UI;

public class ShopExitButton : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        Button button = GetComponent<Button>();

        button.onClick.AddListener(execute);
    }

    private void execute()
    {
        SceneLoader.loadNewScene("Paint");
    }
}
