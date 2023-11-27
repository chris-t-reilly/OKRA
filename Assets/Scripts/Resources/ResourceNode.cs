using UnityEngine;

public class ResourceNode : MonoBehaviour
{
    private ResourceNodeState resourceState;
    
    [ReadOnly]
    public string reservedBy;
    public string createdBy;

    public void SetResourceNodeState(ResourceNodeState resourceState) {
        this.resourceState = resourceState;
        
        this.resourceState.OnChange( () => {
                transform.position = new Vector3(this.resourceState.x, this.resourceState.y, this.resourceState.z);
                this.reservedBy = resourceState.reservedBy;
                this.createdBy = resourceState.createdBy;
        });
    }
}
