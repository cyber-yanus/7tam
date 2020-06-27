using UnityEngine;
using UnityEngine.UI;

public class ColorButtonListner : MonoBehaviour
{
    private Button button;

    public PlayerScriptableObject player;

    public int Id;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(execute);
    }


    private void execute()
    {
        player.CurrentColor = GetComponent<Image>().color;
        player.CurrentColorId = Id;

        transform.parent.parent.GetComponent<ButtonsColorController>().selectButton(this.gameObject);


    }


}
