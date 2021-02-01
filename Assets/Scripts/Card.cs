using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    private bool IsPlaying = false;
    private Vector3 WhereToGo;
    private int DebugCount = 0;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x == WhereToGo.x)
        {
            IsPlaying = false;
        }

        if (IsPlaying)
        {
            transform.position = Vector3.MoveTowards(transform.position, WhereToGo, .1f);
            transform.Rotate(0, 0, 30);
            DebugCount++;
            Debug.Log(DebugCount);
        }
    }

    public void Play(Vector3 whereToGo)
    {
        WhereToGo = whereToGo;
        IsPlaying = true;
    }
}
