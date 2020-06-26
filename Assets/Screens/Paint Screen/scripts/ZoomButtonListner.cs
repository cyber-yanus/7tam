using UnityEngine;
using UnityEngine.UI;

public class ZoomButtonListner : MonoBehaviour
{
    private Button button;
    private string saveName = "zoom train";

    public GameObject trainGameObject;


    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(execute);
    }

    private void execute()
    {
        if (PlayerPrefs.GetString(saveName).Equals(""))
        {
            Debug.Log("first use zoom");

            PlayerPrefs.SetString(saveName, "yes");

            trainGameObject.SetActive(true);
        }


    }
}
