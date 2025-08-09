using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [Header("ゲームの基本情報")]
    [SerializeField] int currentIndex;
    [SerializeField] int[] moviesIndex;
    [SerializeField] float[] moviesScore;
    public int CurrentIndex { get; set; }
    public int[] MoviesIndex { get; set; }
    public float[] MoviesScore { get; set; }
    private void Awake()
    {
        CurrentIndex = CurrentIndex;
        MoviesIndex = moviesIndex;
        MoviesScore = moviesScore;
    }

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
