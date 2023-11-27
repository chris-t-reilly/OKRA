// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 2.0.20
// 

using Colyseus.Schema;
using Action = System.Action;

public partial class MachineState : WorldEntityState {
	[Type(6, "string")]
	public string type = default(string);

	[Type(7, "string")]
	public string reservedBy = default(string);

	[Type(8, "number")]
	public float fuelQuantity = default(float);

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

	protected event PropertyChangeHandler<float> __fuelQuantityChange;
	public Action OnFuelQuantityChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.fuelQuantity));
		__fuelQuantityChange += __handler;
		if (__immediate && this.fuelQuantity != default(float)) { __handler(this.fuelQuantity, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(fuelQuantity));
			__fuelQuantityChange -= __handler;
		};
	}

	protected override void TriggerFieldChange(DataChange change) {
		switch (change.Field) {
			case nameof(type): __typeChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(reservedBy): __reservedByChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(fuelQuantity): __fuelQuantityChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			default: break;
		}
	}
}

