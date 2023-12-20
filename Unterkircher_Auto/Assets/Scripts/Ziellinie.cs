using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ziellinie : MonoBehaviour
{
    public Text txtBesttime;

    float time = 0;
    float besttime = float.MaxValue;



    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (time < besttime)
        {
            besttime = time;
            txtBesttime.text = "Best Time: " + besttime.ToString("0.##") + "Sekunden";
        }

        time = 0;
    }
}