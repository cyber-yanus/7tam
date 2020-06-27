using UnityEngine;


[CreateAssetMenu(menuName = "Player/default player", fileName = "new player")]
public class PlayerScriptableObject : ScriptableObject
{
    [SerializeField]
    private Color currentColor;
    [SerializeField]
    private int currentColorId;

    [SerializeField]
    private int money;

    public bool minusMoney(int count)
    {
        if (money - count >= 0)
        {
            money -= count;
            return true;
        }

        return false;
    }

    public Color CurrentColor { get => currentColor; set => currentColor = value; }
    public int Money { get => money; set => money = value; }
    public int CurrentColorId { get => currentColorId; set => currentColorId = value; }
}
