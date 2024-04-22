﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AddSantaGameController_5 : MonoBehaviour
{

    [SerializeField]
    private Sprite bgImage = null;
    public Sprite[] puzzles = null;

    public List<Button> btns = new List<Button>();
    public List<Sprite> gamePuzzles = new List<Sprite>(); 

    private bool firstGuess, secoundGuess;

    private int countGuessses;
    private int countCorrectGuesses;
    private int gameGuesses;

    private int firstGuessIndex, secoundGuessIndex;
    private string firstGuessPuzzle, secoundGuessPuzzle;


    private void Awake()
    {
        puzzles = Resources.LoadAll<Sprite>("Sprites/Buttons_v17");
        
        AudioManager.instance.StopPlaying("SantaMainMenu_Music");

    }

    private void Start()
    {
        AudioManager.instance.Play("Santa_Music");

        AudioManager.instance.StopPlaying("SantaStreet_Music");                
        GetButtons();
        AddButtons();
        AddGameButtons();
        Shuffle(gamePuzzles);
        gameGuesses = gamePuzzles.Count / 2;
    }

    private void GetButtons()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("PuzzleButton");

        for(int i = 0; i < objects.Length; i++)
        {
            btns.Add(objects[i].GetComponent<Button>());
            btns[i].image.sprite = bgImage;
        }
    }

    private void AddButtons()
    {
        foreach(Button btn in btns)
        {
            btn.onClick.AddListener(() => PickPuzzle());
        }
    }

    private void AddGameButtons()
    {
        int looper = btns.Count;
        int index = 0;

        for(int i = 0; i < looper; i++)
        {
            if(index == looper / 2)
            {
                index = 0;
            }
            gamePuzzles.Add(puzzles[index]);
            index++;
        }
    }

    public void PickPuzzle()
    {
        if(!firstGuess)
        {
            firstGuess = true;

            firstGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

            firstGuessPuzzle = gamePuzzles[firstGuessIndex].name;

            btns[firstGuessIndex].image.sprite = gamePuzzles[firstGuessIndex];

            AudioManager.instance.Play("Pick_Sound");

        } else if (!secoundGuess)
        {
            secoundGuess = true;

            secoundGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

            secoundGuessPuzzle = gamePuzzles[secoundGuessIndex].name;

            btns[secoundGuessIndex].image.sprite = gamePuzzles[secoundGuessIndex];
            // Corrotine start here + countGuess
            StartCoroutine(CheckThePuzzleIsMatched());
            countGuessses++;

            AudioManager.instance.Play("Pick_Sound");
        }
    }


    IEnumerator CheckThePuzzleIsMatched()
    {
        yield return new WaitForSeconds(1f);

        if(firstGuessPuzzle == secoundGuessPuzzle)
        {
            yield return new WaitForSeconds(.5f);

            btns[firstGuessIndex].interactable = false;
            btns[secoundGuessIndex].interactable = false;

            btns[firstGuessIndex].image.color = new Color(0, 0, 0, 0);
            btns[secoundGuessIndex].image.color = new Color(0, 0, 0, 0);

            // CheckTheGameIsFinished
            CheckTheGameIsFinished();

            AudioManager.instance.Play("Picked_Correct");

            ScoreTextScript.coinAmount += 30;
        } else
        {
            yield return new WaitForSeconds(.5f);

            btns[firstGuessIndex].image.sprite = bgImage;
            btns[secoundGuessIndex].image.sprite = bgImage;

            AudioManager.instance.Play("Picked_Correct");
        }
        yield return new WaitForSeconds(.5f);
        firstGuess = secoundGuess = false;
    }


    private void CheckTheGameIsFinished()
    {
        countCorrectGuesses++;

        if(countCorrectGuesses == gameGuesses)
        {
            // Print or Debug.Log for debug
             
            AudioManager.instance.StopPlaying("Santa_Music");
            SceneManager.LoadScene("SantaStreet_2");
        }
    }


    private void Shuffle(List<Sprite> list)
    {
        for(int i = 0; i < list.Count; i++)
        {
            Sprite temp = list[i];
            int RandomIndex = Random.Range(i, list.Count);
            list[i] = list[RandomIndex];
            list[i] = temp;
        }
    }



}//Class
