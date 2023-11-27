using System.Threading.Tasks;
using Colyseus;
using UnityEngine;

public class ServerConnection: MonoBehaviour
{
    private static ColyseusClient _client = null;
    private static ColyseusRoom<WorldMapState> _room = null;

    [SerializeField]
    private string hostAddress;
    public string HostAddress
    {
        get { return hostAddress; }
        set { hostAddress = value; }
    }

    [SerializeField]
    private string roomName;
    public string RoomName
    {
        get { return roomName; }
        set { roomName = value; }
    }

    public void Initialize()
    {
        _client = new ColyseusClient(hostAddress);
    }

    public async Task JoinOrCreateGame()
    {
        // Will create a new game room if there is no available game rooms in the server.
        _room = await Client.JoinOrCreate<WorldMapState>(roomName);
    }

    public async Task WaitForConnection() {
        while(_room == null) {
            await Task.Delay(1000);
        }
    }

    void OnApplicationQuit()
    {
        _room.Leave();
    }

    public ColyseusClient Client
    {
        get
        {
            // Initialize Colyseus client, if the client has not been initiated yet or input values from the Menu have been changed.
            if (_client == null || !_client.Endpoint.Uri.ToString().Contains(hostAddress))
            {
                Initialize();
            }
            return _client;
        }
    }

    public ColyseusRoom<WorldMapState> GameRoom
    {
        get
        {
            if (_room == null)
            {
                Debug.LogError("Room hasn't been initialized yet!");
            }
            return _room;
        }
    }
}
