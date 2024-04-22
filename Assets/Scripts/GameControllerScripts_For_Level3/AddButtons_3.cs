﻿using UnityEngine;

public class AddButtons_3 : MonoBehaviour
{
    [SerializeField]
    private Transform PuzzleField= null;

    [SerializeField]
    private GameObject btn = null;


    private void Awake()
    {
        for(int i = 0; i < 10; i++)
        {
            GameObject button = Instantiate(btn);
            button.name = "" + i;
            button.transform.SetParent(PuzzleField, false);
        }
    }


} // class
