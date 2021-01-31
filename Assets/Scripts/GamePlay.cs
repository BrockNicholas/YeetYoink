using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GamePlay : MonoBehaviour
{
    public GameObject P1Card;
    public GameObject MainCard;
    public GameObject P2Card;

    private Vector3 P1DeckCoord;
    private Vector3 P1PlayCoord;
    private Vector3 MainDeckCoord;
    private Vector3 MainPlayCoord;
    private Vector3 P2DeckCoord;
    private Vector3 P2PlayCoord;

    public TextMeshProUGUI P1DeckLabel;
    public TextMeshProUGUI P1PlayLabel;
    public TextMeshProUGUI MainPlayLabel;
    public TextMeshProUGUI P2DeckLabel;
    public TextMeshProUGUI P2PlayLabel;


    // Start is called before the first frame update
    void Start()
    {
        SetStartingPositions();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayARound(int P1Remaining, int P2Remaining)
    {

    }

    void MoveToStartingPositions()
    {

    }

    void SetStartingPositions()
    {
        P1DeckCoord = P1Card.transform.position;
        P1PlayCoord = Camera.main.WorldToScreenPoint(GameObject.Find("P1PlayCoord").transform.position);        
        MainDeckCoord = MainCard.transform.position;
        MainPlayCoord = GameObject.Find("GameManager").transform.position;
        P2DeckCoord = P2Card.transform.position;
        P2PlayCoord = GameObject.Find("P2PlayCoord").transform.position;

    }
}
