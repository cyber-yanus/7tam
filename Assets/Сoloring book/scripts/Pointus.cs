using UnityEngine;


[CreateAssetMenu(menuName = "Coloring book point/default coloting book points", fileName = "New points")]
public class Pointus : ScriptableObject
{
    [SerializeField]
    private StartPoints[] startPoints;

    public StartPoints[] StartPoints { get => startPoints; set => startPoints = value; }
}
