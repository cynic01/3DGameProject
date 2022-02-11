using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WallScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<TMPro.TextMeshPro>().text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<TMPro.TextMeshPro>().text = ScoreManager.singleton.GetCurScore().ToString();
    }
}
