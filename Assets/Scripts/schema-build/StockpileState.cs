// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 2.0.20
// 

using Colyseus.Schema;
using Action = System.Action;

public partial class StockpileState : Schema {
	[Type(0, "array", typeof(ArraySchema<SquareState>))]
	public ArraySchema<SquareState> assignedSquares = new ArraySchema<SquareState>();

	[Type(1, "map", typeof(MapSchema<bool>), "boolean")]
	public MapSchema<bool> allowedResources = new MapSchema<bool>();

	[Type(2, "string")]
	public string uuid = default(string);

	/*
	 * Support for individual property change callbacks below...
	 */

	protected event PropertyChangeHandler<ArraySchema<SquareState>> __assignedSquaresChange;
	public Action OnAssignedSquaresChange(PropertyChangeHandler<ArraySchema<SquareState>> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.assignedSquares));
		__assignedSquaresChange += __handler;
		if (__immediate && this.assignedSquares != null) { __handler(this.assignedSquares, null); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(assignedSquares));
			__assignedSquaresChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<MapSchema<bool>> __allowedResourcesChange;
	public Action OnAllowedResourcesChange(PropertyChangeHandler<MapSchema<bool>> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.allowedResources));
		__allowedResourcesChange += __handler;
		if (__immediate && this.allowedResources != null) { __handler(this.allowedResources, null); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(allowedResources));
			__allowedResourcesChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<string> __uuidChange;
	public Action OnUuidChange(PropertyChangeHandler<string> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.uuid));
		__uuidChange += __handler;
		if (__immediate && this.uuid != default(string)) { __handler(this.uuid, default(string)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(uuid));
			__uuidChange -= __handler;
		};
	}

	protected override void TriggerFieldChange(DataChange change) {
		switch (change.Field) {
			case nameof(assignedSquares): __assignedSquaresChange?.Invoke((ArraySchema<SquareState>) change.Value, (ArraySchema<SquareState>) change.PreviousValue); break;
			case nameof(allowedResources): __allowedResourcesChange?.Invoke((MapSchema<bool>) change.Value, (MapSchema<bool>) change.PreviousValue); break;
			case nameof(uuid): __uuidChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			default: break;
		}
	}
}

