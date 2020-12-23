using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]int max;
    [SerializeField]int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;
    void Start()
    {
        StartGame();
    }

    private void StartGame()
    {
        NextGuess();
        max = max + 1;
    }

    public void OnPressHigher()
    {
        min = guess+1;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess-1;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min,max);
        guessText.text = guess.ToString();
    }
}
