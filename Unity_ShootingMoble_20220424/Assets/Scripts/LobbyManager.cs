using UnityEngine;

/// <summary>
/// 大廳管理器
/// 玩家按下對戰按鈕開始匹配對戰組合
/// </summary>
public class LobbyManager : MonoBehaviour
{
    // GameObject 遊戲物件：存放 Unity 場景內所有物件
    //SerializeField 將私人欄位顯示在屬性面板上
    //Header 標題，在屬性面板上顯示粗體字標題
    [SerializeField, Header ("連線中畫面")]
    private GameObject goConnectView;

    //如何使按鈕與程式溝通的流程
    //1.提供公開的方法 Public Method
    //2.按鈕在點擊 On Click 後設定呼叫此方法

    public void StartConnect()
    {
        print("開始連線...");

        //遊戲物件.啟動設定(布林值) - ture 標示，false 隱藏
        goConnectView.SetActive(true);
    }
}
