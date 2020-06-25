using UnityEngine;


[CreateAssetMenu(menuName = "Player/default player", fileName = "new player")]
public class PlayerScriptableObject : ScriptableObject
{
    [SerializeField]
    private Color currentColor;

    public Color CurrentColor { get => currentColor; set => currentColor = value; }
}
