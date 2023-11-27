using System;
using System.Collections.Generic;
using System.Linq;
using Colyseus;
using Colyseus.Schema;
using Knife.HDRPOutline.Core;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BuildInterface : MonoBehaviour
{


    [System.Serializable]
    public class MachinePrefabPairing
    {
        public string blueprintType;
        public GameObject prefab;
    }

    public MachinePrefabPairing[] prefabs;
    private ColyseusRoom<WorldMapState> room;
    private int mouseCurrentX;
    private int mouseCurrentY;

    private int rotation = 0;
    private GameObject buildGhost;
    private string blueprintType;
    public void AssignGameRoom(ColyseusRoom<WorldMapState> room)
    {
        this.room = room;
    }

    public void SetBlueprintType(string type) {
        this.blueprintType = type;
        if (this.buildGhost) {
            Destroy(this.buildGhost);
        }
        this.buildGhost = Instantiate(this.GetBlueprintPrefab(this.blueprintType));
        this.buildGhost.transform.parent = this.transform;        
    }

     GameObject GetBlueprintPrefab(string blueprintType) {
        for (int i = 0; i < this.prefabs.Length; i++) {
            if (this.prefabs[i].blueprintType == blueprintType) {
                return this.prefabs[i].prefab;
            }
        }

        return this.prefabs[0].prefab;
    }

    public void Disable() {
        this.buildGhost.SetActive(false);
    }

    public void UpdateInterface()
    {
        if (EventSystem.current.IsPointerOverGameObject()) {
            this.buildGhost.SetActive(false);
            return;
        }
        if (Input.GetButtonDown("RotateLeft")) {
            this.rotation -= 1;
            if (this.rotation < 0) {
                this.rotation = 4 + this.rotation;
            }
        }

        if (Input.GetButtonDown("RotateRight")) {
            this.rotation += 1;
            this.rotation %= 4;
        }
        this.buildGhost.transform.rotation= Quaternion.Euler(0f, this.rotation * 90f, 0f);
        this.buildGhost.SetActive(true);
        float distance = 50f;
        int layer_mask = LayerMask.GetMask("FLOOR");
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, distance, layer_mask))
        {
            this.mouseCurrentX = Mathf.RoundToInt(hit.point.x);
            this.mouseCurrentY = Mathf.RoundToInt(hit.point.z);

            if (Input.GetButtonDown("Select/Build"))
            {
                var package = new BuildEvent() { x = this.mouseCurrentX,  y = 0, z = this.mouseCurrentY, type = this.blueprintType, rotation = this.rotation};
                this.room.Send("build-structure", JsonUtility.ToJson(package));
            }

            Vector3 floorPosition = new Vector3(MathF.Round(hit.point.x), 0f, MathF.Round(hit.point.z));
            this.buildGhost.transform.position = floorPosition;
        }
    }
}
