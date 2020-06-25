using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsColorController : MonoBehaviour
{
    private List<GameObject> buttons = new List<GameObject>();

    public void addColorButton(GameObject button)
    {
        buttons.Add(button);
    }

    public void selectButton(GameObject selectButton)
    {
        foreach (GameObject button in buttons)
        {
            distroySelectButton(button);
        }

        selectButton.transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
    }

    public void distroySelectButton(GameObject button)
    {
        button.transform.localScale = new Vector3(1.08f, 1.08f, 1.08f);
    }
}
