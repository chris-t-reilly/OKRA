using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StockpileSquare : MonoBehaviour
{
 private SquareState squareState;
    
    public string stockpileUUID;

    public void SetStockpileSquareState(SquareState squareState) {
        this.squareState = squareState;
    }
}