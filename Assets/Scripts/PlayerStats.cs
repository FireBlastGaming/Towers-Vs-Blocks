using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int Money;
    public int startMoney = 400;

    public static int Lives;
    public int startLives = 20;


    public static int waveNumber;

    void Start()
    {
        Money = startMoney;
        Lives = startLives;

        waveNumber = 0;
    }

}
