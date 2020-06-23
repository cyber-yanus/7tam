using UnityEngine;
using UnityEngine.UI;

public class ReScaleChild : MonoBehaviour
{
    public GameObject exampleParent;

    RectTransform rectTransform;
    GridLayoutGroup gridLayout;

    // Start is called before the first frame update
    void Start()
    {
        rectTransform = exampleParent.GetComponent<RectTransform>();
        gridLayout = GetComponent<GridLayoutGroup>();
        
        float w = rectTransform.rect.width;
        float h = rectTransform.rect.height;

        childrenSettings(w, h);

        Debug.Log("height = " + h);
        Debug.Log("width = " + w);
    }

    private void childrenSettings(float w, float h)
    {
        int childCount = transform.childCount;

        gridLayout.cellSize = new Vector2(w, h / childCount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
