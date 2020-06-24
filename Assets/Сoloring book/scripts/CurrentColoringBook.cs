using UnityEngine;


[CreateAssetMenu(menuName = "Coloring book/current coloting book", fileName = "Current Coloring book")]
public class CurrentColoringBook : ScriptableObject
{
    [SerializeField]
    private ColoringBookData coloringBook;

    public ColoringBookData ColoringBook { get => coloringBook; set => coloringBook = value; }
}
