//using Boo.Lang;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColorCreator : MonoBehaviour
{
    public Sprite spriteButton;
    public Font fontForTextNumberColor;
    public PlayerScriptableObject player;

    public void create(List<Color> colors)
    {
        for (int i = 0; i < colors.Count; i++)
        {
            GameObject colorButton = new GameObject("color button", typeof(Button), typeof(Image), typeof(ColorButtonListner));
            colorButton.transform.localScale = new Vector3(0.005f, 0.005f, 0.005f);

            Image buttonImage = colorButton.GetComponent<Image>();
            buttonImage.sprite = spriteButton;
            buttonImage.color = colors[i];

            ColorButtonListner colorButtonListner = colorButton.GetComponent<ColorButtonListner>();
            colorButtonListner.player = player;

            colorButton.transform.SetParent(transform);

            GetComponent<ButtonsColorController>().addColorButton(colorButton);

            createTextNumberColor(i + 1, colorButton);
        }

    }

    private void createTextNumberColor(int number, GameObject parent)
    {
        GameObject textNumberGameObject = new GameObject("Text", typeof(Text));
        textNumberGameObject.transform.localScale = new Vector3(0.005f, 0.005f, 0.005f);


        Text textNumber = textNumberGameObject.GetComponent<Text>();
        textNumber.text = number.ToString();
        textNumber.font = fontForTextNumberColor;
        textNumber.fontStyle = FontStyle.Bold;
        textNumber.alignment = TextAnchor.MiddleCenter;
        textNumber.resizeTextForBestFit = true;

        textNumberGameObject.transform.SetParent(parent.transform);
    }

}
