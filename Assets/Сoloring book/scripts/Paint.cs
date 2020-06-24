
using UnityEngine;

public class Paint : MonoBehaviour
{
    public Sprite sprite;

    // Start is called before the first frame update
    void Start()
    {        
        sprite.FloodFillArea(110, 100, Color.red); 
        sprite.texture.Apply();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
