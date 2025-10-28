using UnityEngine;

/// <summary>
/// 낚시로 잡을 수 있는 물고기들의 스프라이트 데이터를 담는 스크립터블 오브젝트입니다.
/// </summary>
[CreateAssetMenu(fileName = "New FishData", menuName = "Fishing/Fish Data", order = 1)]
public class FishData : ScriptableObject
{
    [Tooltip("이곳에 낚시로 잡을 수 있는 물고기 스프라이트들을 넣어주세요.")]
    public Sprite[] fishSprites;
}
