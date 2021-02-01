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

    public float Speed;

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
        GetDebugInputs(); // Debug
    }

    void GetDebugInputs()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            PlayCard(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            PlayCard(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            MainCard.GetComponent<Card>().Play(MainPlayCoord);
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            MoveToStartingPositions();
        }
    }

    void PlayCard(bool p1)
    {
        if (p1)
        {
            P1Card.GetComponent<Card>().Play(P1PlayCoord);
        }
        else
        {
            P2Card.GetComponent<Card>().Play(P2PlayCoord);
        }
        
    }

    void PlayARound(int P1Remaining, int P2Remaining)
    {

    }

    void MoveToStartingPositions()
    {
        P1Card.transform.position = P1DeckCoord;
        MainCard.transform.position = MainDeckCoord;
        P2Card.transform.position = P2DeckCoord;
    }

    void SetStartingPositions()
    {
        P1DeckCoord = P1Card.transform.position;
        P1PlayCoord = GameObject.Find("P1PlayCoord").transform.position;
        MainDeckCoord = MainCard.transform.position;
        MainPlayCoord = GameObject.Find("GameManager").transform.position;
        P2DeckCoord = P2Card.transform.position;
        P2PlayCoord = GameObject.Find("P2PlayCoord").transform.position;

    }
    
}
