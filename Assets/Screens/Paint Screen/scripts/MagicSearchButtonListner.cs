using DanielLochner.Assets.SimpleScrollSnap;
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
    public GameObject coloringBook;
    public CurrentColoringBook currentColoringBook;


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

            trainGameObject.GetComponent<SimpleScrollSnap>().startingPanel = 1;
            trainGameObject.SetActive(true);
        }

       
        int cost = Convert.ToInt32(textWithCost.text);

        if (player.minusMoney(cost))
            activateMagicSearch();
    }


    private void activateMagicSearch()
    {
        if (player.CurrentColor != null)
        {
            foreach (Vector2 startPoints in currentColoringBook.StartPoints[player.CurrentColorId].points)
            {
                int newX = (int)startPoints.x;
                int newY = (int)startPoints.y;

                if (newX != 0)
                    StartCoroutine(coloringBook.GetComponent<Paint>().magicSearchPaintArea(newX, newY, player.CurrentColor));
            }

        }

        Debug.Log("activate magic search");
    }
}
