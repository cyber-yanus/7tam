using System;
using UnityEngine;
using UnityEngine.UI;

public class MagicStickButtonListner : MonoBehaviour
{
    private Button button;
    private string saveName = "magic stick train";

    public GameObject trainGameObject;

    public Text textWithCost;

    public PlayerScriptableObject player;

   
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteAll();

        button = GetComponent<Button>();

        button.onClick.AddListener(execute);
    }

    private void execute()
    {
        if (PlayerPrefs.GetString(saveName).Equals(""))
        {
            Debug.Log("first use magic stick");

            PlayerPrefs.SetString(saveName, "yes");

            trainGameObject.SetActive(true);
        }

        int cost = Convert.ToInt32(textWithCost.text);

        if (player.minusMoney(cost))
            actiavteMagicStick();

    }

    private void actiavteMagicStick()
    {
        Debug.Log("activate magic stick");
    }

}
