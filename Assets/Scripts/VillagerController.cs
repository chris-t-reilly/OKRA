using System;
using System.Collections;
using Colyseus;
using UnityEngine;

public class VillagerController : MonoBehaviour
{
    ColyseusRoom<WorldMapState> room;
    public GameObject villagerPrefab;

    public void AssignGameRoom(ColyseusRoom<WorldMapState> room) {
        
        this.room = room;
        this.room.State.villagers.OnAdd( (uuid, villager) => {
            Debug.Log("New villager with uuid " + uuid);
            GameObject villagerGameObject = Instantiate(villagerPrefab, new Vector3(villager.x, villager.y, villager.z), Quaternion.identity);
            villagerGameObject.transform.SetParent(gameObject.transform);
            villagerGameObject.transform.position = new Vector3(villager.x, villager.y, villager.z);
            Villager villagerComponent = villagerGameObject.GetComponent<Villager>();
            villagerComponent.SetVillagerState(villager);
            villagerGameObject.name = uuid;

            // villager.OnChange( () => {
            //     villagerGameObject.transform.position = new Vector3(villager.x, villager.y, villager.z);
                
            //     PathPoint lastPoint = villager.path.points[villager.path.currentPathIndex];
            //     PathPoint nextPoint = villager.path.points[villager.path.currentPathIndex + 1];
                
            //     villagerGameObject.transform.rotation = Quaternion.LookRotation(new Vector3(nextPoint.x, villager.y, nextPoint.z) - new Vector3(lastPoint.x, villager.y, lastPoint.z));
            // });
        });

        InvokeRepeating(nameof(UpdateVillagerPosition), 0.0f, 1f);
    }

    void UpdateVillagerPosition()
    {
        this.room.State.villagers.ForEach((uuid, villager) => {
            Transform villagerTransform = this.transform.Find(uuid);
            var package = new VillagerPositionEvent() { x = villagerTransform.localPosition.x,  y = villagerTransform.localPosition.y, z = villagerTransform.localPosition.z, uuid = villager.uuid};
            this.room.Send("villager-position", JsonUtility.ToJson(package));
        });
        
    }
}
