using UnityEngine;

/// <summary>
/// �j�U�޲z��
/// ���a���U��ԫ��s�}�l�ǰt��ԲզX
/// </summary>
public class LobbyManager : MonoBehaviour
{
    // GameObject �C������G�s�� Unity �������Ҧ�����
    //SerializeField �N�p�H�����ܦb�ݩʭ��O�W
    //Header ���D�A�b�ݩʭ��O�W��ܲ���r���D
    [SerializeField, Header ("�s�u���e��")]
    private GameObject goConnectView;

    //�p��ϫ��s�P�{�����q���y�{
    //1.���Ѥ��}����k Public Method
    //2.���s�b�I�� On Click ��]�w�I�s����k

    public void StartConnect()
    {
        print("�}�l�s�u...");

        //�C������.�Ұʳ]�w(���L��) - ture �ХܡAfalse ����
        goConnectView.SetActive(true);
    }
}
