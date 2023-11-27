using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nova;
using UnityEngine;

public class VillagerList : MonoBehaviour
{
    public ListView villagerListView = null;
    public WorldMapStateRenderer worldMap;
    private List<VillagerState> villagerList = new List<VillagerState>();

    private async void Start()
    {
        
        
        await worldMap._serverConnection.WaitForConnection();
        await Task.Delay(1000);
        // villagerList = new List<VillagerState>(worldMap._serverConnection.GameRoom.State.villagers.Values);
        //     AddVillager(villager);
        //     // villager.OnCurrentStateChange((newState, oldState) => {
        //     //     villagerList.Find( villagerSearch => villager.uuid == villagerSearch.uuid).currentState = newState;
        //     // });
        // });
        villagerListView.AddDataBinder<VillagerState, VillagerVisuals>(BindItem);
        // // worldMap._serverConnection.GameRoom.State.villagers.OnRemove((uuid, villager) => villagerList.Remove(villager));
        villagerListView.SetDataSource(worldMap._serverConnection.GameRoom.State.villagers.Values.Cast<List<VillagerState>>().ToList());
    }

    private void AddVillager(VillagerState villager) {
        villagerList.Add(villager);
    }

    private void BindItem(Data.OnBind<VillagerState> evt, VillagerVisuals target, int index) => target.Bind(evt.UserData);
}
