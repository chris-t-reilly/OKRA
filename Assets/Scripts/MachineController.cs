using UnityEngine;

public class MachineController : MonoBehaviour
{
    WorldMapState state;
    public enum MachineType{
        CAMP_STOVE
    }

    [System.Serializable]
    public class MachinePrefabPairing
    {
        public MachineType machineType;
        public GameObject prefab;
    }

    public MachinePrefabPairing[] prefabs;

    GameObject GetMachinePrefab(string resourceType) {
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
        this.state.machines.OnAdd((uuid, machine) =>
        {
            Debug.Log("New machine with uuid " + uuid);

            GameObject machineGameObject = Instantiate(
                GetMachinePrefab(machine.type),
                new Vector3(machine.x, machine.y, machine.z),
                Quaternion.Euler(0, Random.Range(-180f, 180f), 0f)
            );

            machineGameObject.transform.SetParent(gameObject.transform);
            machineGameObject.name = uuid;
            machineGameObject.transform.position = new Vector3(machine.x, machine.y, machine.z);
            machineGameObject.AddComponent<Resource>();
        });
    }
}
