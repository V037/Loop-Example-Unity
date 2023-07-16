using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//credits: V.037_

public class Test : MonoBehaviour
{
    [SerializeField]
    private bool useGoodLoop;

    [SerializeField]
    private int num;        //inspector variable debug
    [SerializeField]
    private int goodnum;    //inspector variable debug

    private void Update()
    {
        if(!useGoodLoop)                    //loop example n.1
        {
            for (int i = 0 ; i < 1; i++)    //"i" will get deleted every frame in Update() instance so... it will remain 0
            {                               //btw i < 5 it's the condition and the number of times you want to use for execute the loop
                num = num + 1;
                Debug.Log(i);               //If you need to change "i", don't do that ok? (^,^)
            }
        }
        else
        {
            loopVoid();                  //call loopVoid void
        }
    }

    private void loopVoid()        //loop example n.2
    {
        while(goodnum < 100)        //nice loop
        {
            goodnum++;
            Debug.Log(goodnum);     
        }
    }
}
