using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SelectionOfSort : MonoBehaviour
{ 
    /// <summary>
  /// ����� ��������� ������� OnClick ������ "���������� �������"
  /// </summary>
    public void OnSelectionSort()
    {
        int[] originalArray = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        Debug.LogFormat("�������� ������ {0}", "[" + string.Join(",", originalArray) + "]");

        int[] sortedArray = SelectionSort((int[])originalArray.Clone());
        Debug.LogFormat("��������� ���������� {0}", "[" + string.Join(",", sortedArray) + "]");

        int[] expectedArray = { 10, 13, 15, 22, 26, 34, 34, 68, 71, 81 };
        Debug.Log(sortedArray.SequenceEqual(expectedArray) ? "��������� ������" : "��������� �� ������");
    }

    /// <summary>
    /// ����� ��������� ������ ������� ������
    /// </summary>
    /// <param name="array">�������� ������</param>
    /// <returns>��������������� ������</returns>
    private int[] SelectionSort(int[] array)
    {
        // ���������� ���������� ������� ������� ������ � ������� ���������

        int pastNum=0;
        for (int j = 0; j < array.Length-1; j++) // �������� ���������� �������
        {

            for (int i = j+1; i < array.Length; i++)
            {

                if (array[i] < array[j]) // ���� ������� ����� ������ ���������� � ���� ��������, ������ �������
                {
                    int tempNum = array[j];
                    array[j] = array[i];
                    array[i] = tempNum;
                }
            }
        }   

        return array;
    }
}
