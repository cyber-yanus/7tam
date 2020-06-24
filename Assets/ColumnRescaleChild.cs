using UnityEngine;
using UnityEngine.UI;

public class ColumnRescaleChild : MonoBehaviour
{
    public GameObject exampleParent;

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

        Debug.Log("column height = " + h);
        Debug.Log("column width = " + w);
    }

    private void childrenRescale(float w, float h)
    {
        gridLayout.cellSize = new Vector2(w, h);

    }

}
