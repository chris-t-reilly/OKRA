// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 2.0.20
// 

using Colyseus.Schema;
using Action = System.Action;

public partial class Path : Schema {
	[Type(0, "array", typeof(ArraySchema<PathPoint>))]
	public ArraySchema<PathPoint> points = new ArraySchema<PathPoint>();

	[Type(1, "number")]
	public float currentPathTime = default(float);

	[Type(2, "uint16")]
	public ushort currentPathIndex = default(ushort);

	[Type(3, "number")]
	public float distance = default(float);

	/*
	 * Support for individual property change callbacks below...
	 */

	protected event PropertyChangeHandler<ArraySchema<PathPoint>> __pointsChange;
	public Action OnPointsChange(PropertyChangeHandler<ArraySchema<PathPoint>> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.points));
		__pointsChange += __handler;
		if (__immediate && this.points != null) { __handler(this.points, null); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(points));
			__pointsChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<float> __currentPathTimeChange;
	public Action OnCurrentPathTimeChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.currentPathTime));
		__currentPathTimeChange += __handler;
		if (__immediate && this.currentPathTime != default(float)) { __handler(this.currentPathTime, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(currentPathTime));
			__currentPathTimeChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<ushort> __currentPathIndexChange;
	public Action OnCurrentPathIndexChange(PropertyChangeHandler<ushort> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.currentPathIndex));
		__currentPathIndexChange += __handler;
		if (__immediate && this.currentPathIndex != default(ushort)) { __handler(this.currentPathIndex, default(ushort)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(currentPathIndex));
			__currentPathIndexChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<float> __distanceChange;
	public Action OnDistanceChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.distance));
		__distanceChange += __handler;
		if (__immediate && this.distance != default(float)) { __handler(this.distance, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(distance));
			__distanceChange -= __handler;
		};
	}

	protected override void TriggerFieldChange(DataChange change) {
		switch (change.Field) {
			case nameof(points): __pointsChange?.Invoke((ArraySchema<PathPoint>) change.Value, (ArraySchema<PathPoint>) change.PreviousValue); break;
			case nameof(currentPathTime): __currentPathTimeChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(currentPathIndex): __currentPathIndexChange?.Invoke((ushort) change.Value, (ushort) change.PreviousValue); break;
			case nameof(distance): __distanceChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			default: break;
		}
	}
}

