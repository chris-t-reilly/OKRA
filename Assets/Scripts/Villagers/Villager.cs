using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class Villager : MonoBehaviour
{
    private VillagerState villagerState;

    [ReadOnly]
    public string target;
    [ReadOnly]
    public int currentPathIndex;

    public GameObject axe;
    public GameObject hammer;

    public NavMeshAgent navMeshAgent;

    public void Start() {
        
    }

    public void SetVillagerState(VillagerState villagerState)
    {
        this.villagerState = villagerState;

        this.villagerState.OnChange(() =>
        {
            this.target = this.villagerState.target;
        });

        this.villagerState.OnDestinationChange((newDestination, oldDestination) => {
            this.navMeshAgent.destination = new Vector3(this.villagerState.destination[0], 0, this.villagerState.destination[1]);
        });

        this.villagerState.OnCurrentStateChange((newState, oldState) =>
        {
            this.axe.SetActive(false);
            this.hammer.SetActive(false);
            Animator animatorController = this.GetComponentInChildren<Animator>();
            if (newState == VILLAGER_STATE.ON_PATH)
            {
                animatorController.SetTrigger("StartWalking");
                
            }
            else if (newState == VILLAGER_STATE.HAULING) {
                animatorController.SetTrigger("StartHauling");
            }
            else if (newState == VILLAGER_STATE.FELLING_TREE)
            {
                GameObject target = GameObject.Find(this.villagerState.target);
                if (target)
                {
                    this.transform.LookAt(new Vector3(target.transform.position.x, this.transform.position.y, target.transform.position.z));
                }
                animatorController.SetTrigger("ChopWood");
                this.axe.SetActive(true);
            }
            else if (newState == VILLAGER_STATE.CONSTRUCTING)
            {
                animatorController.SetTrigger("Construct");
                this.hammer.SetActive(true);
            }
            else if (newState == VILLAGER_STATE.SLEEPING)
            {
                animatorController.SetTrigger("Sleep");
            }
            else if (newState == VILLAGER_STATE.GETTING_UP)
            {
                animatorController.SetTrigger("WakeUp");
            }
            else
            {
                animatorController.SetTrigger("ToIdle");
            }
        });
    }
}
