using Nova;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEngine;

public class VillagerVisuals : ItemVisuals
{
    public GameObject ContentRoot;
    public TextBlock Name;
    public TextBlock CurrentState;

    public void Bind(VillagerState data)
    {
            Name.Text = data.uuid;
            CurrentState.Text = data.currentState;
    }
}
