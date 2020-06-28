using UnityEngine;
using UnityEngine.UI;

public class NextButtonListner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button button = GetComponent<Button>();

        button.onClick.AddListener(execute);
    }

    private void execute()
    { 
        
    }
}
