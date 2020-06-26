using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainPanelController : MonoBehaviour
{
    public SVGImage coloringBook;

    private void OnEnable()
    {
        coloringBook.GetComponent<BoxCollider2D>().usedByEffector = false;
    }


    private void OnDisable()
    {
        
    }
}
