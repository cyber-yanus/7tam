
using UnityEngine;

public class test_paint : MonoBehaviour
{
    public Sprite sprite;

    // Start is called before the first frame update
    void Start()
    {        
        sprite.FloodFillArea(110, 100, Color.red);
       // sprite.FloodFillBorder(400, 400, Color.red, Color.green);
       
        sprite.texture.Apply();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
