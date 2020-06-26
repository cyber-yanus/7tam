using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColorCreator : MonoBehaviour
{
    public Sprite spriteButton;
    public Sprite progresbarSprite;
    public Font fontForTextNumberColor;
    public PlayerScriptableObject player;

    public void create(List<Color> colors, List<int> colorsNumber)
    {
        for (int i = 0; i < colors.Count; i++)
        {
            GameObject buttonParent = new GameObject("button parent", typeof(RectTransform), typeof(ProgressBarController));
            buttonParent.transform.SetParent(transform);

            GameObject progressBar = new GameObject("color progress bar", typeof(Image));
            progressBar.transform.localScale = new Vector3(0.007f, 0.007f, 0.007f);
            progressBar.transform.rotation = Quaternion.Euler(0f, 0f, 180f);

            buttonParent.GetComponent<ProgressBarController>().progressBar = progressBar;
            buttonParent.GetComponent<ProgressBarController>().progressBarId = i;
            buttonParent.GetComponent<ProgressBarController>().calculateStep(colorsNumber[i]);

            Image progressBarImage = progressBar.GetComponent<Image>();
            progressBarImage.sprite = progresbarSprite;
            progressBarImage.type = Image.Type.Filled;
            progressBarImage.preserveAspect = true;
            progressBarImage.fillAmount = 0;

            progressBar.transform.SetParent(buttonParent.transform);
            progressBar.SetActive(false);


            GameObject colorButton = new GameObject("color button", typeof(Button), typeof(Image), typeof(ColorButtonListner));
            colorButton.transform.localScale = new Vector3(0.005f, 0.005f, 0.005f);

            Image buttonImage = colorButton.GetComponent<Image>();
            buttonImage.sprite = spriteButton;
            buttonImage.color = colors[i];

            ColorButtonListner colorButtonListner = colorButton.GetComponent<ColorButtonListner>();
            colorButtonListner.player = player;

            colorButton.transform.SetParent(buttonParent.transform);

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
