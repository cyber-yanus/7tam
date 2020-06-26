﻿using UnityEngine;
using UnityEngine.UI;

public class ExitButtonListner : MonoBehaviour
{
    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(execute);
    }


    private void execute()
    {
        SceneLoader.loadNewScene("Main");
    }
}
