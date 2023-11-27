using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class ResourceController : MonoBehaviour
{

    WorldMapState state;
    
    [System.Serializable]
    public class ResourcePrefabPairing {
       public string resourceType;
       public GameObject prefab;
   }



   public ResourcePrefabPairing[] prefabs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    GameObject GetResourcePrefab(string resourceType) {
        for (int i = 0; i < this.prefabs.Length; i++) {
            if (this.prefabs[i].resourceType == resourceType) {
                return this.prefabs[i].prefab;
            }
        }

        return this.prefabs[0].prefab;
    }

    

    public void AssignRoomState(WorldMapState state) {
        this.state = state;
        this.state.resources.OnAdd( (uuid, resource) => {
            Debug.Log("New resource with uuid " + uuid);
            GameObject resourceGameObject = Instantiate(
                GetResourcePrefab(resource.type),
                new Vector3(resource.x, resource.y, resource.z),
                Quaternion.Euler(0, Random.Range(-180f, 180f), 0f)
            );

            resourceGameObject.transform.SetParent(gameObject.transform);
            resourceGameObject.name = uuid;
            resourceGameObject.transform.position = new Vector3(resource.x, resource.y, resource.z);
            resourceGameObject.AddComponent<Resource>();
            Resource resourceComponent = resourceGameObject.GetComponent<Resource>();
            resourceComponent.SetResourceState(resource);
        });

        this.state.resources.OnRemove( (uuid, tree) => {
            Debug.Log("Resource removed with uuid " + uuid);
            GameObject treeGameObject = transform.Find(uuid).gameObject;
            Destroy(treeGameObject);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
