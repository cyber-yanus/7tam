using UnityEngine;
using UnityEngine.UI;

public class SetingsButtonListner : MonoBehaviour
{
    private Button button;

    private Animation animation;

    private bool isOpen = false;

    private void Awake()
    {
        isOpen = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        animation = GetComponent<Animation>();

        button.onClick.AddListener(execute);
    }

    private void execute()
    {
        if (isOpen)
        {
            animation.Play("close settings");
            isOpen = false;
        }
        else
        {
            animation.Play("opne settings");
            isOpen = true;
        }

        
    }
}
