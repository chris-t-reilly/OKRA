// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 2.0.20
// 

using Colyseus.Schema;
using Action = System.Action;

public partial class SquareState : Schema {
	[Type(0, "number")]
	public float x = default(float);

	[Type(1, "number")]
	public float y = default(float);

	[Type(2, "number")]
	public float z = default(float);

	[Type(3, "ref", typeof(ResourceState))]
	public ResourceState resource = new ResourceState();

	[Type(4, "string")]
	public string reservedBy = default(string);

	[Type(5, "string")]
	public string uuid = default(string);

	/*
	 * Support for individual property change callbacks below...
	 */

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

	protected event PropertyChangeHandler<ResourceState> __resourceChange;
	public Action OnResourceChange(PropertyChangeHandler<ResourceState> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.resource));
		__resourceChange += __handler;
		if (__immediate && this.resource != null) { __handler(this.resource, null); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(resource));
			__resourceChange -= __handler;
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
			case nameof(x): __xChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(y): __yChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(z): __zChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(resource): __resourceChange?.Invoke((ResourceState) change.Value, (ResourceState) change.PreviousValue); break;
			case nameof(reservedBy): __reservedByChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(uuid): __uuidChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			default: break;
		}
	}
}

