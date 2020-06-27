using UnityEngine;
using UnityEngine.UI;

public class SelectionColoringBook : MonoBehaviour
{
    public ColoringBookData coloringBook;
    public CurrentColoringBook currentColoringBook;


    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(Execute);
    }

    private void Execute()
    {
        currentColoringBook.ColoringBook = coloringBook;

        currentColoringBook.StartPoints = GetComponent<StartPointLoader>().StartPoints1;

        SceneLoader.loadNewScene("Paint");
    }


    
}
