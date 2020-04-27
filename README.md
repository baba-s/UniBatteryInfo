# Uni Battery Info

バッテリーの情報を管理するクラス

## 使用例

```cs
using UniBatteryInfo;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void OnGUI()
    {
        // バッテリーの残量（ 0.0 ～ 1.0 ）
        GUILayout.Label( BatteryInfo.GetLevel().ToString() );

        // バッテリーの状態
        // 
        // CHARGING     : 充電中
        // DISCHARGING  : 放電中
        // NOT_CHARGING : 充電していない
        // FULL         : 満タン
        GUILayout.Label( BatteryInfo.GetStatus().ToString() );
    }
}
```