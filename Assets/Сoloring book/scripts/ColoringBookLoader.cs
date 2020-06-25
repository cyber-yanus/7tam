using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ColoringBookLoader : MonoBehaviour
{
    public SVGImage coloringImage;

    public GameObject colorContentList;

    public CurrentColoringBook currentColoringBook;

                    

    // Start is called before the first frame update
    void Start()
    {
        loadColoringImage();
        //loadColoringBookPrefab();
        loadColors();
    }

    private void loadColoringImage()
    {
        coloringImage.sprite = currentColoringBook.ColoringBook.ColoringBookSprite;
        coloringImage.GetComponent<Paint>().example = currentColoringBook.ColoringBook.Example;
    }

    private void loadColoringBookPrefab()
    {
        GameObject coloringBookPrefab = currentColoringBook.ColoringBook.ColoringBookPrefab;

        Instantiate(coloringBookPrefab);
    }

    private void loadColors()
    {
        List<Color> colors = currentColoringBook.ColoringBook.Colors;

        ButtonColorCreator buttonColorCreator = colorContentList.GetComponent<ButtonColorCreator>();

        buttonColorCreator.create(colors);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
