//　ライブラリの宣言　->　これからこの機能を使うよ
using UnityEngine;
using UnityEngine.InputSystem;

public class StageMove : MonoBehaviour
{
    // 変数、関数
    // 変数 -> int,string　値を格納するための箱
    // データ型(int,string,InputAction)　+　変数名(num,name)
    InputAction moveInput;

    // 関数 -> 処理をまとめて実行するための箱
    
    // 目的(抽象的課題)：ステージを回転させること
    // 手段(具体的課題)：ActionMapを使用してプレイヤーの入力を受け取る
    // 　　　　　　　　　受け取った入力をもとにステージのRotationを変更する
    
    //start ->シーンのロード時(ゲームの開始時)に自動的の実行される関数
    void Start()
    {
        moveInput = InputSystem.actions.FindAction("Move");
        
    }

    // Update -> 毎フレームごと(0.1～0/3f)刻みに自動で実行される関数
    void Update()
    {
        Debug.Log(moveInput.ReadValue<Vector2>());

        // A += B -> A = A + B
        //this.transform.localPosition -> このコードがアタッチされているオブジェクトの位置情報
        //moveInput.ReadValue<Vector2>() -> (X,Y,Z=0)

        Vector3 rotation;
        float threshold = 0.2f;

        //moveInput.ReadValue<Vector2>.x => X軸
        //moveInput.ReadValue<Vector2>.y => Y軸
        //Vector3 -> (X,Y,Z)

        rotation = new Vector3( moveInput.ReadValue<Vector2>().y*threshold, 0, moveInput.ReadValue<Vector2>().x*threshold * -1);
        this.transform.Rotate(rotation);
    }
}
