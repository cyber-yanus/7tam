﻿using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(menuName = "Coloring book/default coloting book", fileName ="New Coloring book")]
public class ColoringBookData : ScriptableObject
{

    [SerializeField]
    private Sprite coloringBookSprite;

    [SerializeField]
    private Sprite textColoringBook;

    [SerializeField]
    private Sprite example;

    [SerializeField]
    private Pointus pointus;

    [SerializeField]
    private List<Color> colors;

    [SerializeField]
    private List<int> colorsCount;
    
    [SerializeField]
    private List<float> savedProgressBarCount;


    public List<float> SavedProgressBarCount { get => savedProgressBarCount; set => savedProgressBarCount = value; }
    public Sprite TextColoringBook { get => textColoringBook; set => textColoringBook = value; }
    public Sprite ColoringBookSprite { get => coloringBookSprite; set => coloringBookSprite = value; }
    public List<int> ColorsCount { get => colorsCount; set => colorsCount = value; }
    public List<Color> Colors { get => colors; set => colors = value; }
    public Sprite Example { get => example; set => example = value; }
    public Pointus Pointus { get => pointus; set => pointus = value; }
}
