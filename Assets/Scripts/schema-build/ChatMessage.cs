// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 2.0.20
// 

using Colyseus.Schema;
using Action = System.Action;

public partial class ChatMessage : Schema {
	[Type(0, "string")]
	public string playerId = default(string);

	[Type(1, "string")]
	public string timestamp = default(string);

	[Type(2, "string")]
	public string message = default(string);

	/*
	 * Support for individual property change callbacks below...
	 */

	protected event PropertyChangeHandler<string> __playerIdChange;
	public Action OnPlayerIdChange(PropertyChangeHandler<string> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.playerId));
		__playerIdChange += __handler;
		if (__immediate && this.playerId != default(string)) { __handler(this.playerId, default(string)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(playerId));
			__playerIdChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<string> __timestampChange;
	public Action OnTimestampChange(PropertyChangeHandler<string> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.timestamp));
		__timestampChange += __handler;
		if (__immediate && this.timestamp != default(string)) { __handler(this.timestamp, default(string)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(timestamp));
			__timestampChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<string> __messageChange;
	public Action OnMessageChange(PropertyChangeHandler<string> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.message));
		__messageChange += __handler;
		if (__immediate && this.message != default(string)) { __handler(this.message, default(string)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(message));
			__messageChange -= __handler;
		};
	}

	protected override void TriggerFieldChange(DataChange change) {
		switch (change.Field) {
			case nameof(playerId): __playerIdChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(timestamp): __timestampChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(message): __messageChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			default: break;
		}
	}
}

