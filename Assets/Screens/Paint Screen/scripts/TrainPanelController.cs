using UnityEngine;
using UnityEngine.UI;
using static DanielLochner.Assets.SimpleScrollSnap.SimpleScrollSnap;

public class TrainPanelController : MonoBehaviour
{
    public GameObject coloringBook;

    private MovementAxis movementAxis = MovementAxis.Horizontal;

    private float contentW;
    private float maxContentX;
    private float minContentX;

    private void Start()
    {
        contentW = GetComponent<ScrollRect>().content.GetComponent<RectTransform>().rect.width;

        maxContentX = - (contentW + contentW / 3) * 2;
        Debug.Log(maxContentX);

        minContentX = contentW / 3;
        Debug.Log(minContentX);

    }

    private void OnEnable()
    {
        coloringBook.GetComponent<BoxCollider2D>().enabled = false;
    }


    private void OnDisable()
    {
        coloringBook.GetComponent<BoxCollider2D>().enabled = true;
    }

    private void Update()
    {
        float currentPosition = GetComponent<ScrollRect>().content.GetComponent<RectTransform>().anchoredPosition.x;

        if (exit(currentPosition))
        {
            GetComponent<ScrollRect>().content.GetComponent<RectTransform>().anchoredPosition = new Vector2(0,0);

            this.gameObject.SetActive(false);
        }
    }

    private bool exit(float currentPosition)
    {
        if (currentPosition > minContentX || currentPosition < maxContentX)
            return true;

        return false;
    }
}
