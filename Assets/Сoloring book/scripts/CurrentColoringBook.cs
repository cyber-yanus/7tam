﻿using UnityEngine;


[CreateAssetMenu(menuName = "Coloring book/current coloting book", fileName = "Current Coloring book")]
public class CurrentColoringBook : ScriptableObject
{
    [SerializeField]
    private static ColoringBookData coloringBook;

    [SerializeField]
    private StartPoints[] startPoints;
    

    public ColoringBookData ColoringBook { get => coloringBook; set => coloringBook = value; }
    public StartPoints[] StartPoints { get => startPoints; set => startPoints = value; }
}
