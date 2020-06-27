using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("waitSimulator");
    }

    IEnumerator waitSimulator()
    {
        yield return new WaitForSeconds(1.5f);
        SceneLoader.AsyncLoadNewScene("Main");
    }

}
