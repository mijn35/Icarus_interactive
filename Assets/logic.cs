using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class logic : MonoBehaviour
{
    public int score;
    public Text txt;

    [ContextMenu("g")]
    public void addScore()
    {
        score++;
        txt.text = score.ToString();
    }
}
