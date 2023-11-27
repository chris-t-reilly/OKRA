using UnityEngine;

public class StructureController : MonoBehaviour
{
    WorldMapState state;
    public enum StructureType{
        WOOD_WALL,
        STONE_WALL,
        WOOD_FLOOR,
        WOOD_CORNER
    }

    [System.Serializable]
    public class StructurePrefabPairing
    {
        public StructureType machineType;
        public GameObject prefab;
    }

    public StructurePrefabPairing[] prefabs;

    GameObject GetStructurePrefab(string resourceType) {
        for (int i = 0; i < this.prefabs.Length; i++) {
            if (this.prefabs[i].machineType.ToString() == resourceType) {
                return this.prefabs[i].prefab;
            }
        }

        return this.prefabs[0].prefab;
    }

    public void AssignRoomState(WorldMapState state)
    {
        this.state = state;
        this.state.structures.OnAdd((uuid, structure) =>
        {
            Debug.Log("New structure with uuid " + uuid);

            GameObject structureGameObject = Instantiate(
                GetStructurePrefab(structure.type),
                new Vector3(structure.x, structure.y, structure.z),
                Quaternion.Euler(0f, structure.rotation * 90f, 0f)
            );

            structureGameObject.transform.SetParent(gameObject.transform);
            structureGameObject.name = uuid;
            structureGameObject.transform.position = new Vector3(structure.x, structure.y, structure.z);
            structureGameObject.AddComponent<Resource>();
        });
    }
}
