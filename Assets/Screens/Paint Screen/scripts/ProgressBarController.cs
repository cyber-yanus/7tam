using UnityEngine;
using UnityEngine.UI;

public class ProgressBarController : MonoBehaviour
{
    public GameObject progressBar;
    public int progressBarId;

    public float step;

    private void Start()
    {
        
    }

    public void activateProgressBar()
    {
        progressBar.SetActive(true);

        transform.parent.GetComponent<ButtonsColorController>().currentProgressbar = this.gameObject;
    }

    public void distroyProgressBar()
    {
        progressBar.SetActive(false);
    }

    public void calculateStep(int colorsNumber)
    {
        step = 1f / (float)colorsNumber;
    }

    public float updateProgressBar()
    {
        return progressBar.GetComponent<Image>().fillAmount += step;
    }

    public float fin()
    {
        return progressBar.GetComponent<Image>().fillAmount = 1;
    }

    public void progressBarLoader(float count)
    {
        progressBar.GetComponent<Image>().fillAmount = count;
    }
}
