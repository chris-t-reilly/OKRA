using UnityEngine;

public class BlueprintController : MonoBehaviour
{
    WorldMapState state;

    [System.Serializable]
    public class MachinePrefabPairing
    {
        public string blueprintType;
        public GameObject prefab;
    }

    public MachinePrefabPairing[] prefabs;

    GameObject GetMachinePrefab(string blueprintType)
    {
        for (int i = 0; i < this.prefabs.Length; i++)
        {
            if (this.prefabs[i].blueprintType == blueprintType)
            {
                return this.prefabs[i].prefab;
            }
        }

        return this.prefabs[0].prefab;
    }

    public void AssignRoomState(WorldMapState state)
    {
        this.state = state;
        this.state.blueprints.OnAdd((uuid, blueprint) =>
        {
            Debug.Log("New blueprint with uuid " + uuid);

            GameObject blueprintGameObject = Instantiate(
                GetMachinePrefab(blueprint.type),
                new Vector3(blueprint.x, blueprint.y, blueprint.z),
                Quaternion.Euler(0f, blueprint.rotation * 90f, 0f)
            );

            blueprintGameObject.transform.SetParent(gameObject.transform);
            blueprintGameObject.name = uuid;
            blueprintGameObject.transform.position = new Vector3(blueprint.x, blueprint.y, blueprint.z);
            blueprintGameObject.AddComponent<Resource>();
        });

        this.state.blueprints.OnRemove((uuid, tree) =>
        {
            Debug.Log("Blueprint removed with uuid " + uuid);
            GameObject blueprintGameObject = transform.Find(uuid).gameObject;
            Destroy(blueprintGameObject);
        });
    }
}
