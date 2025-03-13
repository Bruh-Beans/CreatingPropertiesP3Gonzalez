using UnityEngine;
using System.Collections;

public class Orc : Enemy1
{
    //This hides the Enemy version.
    new public void Yell()
    {
        Debug.Log("Orc version of the Yell() method");
    }
}