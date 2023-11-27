using System;
using Unity.AI.Navigation;
using UnityEngine;

public class WorldMapStateRenderer : MonoBehaviour
{
    public float speed = 10f;
    private bool _moving;
    public ServerConnection _serverConnection;
    private Vector2 _targetPosition;

    public Transform celestialBodies;

    public VillagerController villagerController;
    public ResourceController resourceController;
    public StockpileController stockpileController;
    public MachineController machineController;
    public BlueprintController blueprintController;
    public StructureController structureController;
    public NavMeshSurface navMesh;
    public ResourceNodeController resourceNodeController;
    public UI userInterface;

    public async void Start()
    {
        // Initialize game room.
        
        await _serverConnection.JoinOrCreateGame();
        this.villagerController.AssignGameRoom(_serverConnection.GameRoom);
        this.resourceController.AssignRoomState(_serverConnection.GameRoom.State);
        this.stockpileController.AssignRoomState(_serverConnection.GameRoom.State);
        this.machineController.AssignRoomState(_serverConnection.GameRoom.State);
        this.blueprintController.AssignRoomState(_serverConnection.GameRoom.State);
        this.structureController.AssignRoomState(_serverConnection.GameRoom.State);
        this.resourceNodeController.AssignRoomState(_serverConnection.GameRoom.State);
        this.userInterface.AssignGameRoom(_serverConnection.GameRoom);

        _serverConnection.GameRoom.State.OnTimeOfDayChange( (timeOfDay, previous) => {
            this.celestialBodies.transform.localRotation = Quaternion.Euler((timeOfDay / 24 * 360f) - 130f, 0f, 0f);
        });

        _serverConnection.GameRoom.State.structures.OnAdd((uuid, structure) => {
            CancelInvoke(nameof(UpdateNavMesh));
            Invoke(nameof(UpdateNavMesh), 1f);
        });

        _serverConnection.GameRoom.State.resourceNodes.OnAdd((uuid, resourceNode) => {
            CancelInvoke(nameof(UpdateNavMesh));
            Invoke(nameof(UpdateNavMesh), 1f);
        });

        _serverConnection.GameRoom.State.resources.OnAdd((uuid, resource) => {
            CancelInvoke(nameof(UpdateNavMesh));
            Invoke(nameof(UpdateNavMesh), 1f);
        });

        _serverConnection.GameRoom.State.structures.OnRemove((uuid, structure) => {
            CancelInvoke(nameof(UpdateNavMesh));
            Invoke(nameof(UpdateNavMesh), 1f);
        });

        _serverConnection.GameRoom.State.resourceNodes.OnRemove((uuid, resourceNode) => {
            CancelInvoke(nameof(UpdateNavMesh));
            Invoke(nameof(UpdateNavMesh), 1f);
        });

        _serverConnection.GameRoom.State.resources.OnRemove((uuid, resource) => {
            CancelInvoke(nameof(UpdateNavMesh));
            Invoke(nameof(UpdateNavMesh), 1f);
        });
    }
    public void UpdateNavMesh() {
        this.navMesh.UpdateNavMesh(this.navMesh.navMeshData);
    }
    private void Update()
    {
        /*
        if (Input.GetMouseButtonDown(0))
        {
            // Synchronize mouse click position with the Colyseus server.
            _serverConnection.PlayerPosition(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }

        if (_moving && (Vector2)transform.position != _targetPosition)
        {
            var step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, _targetPosition, step);
        }
        else
        {
            _moving = false;
        }
        */
    }
}
