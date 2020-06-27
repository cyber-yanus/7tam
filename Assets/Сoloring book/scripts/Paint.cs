using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class Paint : MonoBehaviour, IPointerClickHandler
{
    public GameObject mainCanvas;
    public GameObject topPanel;
    public GameObject colorContent;
    public Sprite example;
   

    public PlayerScriptableObject player;

    private SVGImage svg;

    private float x1, y1;

    private float heightDiff;

    private float localWidth;
    private float localHeight;

    void Start()
    {
        svg = GetComponent<SVGImage>();

        relationCalculate();
    }

    private void relationCalculate()
    {
        float globalHeight = svg.GetComponent<RectTransform>().rect.height;
        float globalWidth = svg.GetComponent<RectTransform>().rect.width;


        float diff = mainCanvas.GetComponent<RectTransform>().rect.height -
            topPanel.GetComponent<RectTransform>().rect.height -
            globalHeight;
        
        localWidth = svg.sprite.rect.width;
        localHeight = svg.sprite.rect.height;

        float locRelation = localWidth / localHeight;

        float g_h = globalWidth / locRelation;

        float x = (globalHeight - g_h) / 2;

        heightDiff = x + diff;

        float locRelationH = y1 = g_h / localHeight;
        float locRelationW = x1 =  globalWidth / localWidth;

    }

    public void paintArea(float x, float y, Color color)
    {
        svg.sprite.FloodFillArea((int)x, (int)y, color);
        svg.sprite.texture.Apply();
    }

    public void magicStickPaintArea(float x, float y, Color color)
    {
        
        int newX = (int)x;
        int newY = (int)localHeight - (int)y;


        if (checkBust(newX, newY, color))
        {
            svg.sprite.FloodFillArea(newX, newY, color);
            svg.sprite.texture.Apply();
        }
        
    }

    public IEnumerator magicSearchPaintArea(float x, float y, Color color)
    {
        int newX = (int)x;
        int newY = (int)localHeight - (int)y;

        if (checkBust(newX, newY, color))
        {
            svg.sprite.FloodFillArea(newX, newY, color);
            svg.sprite.texture.Apply();

            yield return new WaitForSeconds(0.5f);

            color.a = 0;
            svg.sprite.FloodFillArea(newX, newY, color);
            svg.sprite.texture.Apply();
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        float x = eventData.position.x;
        float y = eventData.position.y;

        float rescaleY = (y - heightDiff) / y1;
        float rescaleX = x / x1;

        Color color = player.CurrentColor;

        if (rescaleY > 0 && rescaleY < localHeight)
        {
            if (rescaleX > 0 && rescaleX < localWidth)
            {
                if (checkingForCompliance(rescaleX, rescaleY))
                {
                    colorContent.GetComponent<ButtonsColorController>().upProgressBar();

                    paintArea(rescaleX, rescaleY, color);
                }
            }
        }


    }

    private bool checkBust(int aX, int aY, Color color)
    {
        int colotingBookW = svg.sprite.texture.width;

        Color[] coloringBookColors = svg.sprite.texture.GetPixels();
        Color refCol = coloringBookColors[aX + aY * colotingBookW];

        return refCol == color ? false : true;

    }

    private bool checkingForCompliance(float aX, float aY)
    {
        int exampleW = example.texture.width;

        Color[] exampleColors = example.texture.GetPixels();
        Color refCol = exampleColors[(int)aX + (int)aY * exampleW];

        Color currentColor = player.CurrentColor;

        Debug.Log("refCol=" + refCol);
        Debug.Log("current color=" + currentColor);

        return refCol == currentColor ? true : false;
    }

}
