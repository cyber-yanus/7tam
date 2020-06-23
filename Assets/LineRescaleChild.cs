using UnityEngine;
using UnityEngine.UI;

public class LineRescaleChild : MonoBehaviour
{
    public GameObject exampleParent;

    RectTransform rectTransform;
    GridLayoutGroup gridLayout;


    // Start is called before the first frame update
    void Start()
    {
        gridLayout = GetComponent<GridLayoutGroup>();
    }


    // Update is called once per frame
    void Update()
    {
        rectTransform = exampleParent.GetComponent<RectTransform>();

        Rect rect = rectTransform.rect;

        float h = rect.height;

        childrenRescale(h);

    }


    private void childrenRescale(float h)
    {
        gridLayout.cellSize = new Vector2(h, h);
    }
}
