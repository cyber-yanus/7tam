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

    public void updateProgressBar()
    {
        progressBar.GetComponent<Image>().fillAmount += step;
    }

}
