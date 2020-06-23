using UnityEngine;
using UnityEngine.UI;

public class ColumnRescaleChild : MonoBehaviour
{
    public GameObject exampleParent;
    public GameObject exampleChildrenContent;

    RectTransform rectTransform;
    GridLayoutGroup gridLayout;

    // Start is called before the first frame update
    void Start()
    {



        rectTransform = exampleParent.GetComponent<RectTransform>();
        gridLayout = GetComponent<GridLayoutGroup>();

        int childCount = transform.childCount;

        float w = rectTransform.rect.width;
        float h = rectTransform.rect.height / childCount;

        childrenRescale(w, h);
        lol(h);

        Debug.Log("column height = " + h);
        Debug.Log("column width = " + w);
    }

    private void childrenRescale(float w, float h)
    {
        gridLayout.cellSize = new Vector2(w, h);

    }


    private void lol(float h)
    {
        float childContentHeight = h - 40f;

        gridLayout = exampleChildrenContent.GetComponent<GridLayoutGroup>();

        gridLayout.cellSize = new Vector2(childContentHeight, childContentHeight);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
