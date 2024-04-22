﻿using UnityEngine;

public class AddSantaButtons_1 : MonoBehaviour
{

    [SerializeField]
    private Transform PuzzleField = null;

    [SerializeField]
    private GameObject btn = null;


    private void Awake()
    {
        for(int i = 0; i < 4; i++)
        {
            GameObject button = Instantiate(btn);
            button.name = "" + i;
            button.transform.SetParent(PuzzleField, false);
        }
    }

}//Class
