using System;
using UnityEngine;
using UnityEngine.UI;

public class MagicSearchButtonListner : MonoBehaviour
{
    private Button button;
    private string saveName = "magic search train";

    public GameObject trainGameObject;

    public Text textWithCost;

    public PlayerScriptableObject player;


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
            Debug.Log("first use magic search");

            PlayerPrefs.SetString(saveName, "yes");

            trainGameObject.SetActive(true);
        }

       
        int cost = Convert.ToInt32(textWithCost.text);

        if (player.minusMoney(cost))
            activateMagicSearch();
    }


    private void activateMagicSearch()
    {
        Debug.Log("activate magic search");
    }
}
