// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 2.0.20
// 

using Colyseus.Schema;
using Action = System.Action;

public partial class BlueprintState : WorldEntityState {
	[Type(6, "string")]
	public string type = default(string);

	[Type(7, "number")]
	public float completed = default(float);

	[Type(8, "string")]
	public string reservedBy = default(string);

	[Type(9, "map", typeof(MapSchema<float>), "number")]
	public MapSchema<float> resourcesRequired = new MapSchema<float>();

	[Type(10, "map", typeof(MapSchema<float>), "number")]
	public MapSchema<float> resourcesAcquired = new MapSchema<float>();

	/*
	 * Support for individual property change callbacks below...
	 */

	protected event PropertyChangeHandler<string> __typeChange;
	public Action OnTypeChange(PropertyChangeHandler<string> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.type));
		__typeChange += __handler;
		if (__immediate && this.type != default(string)) { __handler(this.type, default(string)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(type));
			__typeChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<float> __completedChange;
	public Action OnCompletedChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.completed));
		__completedChange += __handler;
		if (__immediate && this.completed != default(float)) { __handler(this.completed, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(completed));
			__completedChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<string> __reservedByChange;
	public Action OnReservedByChange(PropertyChangeHandler<string> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.reservedBy));
		__reservedByChange += __handler;
		if (__immediate && this.reservedBy != default(string)) { __handler(this.reservedBy, default(string)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(reservedBy));
			__reservedByChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<MapSchema<float>> __resourcesRequiredChange;
	public Action OnResourcesRequiredChange(PropertyChangeHandler<MapSchema<float>> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.resourcesRequired));
		__resourcesRequiredChange += __handler;
		if (__immediate && this.resourcesRequired != null) { __handler(this.resourcesRequired, null); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(resourcesRequired));
			__resourcesRequiredChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<MapSchema<float>> __resourcesAcquiredChange;
	public Action OnResourcesAcquiredChange(PropertyChangeHandler<MapSchema<float>> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.resourcesAcquired));
		__resourcesAcquiredChange += __handler;
		if (__immediate && this.resourcesAcquired != null) { __handler(this.resourcesAcquired, null); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(resourcesAcquired));
			__resourcesAcquiredChange -= __handler;
		};
	}

	protected override void TriggerFieldChange(DataChange change) {
		switch (change.Field) {
			case nameof(type): __typeChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(completed): __completedChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(reservedBy): __reservedByChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(resourcesRequired): __resourcesRequiredChange?.Invoke((MapSchema<float>) change.Value, (MapSchema<float>) change.PreviousValue); break;
			case nameof(resourcesAcquired): __resourcesAcquiredChange?.Invoke((MapSchema<float>) change.Value, (MapSchema<float>) change.PreviousValue); break;
			default: break;
		}
	}
}

