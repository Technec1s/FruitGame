using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D col)
    {
        if (!SameType(col.gameObject))
            return;

        else if(col.gameObject.tag == "1")
        {
            ScoreManager.instance.AddPoint1();
        }
        else if(col.gameObject.tag == "2")
        {
            ScoreManager.instance.AddPoints2();
        }
        else if (col.gameObject.tag == "3")
        {
            ScoreManager.instance.AddPoints3();
        }
        else if (col.gameObject.tag == "4")
        {
            ScoreManager.instance.AddPoints4();
        }
    }

    bool SameType(GameObject otherObject)
    {
        return gameObject.tag == otherObject.tag;
    }
}