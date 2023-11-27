// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 2.0.20
// 

using Colyseus.Schema;
using Action = System.Action;

public partial class WorldMapState : Schema {
	[Type(0, "number")]
	public float timeOfDay = default(float);

	[Type(1, "map", typeof(MapSchema<VillagerState>))]
	public MapSchema<VillagerState> villagers = new MapSchema<VillagerState>();

	[Type(2, "map", typeof(MapSchema<ResourceState>))]
	public MapSchema<ResourceState> resources = new MapSchema<ResourceState>();

	[Type(3, "map", typeof(MapSchema<MachineState>))]
	public MapSchema<MachineState> machines = new MapSchema<MachineState>();

	[Type(4, "map", typeof(MapSchema<StockpileState>))]
	public MapSchema<StockpileState> stockpiles = new MapSchema<StockpileState>();

	[Type(5, "map", typeof(MapSchema<BlueprintState>))]
	public MapSchema<BlueprintState> blueprints = new MapSchema<BlueprintState>();

	[Type(6, "map", typeof(MapSchema<StructureState>))]
	public MapSchema<StructureState> structures = new MapSchema<StructureState>();

	[Type(7, "map", typeof(MapSchema<ResourceNodeState>))]
	public MapSchema<ResourceNodeState> resourceNodes = new MapSchema<ResourceNodeState>();

	/*
	 * Support for individual property change callbacks below...
	 */

	protected event PropertyChangeHandler<float> __timeOfDayChange;
	public Action OnTimeOfDayChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.timeOfDay));
		__timeOfDayChange += __handler;
		if (__immediate && this.timeOfDay != default(float)) { __handler(this.timeOfDay, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(timeOfDay));
			__timeOfDayChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<MapSchema<VillagerState>> __villagersChange;
	public Action OnVillagersChange(PropertyChangeHandler<MapSchema<VillagerState>> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.villagers));
		__villagersChange += __handler;
		if (__immediate && this.villagers != null) { __handler(this.villagers, null); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(villagers));
			__villagersChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<MapSchema<ResourceState>> __resourcesChange;
	public Action OnResourcesChange(PropertyChangeHandler<MapSchema<ResourceState>> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.resources));
		__resourcesChange += __handler;
		if (__immediate && this.resources != null) { __handler(this.resources, null); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(resources));
			__resourcesChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<MapSchema<MachineState>> __machinesChange;
	public Action OnMachinesChange(PropertyChangeHandler<MapSchema<MachineState>> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.machines));
		__machinesChange += __handler;
		if (__immediate && this.machines != null) { __handler(this.machines, null); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(machines));
			__machinesChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<MapSchema<StockpileState>> __stockpilesChange;
	public Action OnStockpilesChange(PropertyChangeHandler<MapSchema<StockpileState>> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.stockpiles));
		__stockpilesChange += __handler;
		if (__immediate && this.stockpiles != null) { __handler(this.stockpiles, null); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(stockpiles));
			__stockpilesChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<MapSchema<BlueprintState>> __blueprintsChange;
	public Action OnBlueprintsChange(PropertyChangeHandler<MapSchema<BlueprintState>> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.blueprints));
		__blueprintsChange += __handler;
		if (__immediate && this.blueprints != null) { __handler(this.blueprints, null); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(blueprints));
			__blueprintsChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<MapSchema<StructureState>> __structuresChange;
	public Action OnStructuresChange(PropertyChangeHandler<MapSchema<StructureState>> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.structures));
		__structuresChange += __handler;
		if (__immediate && this.structures != null) { __handler(this.structures, null); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(structures));
			__structuresChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<MapSchema<ResourceNodeState>> __resourceNodesChange;
	public Action OnResourceNodesChange(PropertyChangeHandler<MapSchema<ResourceNodeState>> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.resourceNodes));
		__resourceNodesChange += __handler;
		if (__immediate && this.resourceNodes != null) { __handler(this.resourceNodes, null); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(resourceNodes));
			__resourceNodesChange -= __handler;
		};
	}

	protected override void TriggerFieldChange(DataChange change) {
		switch (change.Field) {
			case nameof(timeOfDay): __timeOfDayChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(villagers): __villagersChange?.Invoke((MapSchema<VillagerState>) change.Value, (MapSchema<VillagerState>) change.PreviousValue); break;
			case nameof(resources): __resourcesChange?.Invoke((MapSchema<ResourceState>) change.Value, (MapSchema<ResourceState>) change.PreviousValue); break;
			case nameof(machines): __machinesChange?.Invoke((MapSchema<MachineState>) change.Value, (MapSchema<MachineState>) change.PreviousValue); break;
			case nameof(stockpiles): __stockpilesChange?.Invoke((MapSchema<StockpileState>) change.Value, (MapSchema<StockpileState>) change.PreviousValue); break;
			case nameof(blueprints): __blueprintsChange?.Invoke((MapSchema<BlueprintState>) change.Value, (MapSchema<BlueprintState>) change.PreviousValue); break;
			case nameof(structures): __structuresChange?.Invoke((MapSchema<StructureState>) change.Value, (MapSchema<StructureState>) change.PreviousValue); break;
			case nameof(resourceNodes): __resourceNodesChange?.Invoke((MapSchema<ResourceNodeState>) change.Value, (MapSchema<ResourceNodeState>) change.PreviousValue); break;
			default: break;
		}
	}
}

