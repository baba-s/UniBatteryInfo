using UnityEngine;

namespace UniBatteryInfo
{
	/// <summary>
	/// バッテリーの状態
	/// </summary>
	public enum BatteryStatus
	{
		/// <summary>
		/// 不明
		/// </summary>
		UNKNOWN = 0,

		/// <summary>
		/// 充電中
		/// </summary>
		CHARGING = 1,

		/// <summary>
		/// 放電中
		/// </summary>
		DISCHARGING = 2,

		/// <summary>
		/// 充電していない
		/// </summary>
		NOT_CHARGING = 3,

		/// <summary>
		/// 満タン
		/// </summary>
		FULL = 4
	}

	/// <summary>
	/// バッテリーの情報を管理するクラス
	/// </summary>
	public static class BatteryInfo
	{
		/// <summary>
		/// バッテリーの残量（ 0.0 ～ 1.0 ）を返します
		/// </summary>
		public static float GetLevel()
		{
			return SystemInfo.batteryLevel;
		}

		/// <summary>
		/// バッテリーの状態を返します
		/// </summary>
		public static BatteryStatus GetStatus()
		{
			return ( BatteryStatus ) SystemInfo.batteryStatus;
		}
	}
}