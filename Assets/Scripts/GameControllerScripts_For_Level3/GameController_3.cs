using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController_3 : MonoBehaviour
{
    [SerializeField]
    private Sprite bgImage = null;
    public Sprite[] puzzles = null;

    public List<Sprite> gamePuzzles = new List<Sprite>();
    public List<Button> btns = new List<Button>();

    private bool firstGuess, secoundGuess;

    private int countGuesses;
    private int countCorrectGuesses;
    private int gameGuesses;

    private int firstGuessIndex, secoundGuessIndex;
    private string firstGuessPuzzle, secoundGuessPuzzle;

    private void Awake()
    {
        puzzles = Resources.LoadAll<Sprite>("Sprites/Buttons_v3");
        AudioManager.instance.StopPlaying("MainMenu_Music");
        AudioManager.instance.StopPlaying("Street_Music");
    }

    private void Start()
    {
        AudioManager.instance.Play("Music");
        GetButtons();
        AddButtons();
        AddGamePuzzles();
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

    private void AddGamePuzzles()
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
        if (!firstGuess)
        {
            firstGuess = true;

            firstGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

            firstGuessPuzzle = gamePuzzles[firstGuessIndex].name;

            btns[firstGuessIndex].image.sprite = gamePuzzles[firstGuessIndex];


            AudioManager.instance.Play("Pick_Sound");

        }
        else if(!secoundGuess)

        {
            secoundGuess = true;

            secoundGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

            secoundGuessPuzzle = gamePuzzles[secoundGuessIndex].name;

            btns[secoundGuessIndex].image.sprite = gamePuzzles[secoundGuessIndex];

            // corroutine start here + countGuesses
            StartCoroutine(CheckThePuzzleIsMatched());

            countGuesses++;

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

            CheckTheGameIsFinished();

            AudioManager.instance.Play("Picked_Correct");

            ScoreTextScript.coinAmount += 20;
        } else

        {
            yield return new WaitForSeconds(.5f);

            btns[firstGuessIndex].image.sprite = bgImage;
            btns[secoundGuessIndex].image.sprite = bgImage;

            AudioManager.instance.Play("Picked_Wrong");
        }
        yield return new WaitForSeconds(.5f);
        firstGuess = secoundGuess = false;
    }


    private void CheckTheGameIsFinished()
    {
        countCorrectGuesses++;

        if(countCorrectGuesses == gameGuesses)
        {
          //  print("The game is finished");
          //  print("It took you " + countGuesses + "to many guess(es) to finsh the game");
            AudioManager.instance.StopPlaying("Music");
            SceneManager.LoadScene("MainMenu");
        }

    }

    private void Shuffle(List<Sprite> list)
    {
        for(int i = 0; i < list.Count; i++)
        {
            Sprite temp = list[i];
            int randomIndex = Random.Range(i, list.Count);
            list[i] = list[randomIndex];
            list[i] = temp;
        }
    }




} // class
