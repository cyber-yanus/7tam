using System.Collections.Generic;
using UnityEngine;



public class ButtonsColorController : MonoBehaviour
{
    private List<GameObject> buttons = new List<GameObject>();

    public ColoringBookData currentColoringBook;

    public GameObject currentProgressbar;

    private void Start()
    {
        loadProgressBar();
    }

    public void upProgressBar()
    {
        if (currentProgressbar != null)
        {
            int id = currentProgressbar.GetComponent<ProgressBarController>().progressBarId;

            currentColoringBook.SavedProgressBarCount[id] = currentProgressbar.GetComponent<ProgressBarController>().updateProgressBar();
        }
    }

    public void finishProgressBar()
    {
        if (currentProgressbar != null)
        {
            int id = currentProgressbar.GetComponent<ProgressBarController>().progressBarId;

            currentColoringBook.SavedProgressBarCount[id] = currentProgressbar.GetComponent<ProgressBarController>().fin();

        }
    }

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

        selectButton.transform.localScale = new Vector3(0.006f, 0.006f, 0.006f);
        selectButton.transform.parent.GetComponent<ProgressBarController>().activateProgressBar();

    }

    public void distroySelectButton(GameObject button)
    {
        button.transform.localScale = new Vector3(0.005f, 0.005f, 0.005f);
        button.transform.parent.GetComponent<ProgressBarController>().distroyProgressBar();

    }


    public void loadProgressBar()
    {
        for (int i = 0; i < buttons.Count; i++)
        {
            float currentCount = currentColoringBook.SavedProgressBarCount[i];

            buttons[i].transform.parent.GetComponent<ProgressBarController>().progressBarLoader(currentCount);
        }
    }
}
