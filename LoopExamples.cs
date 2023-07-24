using UnityEngine;

//credits: V.037_

public class LoopExamples : MonoBehaviour
{
    public bool useGoodLoop;  //variable

    public int num;        //variable. you can see variables in the inspector window when they're public

    public int goodnum;    //variable
    public int goodnum2;    //variable

    void Update()                    //you're calling this function for every frame your game renders
    {
    
        //BAD LOOP - EXAMPLE N.1
        if(!useGoodLoop)                    //loop example n.1 - if usefoodloop is false then we use the bad example
        {
            for (int i = 0 ; i < 1; i++)    //"i" will get deleted every frame in Update() instance so... it will remain 0
            {                               //btw i < 5 it's the condition and the number of times you want to use for execute the loop
                num = num + 1;                
                Debug.Log(num);               //printing the num in the console
                Debug.Log(i);            //If you need to change "i", don't do that ok? (^,^)
            }
        }
        else            
        {
            loopVoid();                  //call loopVoid void - if usefoodloop is false then we use the good example
        }

        
        //GOOD LOOP - EXAMPLE N.2
        if(useGoodLoop)
        {
            goodnum++;    //basically this add 1
        }
    }

    void loopVoid()
    {
    
        //GOOD LOOP - EXAMPLE N.3 
        while(goodnum2 < 100)        //nice loop
        {
            goodnum2++;            //adding 1 every time this function loopVoid() is called
            Debug.Log(goodnum);     
        }
    }
}
