using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winscreen : MonoBehaviour
{

    private int PointsToWin;    // will be how many shapes are in the level
    private int currentPoints;
    public GameObject MyShapes;
    // Start is called before the first frame update
    void Start()
    {
        PointsToWin = MyShapes.transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {

        if (currentPoints > PointsToWin)
        {
            //WIN
            transform.GetChild(0).gameObject.SetActive(true);
        }



    }


    public void AddPoints()
    {
        currentPoints++;
    }












}
