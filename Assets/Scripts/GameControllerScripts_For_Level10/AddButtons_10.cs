﻿using UnityEngine;

public class AddButtons_10 : MonoBehaviour
{
    [SerializeField]
    private Transform PuzzleField = null;

    [SerializeField]
    private GameObject btn = null;


    private void Awake()
    {
        for (int i = 0; i < 4; i++)
        {
            GameObject button = Instantiate(btn);
            button.name = "" + i;
            button.transform.SetParent(PuzzleField, false);
        }
    }



}// class 
