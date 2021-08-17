﻿namespace Majorsoft.Blazor.Components.Notifications
{
	/// <summary>
	/// A string representing the current permission to display notifications.
	/// </summary>
	public enum HtmlNotificationPermissionTypes
	{
		/// <summary>
		/// The user choice is unknown and therefore the browser will act as if the value were denied.
		/// </summary>
		Default,
		/// <summary>
		/// The user refuses to have notifications displayed.
		/// </summary>
		Denied,
		/// <summary>
		/// The user accepts having notifications displayed.
		/// </summary>
		Granted
	}
}