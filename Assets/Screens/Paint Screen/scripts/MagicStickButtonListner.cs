using DanielLochner.Assets.SimpleScrollSnap;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MagicStickButtonListner : MonoBehaviour
{
    private Button button;
    private string saveName = "magic stick train";

    public GameObject trainGameObject;

    public Text textWithCost;

    public PlayerScriptableObject player;
    public GameObject coloringBook;
    public CurrentColoringBook currentColoringBook;


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

            trainGameObject.GetComponent<SimpleScrollSnap>().startingPanel = 0;
            trainGameObject.SetActive(true);
        }

        int cost = Convert.ToInt32(textWithCost.text);

        if (player.minusMoney(cost))
            actiavteMagicStick();

    }

    private void actiavteMagicStick()
    {

        if (player.CurrentColor != null)
        {
            Debug.Log(currentColoringBook.StartPoints[player.CurrentColorId].points.Length);

            foreach (Vector2 startPoints in currentColoringBook.StartPoints[player.CurrentColorId].points)
            {
                int newX = (int)startPoints.x;
                int newY = (int)startPoints.y;

                if (newX != 0)
                    coloringBook.GetComponent<Paint>().magicStickPaintArea(newX, newY, player.CurrentColor);
            }

        }

        Debug.Log("activate magic stick");
    }


}
