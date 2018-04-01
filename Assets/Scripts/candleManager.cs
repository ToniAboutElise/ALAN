using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candleManager : MonoBehaviour {

    public GameObject[] candles;
    public bool candlesDone;
    int candlesCount;

    void Start()
    {
        candlesCount = 0;
    }

    void Update()
    {
        for (int i = 0; i < candles.Length; i++)
        {
            if (candles[i].GetComponent<candle>().isOn == false)
            {
                candlesDone = false;
                candlesCount = 0;
            }
            else
            {
                candlesCount++;
            }

            if (candlesCount == candles.Length)
            {
                candlesDone = true;
            }
        }
    }

}
