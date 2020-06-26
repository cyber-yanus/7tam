using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrainButtonListner : MonoBehaviour
{
    private Button button;
    public GameObject trainGameObject;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(execute);
    }


    private void execute()
    {
        trainGameObject.SetActive(true);
    }


}
