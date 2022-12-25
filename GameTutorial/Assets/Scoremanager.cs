using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
public class Scoremanager : MonoBehaviour

{
    public static int score = 0;
    public TextMesh scoreText;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "laser")
        {

        }
    }
}
