using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;

public class Loader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Advertisement.isSupported)
            Advertisement.Initialize("3682983", true);

        StartCoroutine("waitSimulator");
    }

    IEnumerator waitSimulator()
    {
        yield return new WaitForSeconds(1f);
        
        SceneLoader.AsyncLoadNewScene("Main");  
    }

}
