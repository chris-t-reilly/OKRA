using System;
using System.Collections.Generic;
using System.Linq;
using Colyseus;
using Colyseus.Schema;
using Knife.HDRPOutline.Core;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

enum MODE {
    DEFAULT,
    CREATE_STOCKPILE,
    BUILD
}

public class UI : MonoBehaviour
{
    public GameObject p_stockpileSquareGhost;
    public StockpileDialog stockpileDialog;
    private GameObject g_stockpileSquareGhost;
    public Button m_stockpileCreateButton;
    public Button m_buildButton;
    public BuildInterface buildInterface;

    public TextMeshProUGUI time_tm;
    
    private MODE mode;

    private List<Transform> highlightedObjects = new List<Transform>();
    private int mouseStartX;
    private int mouseStartY;
    private int mouseCurrentX;
    private int mouseCurrentY;

    private bool b_startedDrawingStockpile = false;
    
    private List<GameObject> l_stockpileGhosts = new List<GameObject>();
    private ColyseusRoom<WorldMapState> room;

    void Start() {
        this.m_buildButton.onClick.AddListener(this.ToggleBuildMode);

        this.m_stockpileCreateButton.onClick.AddListener(this.ToggleStockpileCreatorMode);
        this.g_stockpileSquareGhost = Instantiate(p_stockpileSquareGhost, new Vector3(0f, 0f, 0f), Quaternion.identity);
        this.g_stockpileSquareGhost.transform.parent = this.transform;
        this.g_stockpileSquareGhost.SetActive(false);
    }

    public void AssignGameRoom(ColyseusRoom<WorldMapState> room) {
        this.room = room;
        this.buildInterface.AssignGameRoom(room);
        this.room.State.OnChange(() => this.time_tm.text = this.room.State.timeOfDay.ToString());
    }

    void ToggleStockpileCreatorMode() {
        if (this.mode != MODE.CREATE_STOCKPILE) {
            this.EnterMode(MODE.CREATE_STOCKPILE);
            this.g_stockpileSquareGhost.SetActive(true);
        } else {
            this.EnterMode(MODE.DEFAULT);
            this.g_stockpileSquareGhost.SetActive(false);
        }
    }

    void ToggleBuildMode() {
        if (this.mode != MODE.BUILD) {
            this.buildInterface.SetBlueprintType("WOOD_WALL");
            this.EnterMode(MODE.BUILD);
            
        } else {
            this.EnterMode(MODE.DEFAULT);
            this.buildInterface.Disable();
        }
        
    }

    void EnterMode(MODE mode) {
        Debug.Log("UI entered mode "+ mode.ToString());
        this.mode = mode;
    }

    void ClearHighlightedObjects() {
        this.highlightedObjects.ForEach( gameObjectTransform => {
            if (gameObjectTransform) {
                OutlineObject[] outlines = gameObjectTransform.GetComponentsInChildren<OutlineObject>();
                foreach (OutlineObject outline in outlines) {
                    outline.enabled = false;
                }
            }
        });
    }

    void HighlightObject(Transform gameObjectTransform) {
        this.ClearHighlightedObjects();
        OutlineObject[] outlines = gameObjectTransform.GetComponentsInChildren<OutlineObject>();
        foreach (OutlineObject outline in outlines) {
            outline.enabled = true;
        }
        this.highlightedObjects.Add(gameObjectTransform);
}

