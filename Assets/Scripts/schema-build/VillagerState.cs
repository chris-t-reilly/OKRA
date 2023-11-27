// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 2.0.20
// 

using Colyseus.Schema;
using Action = System.Action;

public partial class VillagerState : Schema {
	[Type(0, "ref", typeof(ResourceState))]
	public ResourceState haulingResource = new ResourceState();

	[Type(1, "boolean")]
	public bool expired = default(bool);

	[Type(2, "boolean")]
	public bool taskInProgress = default(bool);

	[Type(3, "float32")]
	public float x = default(float);

	[Type(4, "float32")]
	public float y = default(float);

	[Type(5, "float32")]
	public float z = default(float);

	[Type(6, "number")]
	public float id = default(float);

	[Type(7, "string")]
	public string currentState = default(string);

	[Type(8, "string")]
	public string currentTask = default(string);

	[Type(9, "string")]
	public string name = default(string);

	[Type(10, "string")]
	public string owner = default(string);

	[Type(11, "string")]
	public string target = default(string);

	[Type(12, "string")]
	public string uuid = default(string);

	[Type(13, "array", typeof(ArraySchema<float>), "number")]
	public ArraySchema<float> destination = new ArraySchema<float>();

	[Type(14, "map", typeof(MapSchema<float>), "number")]
	public MapSchema<float> labor = new MapSchema<float>();

	[Type(15, "map", typeof(MapSchema<float>), "number")]
	public MapSchema<float> schedule = new MapSchema<float>();

	[Type(16, "map", typeof(MapSchema<float>), "number")]
	public MapSchema<float> needs = new MapSchema<float>();

	/*
	 * Support for individual property change callbacks below...
	 */

	protected event PropertyChangeHandler<ResourceState> __haulingResourceChange;
	public Action OnHaulingResourceChange(PropertyChangeHandler<ResourceState> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.haulingResource));
		__haulingResourceChange += __handler;
		if (__immediate && this.haulingResource != null) { __handler(this.haulingResource, null); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(haulingResource));
			__haulingResourceChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<bool> __expiredChange;
	public Action OnExpiredChange(PropertyChangeHandler<bool> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.expired));
		__expiredChange += __handler;
		if (__immediate && this.expired != default(bool)) { __handler(this.expired, default(bool)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(expired));
			__expiredChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<bool> __taskInProgressChange;
	public Action OnTaskInProgressChange(PropertyChangeHandler<bool> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.taskInProgress));
		__taskInProgressChange += __handler;
		if (__immediate && this.taskInProgress != default(bool)) { __handler(this.taskInProgress, default(bool)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(taskInProgress));
			__taskInProgressChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<float> __xChange;
	public Action OnXChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.x));
		__xChange += __handler;
		if (__immediate && this.x != default(float)) { __handler(this.x, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(x));
			__xChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<float> __yChange;
	public Action OnYChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.y));
		__yChange += __handler;
		if (__immediate && this.y != default(float)) { __handler(this.y, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(y));
			__yChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<float> __zChange;
	public Action OnZChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.z));
		__zChange += __handler;
		if (__immediate && this.z != default(float)) { __handler(this.z, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(z));
			__zChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<float> __idChange;
	public Action OnIdChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.id));
		__idChange += __handler;
		if (__immediate && this.id != default(float)) { __handler(this.id, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(id));
			__idChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<string> __currentStateChange;
	public Action OnCurrentStateChange(PropertyChangeHandler<string> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.currentState));
		__currentStateChange += __handler;
		if (__immediate && this.currentState != default(string)) { __handler(this.currentState, default(string)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(currentState));
			__currentStateChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<string> __currentTaskChange;
	public Action OnCurrentTaskChange(PropertyChangeHandler<string> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.currentTask));
		__currentTaskChange += __handler;
		if (__immediate && this.currentTask != default(string)) { __handler(this.currentTask, default(string)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(currentTask));
			__currentTaskChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<string> __nameChange;
	public Action OnNameChange(PropertyChangeHandler<string> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.name));
		__nameChange += __handler;
		if (__immediate && this.name != default(string)) { __handler(this.name, default(string)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(name));
			__nameChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<string> __ownerChange;
	public Action OnOwnerChange(PropertyChangeHandler<string> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.owner));
		__ownerChange += __handler;
		if (__immediate && this.owner != default(string)) { __handler(this.owner, default(string)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(owner));
			__ownerChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<string> __targetChange;
	public Action OnTargetChange(PropertyChangeHandler<string> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.target));
		__targetChange += __handler;
		if (__immediate && this.target != default(string)) { __handler(this.target, default(string)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(target));
			__targetChange -= __handler;
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

	protected event PropertyChangeHandler<ArraySchema<float>> __destinationChange;
	public Action OnDestinationChange(PropertyChangeHandler<ArraySchema<float>> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.destination));
		__destinationChange += __handler;
		if (__immediate && this.destination != null) { __handler(this.destination, null); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(destination));
			__destinationChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<MapSchema<float>> __laborChange;
	public Action OnLaborChange(PropertyChangeHandler<MapSchema<float>> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.labor));
		__laborChange += __handler;
		if (__immediate && this.labor != null) { __handler(this.labor, null); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(labor));
			__laborChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<MapSchema<float>> __scheduleChange;
	public Action OnScheduleChange(PropertyChangeHandler<MapSchema<float>> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.schedule));
		__scheduleChange += __handler;
		if (__immediate && this.schedule != null) { __handler(this.schedule, null); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(schedule));
			__scheduleChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<MapSchema<float>> __needsChange;
	public Action OnNeedsChange(PropertyChangeHandler<MapSchema<float>> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.needs));
		__needsChange += __handler;
		if (__immediate && this.needs != null) { __handler(this.needs, null); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(needs));
			__needsChange -= __handler;
		};
	}

	protected override void TriggerFieldChange(DataChange change) {
		switch (change.Field) {
			case nameof(haulingResource): __haulingResourceChange?.Invoke((ResourceState) change.Value, (ResourceState) change.PreviousValue); break;
			case nameof(expired): __expiredChange?.Invoke((bool) change.Value, (bool) change.PreviousValue); break;
			case nameof(taskInProgress): __taskInProgressChange?.Invoke((bool) change.Value, (bool) change.PreviousValue); break;
			case nameof(x): __xChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(y): __yChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(z): __zChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(id): __idChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(currentState): __currentStateChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(currentTask): __currentTaskChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(name): __nameChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(owner): __ownerChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(target): __targetChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(uuid): __uuidChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(destination): __destinationChange?.Invoke((ArraySchema<float>) change.Value, (ArraySchema<float>) change.PreviousValue); break;
			case nameof(labor): __laborChange?.Invoke((MapSchema<float>) change.Value, (MapSchema<float>) change.PreviousValue); break;
			case nameof(schedule): __scheduleChange?.Invoke((MapSchema<float>) change.Value, (MapSchema<float>) change.PreviousValue); break;
			case nameof(needs): __needsChange?.Invoke((MapSchema<float>) change.Value, (MapSchema<float>) change.PreviousValue); break;
			default: break;
		}
	}
}

