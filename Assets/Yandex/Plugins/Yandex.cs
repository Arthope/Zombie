using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class Yandex : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void RateGame();

    [DllImport("__Internal")]
    private static extern void GetToLeaderBoard();



    public void RateGameButton()
    {
        RateGame();
    }

    public void GetLiderbord()
    {
        GetToLeaderBoard();
    }
}
