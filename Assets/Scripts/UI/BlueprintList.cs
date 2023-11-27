using System;
using System.Collections;
using System.Collections.Generic;
using Nova;
using UnityEngine;

public class BlueprintList : MonoBehaviour
{
    public SO_Menu_Buildable BuildableItems = null;
    public ListView blueprintList = null;
    private List<BuildableDescription> buildableItems = null;

    private void Start()
    {
        buildableItems = BuildableItems.buildables;
        blueprintList.AddDataBinder<BuildableDescription, BlueprintVisuals>(BindItem);
        blueprintList.SetDataSource(buildableItems);
    }

    private void BindItem(Data.OnBind<BuildableDescription> evt, BlueprintVisuals target, int index) => target.Bind(evt.UserData);
}
