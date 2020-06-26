using UnityEngine;
using UnityEngine.UI;

public class ShopButtonListner : MonoBehaviour
{
    private Button button;

    //public CurrentColoringBook currentColoringBook;
    //public ColoringBookData coloringBook;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(execute);
    }

    private void execute()
    {
        //currentColoringBook.ColoringBook = coloringBook

        SceneLoader.loadNewScene("Shop");
    }
}
