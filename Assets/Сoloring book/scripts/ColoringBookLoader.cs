using System.Collections.Generic;
using UnityEngine;

public class ColoringBookLoader : MonoBehaviour
{
    public SVGImage coloringImage;

    public GameObject colorContentList;

    public CurrentColoringBook currentColoringBook;

 
    void Start()
    {
        loadColoringImage();
        loadColors();
    }

    private void loadColoringImage()
    {
        coloringImage.sprite = currentColoringBook.ColoringBook.ColoringBookSprite;
        coloringImage.GetComponent<Paint>().example = currentColoringBook.ColoringBook.Example;
    }

    private void loadColors()
    {
        List<Color> colors = currentColoringBook.ColoringBook.Colors;
        List<int> colorsNumber = currentColoringBook.ColoringBook.ColorsCount;

        ButtonColorCreator buttonColorCreator = colorContentList.GetComponent<ButtonColorCreator>();

        buttonColorCreator.create(colors, colorsNumber);

    }
}