    void Update() {
        if (EventSystem.current.IsPointerOverGameObject()) {
            this.g_stockpileSquareGhost.SetActive(false);
            return;
        }
        if (this.mode == MODE.CREATE_STOCKPILE) {
            this.g_stockpileSquareGhost.SetActive(true);
            float distance = 50f;
            int layer_mask = LayerMask.GetMask("FLOOR");
            Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
            RaycastHit hit;
            if (Input.GetButtonDown("Select/Build")) {
                if (Physics.Raycast(ray, out hit, distance, layer_mask)) {
                    this.mouseStartX = Mathf.RoundToInt(hit.point.x);
                    this.mouseStartY = Mathf.RoundToInt(hit.point.z);
                }
                this.b_startedDrawingStockpile = true;
            }

            if (Input.GetButton("Select/Build")) {
                l_stockpileGhosts.ForEach( ghost => {
                    Destroy(ghost);
                });
                if (Physics.Raycast(ray, out hit, distance, layer_mask)) {
                    this.mouseCurrentX = Mathf.RoundToInt(hit.point.x);
                    this.mouseCurrentY = Mathf.RoundToInt(hit.point.z);
                }
                int startFromX = this.mouseStartX < this.mouseCurrentX ? this.mouseStartX : this.mouseCurrentX;
                int startFromY = this.mouseStartY < this.mouseCurrentY ? this.mouseStartY : this.mouseCurrentY;
                int endAtX = this.mouseStartX > this.mouseCurrentX ? this.mouseStartX : this.mouseCurrentX;
                int endAtY = this.mouseStartY > this.mouseCurrentY ? this.mouseStartY : this.mouseCurrentY;
                for (int y = startFromY; y <= endAtY; y++) {
                    for (int x = startFromX; x <= endAtX; x++) {
                        GameObject ghost = Instantiate(p_stockpileSquareGhost, new Vector3(x, 0f, y), Quaternion.identity);
                        l_stockpileGhosts.Add(ghost);
                        ghost.transform.parent = this.transform;
                    }
                }
            }

            if (Input.GetButtonUp("Select/Build")) {
                if (!this.b_startedDrawingStockpile) {
                    return;
                }
                if (Physics.Raycast(ray, out hit, distance, layer_mask)) {
                    this.mouseCurrentX = Mathf.RoundToInt(hit.point.x);
                    this.mouseCurrentY = Mathf.RoundToInt(hit.point.z);
                }

                int index = 0;
                ArraySchema<SquareState> squares = new ArraySchema<SquareState>();
                int startFromX = this.mouseStartX < this.mouseCurrentX ? this.mouseStartX : this.mouseCurrentX;
                int startFromY = this.mouseStartY < this.mouseCurrentY ? this.mouseStartY : this.mouseCurrentY;
                int endAtX = this.mouseStartX > this.mouseCurrentX ? this.mouseStartX : this.mouseCurrentX;
                int endAtY = this.mouseStartY > this.mouseCurrentY ? this.mouseStartY : this.mouseCurrentY;
                for (int y = startFromY; y <= endAtY; y++) {
                    for (int x = startFromX; x <= endAtX; x++) {
                        SquareState square = new SquareState{ x = x, z = y, y = 0 };
                        squares.items.Add(index, square);
                        index++;
                    }
                }
                l_stockpileGhosts.ForEach( ghost => Destroy(ghost));
                this.room.Send("create-stockpile", squares.items.Serialize());
            }

            if (Physics.Raycast(ray, out hit, distance, layer_mask)) {
                Vector3 floorPosition = new Vector3(MathF.Round(hit.point.x), 0f, MathF.Round(hit.point.z));
                this.g_stockpileSquareGhost.transform.position = floorPosition;
            }
        } else if(this.mode == MODE.BUILD) {
            this.buildInterface.UpdateInterface();
        } else if (this.mode == MODE.DEFAULT) {
            if (Input.GetButtonUp("Select/Build")) {
                
                Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 50f)) {
                    if (hit.transform) {
                        Debug.Log(hit.transform.name);
                        this.HighlightObject(hit.transform);
                        if (hit.transform.tag.Equals("StockpileSquare")) {
                           
                            string UUID = hit.transform.GetComponent<StockpileSquare>().stockpileUUID;
                            this.stockpileDialog.ShowStockpileState(this.room.State.stockpiles[UUID]);
                        }
                    }
                }
            }
        }
    }
}
