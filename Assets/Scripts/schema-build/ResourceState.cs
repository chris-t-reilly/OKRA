// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 2.0.20
// 

using Colyseus.Schema;
using Action = System.Action;

public partial class ResourceState : Schema {
	[Type(0, "number")]
	public float x = default(float);

	[Type(1, "number")]
	public float y = default(float);

	[Type(2, "number")]
	public float z = default(float);

	[Type(3, "string")]
	public string type = default(string);

	[Type(4, "string")]
	public string uuid = default(string);

	[Type(5, "string")]
	public string reservedBy = default(string);

	[Type(6, "number")]
	public float quantity = default(float);

	[Type(7, "boolean")]
	public bool obstruction = default(bool);

	[Type(8, "boolean")]
	public bool inStockpile = default(bool);

	[Type(9, "boolean")]
	public bool beingHauled = default(bool);

	[Type(10, "string")]
	public string createdBy = default(string);

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

	protected event PropertyChangeHandler<float> __quantityChange;
	public Action OnQuantityChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.quantity));
		__quantityChange += __handler;
		if (__immediate && this.quantity != default(float)) { __handler(this.quantity, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(quantity));
			__quantityChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<bool> __obstructionChange;
	public Action OnObstructionChange(PropertyChangeHandler<bool> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.obstruction));
		__obstructionChange += __handler;
		if (__immediate && this.obstruction != default(bool)) { __handler(this.obstruction, default(bool)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(obstruction));
			__obstructionChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<bool> __inStockpileChange;
	public Action OnInStockpileChange(PropertyChangeHandler<bool> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.inStockpile));
		__inStockpileChange += __handler;
		if (__immediate && this.inStockpile != default(bool)) { __handler(this.inStockpile, default(bool)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(inStockpile));
			__inStockpileChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<bool> __beingHauledChange;
	public Action OnBeingHauledChange(PropertyChangeHandler<bool> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.beingHauled));
		__beingHauledChange += __handler;
		if (__immediate && this.beingHauled != default(bool)) { __handler(this.beingHauled, default(bool)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(beingHauled));
			__beingHauledChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<string> __createdByChange;
	public Action OnCreatedByChange(PropertyChangeHandler<string> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.createdBy));
		__createdByChange += __handler;
		if (__immediate && this.createdBy != default(string)) { __handler(this.createdBy, default(string)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(createdBy));
			__createdByChange -= __handler;
		};
	}

	protected override void TriggerFieldChange(DataChange change) {
		switch (change.Field) {
			case nameof(x): __xChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(y): __yChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(z): __zChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(type): __typeChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(uuid): __uuidChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(reservedBy): __reservedByChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(quantity): __quantityChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(obstruction): __obstructionChange?.Invoke((bool) change.Value, (bool) change.PreviousValue); break;
			case nameof(inStockpile): __inStockpileChange?.Invoke((bool) change.Value, (bool) change.PreviousValue); break;
			case nameof(beingHauled): __beingHauledChange?.Invoke((bool) change.Value, (bool) change.PreviousValue); break;
			case nameof(createdBy): __createdByChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			default: break;
		}
	}
}

