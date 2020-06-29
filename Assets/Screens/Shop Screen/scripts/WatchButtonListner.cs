using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class WatchButtonListner : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(execute);
    }

    private void execute()
    {
        if (Advertisement.IsReady())
            Advertisement.Show("video");
    }

}
