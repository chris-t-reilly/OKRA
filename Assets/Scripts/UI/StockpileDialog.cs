using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StockpileDialog : MonoBehaviour
{
    public TextMeshProUGUI tm_stockpileDetails;
    public void ShowStockpileState(StockpileState state) {
        string content = "";
        state.assignedSquares.ForEach( square => {
            if (square.resource.quantity > 0)  {
                content += square.resource.type + ": (" + square.resource.quantity + ") \n";
            }            
        });
        this.tm_stockpileDetails.text = content;
    }
}
