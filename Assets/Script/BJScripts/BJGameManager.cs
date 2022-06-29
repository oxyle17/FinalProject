using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BJGameManager : MonoBehaviour
{

    public static BJGameManager instance;

    public AudioSource cardShuffle;
    public AudioSource cardDealSound;


    public Button dealButton;
    public Button hitButton;
    public Button standButton;
    private int standClicks = 0;

    public BJPlayerScript playerScript;
    public BJPlayerScript dealerScript;

    public Text scoreText;
    public Text winstext;
    public Text lossesText;
    public Text dealerScoreText;

    public float wins = 0;
    public float losses = 0;

    public Text standText;

    public GameObject hideCard;

    public GameObject mainCamera;
    public GameObject BJCamera;
    public GameObject BJCanvas;
    public GameObject BJNPC;

    public bool endOfGame;
    

    void Start()
    {
        instance = this;

        dealButton.onClick.AddListener(() => DealClicked());
        hitButton.onClick.AddListener(() => HitClicked());
        standButton.onClick.AddListener(() => StandClicked());

        mainCamera.SetActive(true);
        BJCamera.SetActive(false);
        BJCanvas.SetActive(false);
    }
    private void Update()
    {

    }

    private void DealClicked()
    {

        cardShuffle.Play();

        playerScript.ResetHand();
        dealerScript.ResetHand();

        dealerScoreText.gameObject.SetActive(false);
        GameObject.Find("Deck").GetComponent<DeckScript>().Shuffle();
        playerScript.StartHand();
        dealerScript.StartHand();

        scoreText.text = "Hand:" + playerScript.handValue.ToString();
        dealerScoreText.text = "Hand:" + dealerScript.handValue.ToString();

        hideCard.GetComponent<Renderer>().enabled = true;

        dealButton.gameObject.SetActive(false);
        hitButton.gameObject.SetActive(true);
        standButton.gameObject.SetActive(true);
        standText.text = "Stand";
    }

    private void HitClicked()
    {
        cardDealSound.Play();

        if (playerScript.cardIndex <= 10)
        {
            playerScript.GetCard();
            scoreText.text = "Hand" + playerScript.handValue.ToString();
            if (playerScript.handValue > 20) RoundOver();  
        }

       
    }


    private void StandClicked()
    {
        standClicks++;
        if (standClicks > 1) RoundOver();
        HitDealer();
        standText.text = "Call";
    }

    private void HitDealer()
    {
        while (dealerScript.handValue < 16 && dealerScript.cardIndex < 10)
        {
            cardDealSound.Play();

            dealerScript.GetCard();
            dealerScoreText.text = "Dealer Hand:" + dealerScript.handValue.ToString();
            if (dealerScript.handValue > 20) RoundOver();
        }
    }

    void RoundOver()
    {
        bool playerBust = playerScript.handValue > 21;
        bool dealerBust = dealerScript.handValue > 21;
        bool player21 = playerScript.handValue == 21;
        bool dealer21 = dealerScript.handValue == 21;

        if (standClicks < 2 && !playerBust && !dealerBust && !player21 && dealer21) return;
        bool roundOver = true;
        if (playerBust && dealerBust)
        {

        }
        else if (playerBust || !dealerBust && dealerScript.handValue > playerScript.handValue)
        {

            losses++;
            lossesText.text = "Losses:" + losses;
        }
        else if (dealerBust || !playerBust && playerScript.handValue > dealerScript.handValue)
        {
            wins++;
            winstext.text = "Wins:" + wins;
        }
        else if (playerScript.handValue == dealerScript.handValue)
        {

        }
        else
        {
            roundOver = false;
        }
        if (roundOver)
        {
            cardDealSound.Play();

            hitButton.gameObject.SetActive(false);
            standButton.gameObject.SetActive(false);
            dealButton.gameObject.SetActive(true);
            dealerScoreText.gameObject.SetActive(true);
            hideCard.GetComponent<Renderer>().enabled = false;
            standClicks = 0;
        }
        if (wins >= 5 || losses >= 5)
        {
            endOfGame = true;


            Invoke(nameof(wait), 2);
        }


       

    }

 void wait()
        {

        BJNPC.GetComponent<BlackJackStarter>().BlackJackEnd();

    }


}
