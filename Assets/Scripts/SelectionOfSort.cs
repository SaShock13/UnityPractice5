using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SelectionOfSort : MonoBehaviour
{ 
    /// <summary>
  /// Метод обработки события OnClick кнопки "Сортировка выбором"
  /// </summary>
    public void OnSelectionSort()
    {
        int[] originalArray = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        Debug.LogFormat("Исходный массив {0}", "[" + string.Join(",", originalArray) + "]");

        int[] sortedArray = SelectionSort((int[])originalArray.Clone());
        Debug.LogFormat("Результат сортировки {0}", "[" + string.Join(",", sortedArray) + "]");

        int[] expectedArray = { 10, 13, 15, 22, 26, 34, 34, 68, 71, 81 };
        Debug.Log(sortedArray.SequenceEqual(expectedArray) ? "Результат верный" : "Результат не верный");
    }

    /// <summary>
    /// Метод сортируем массив методом выбора
    /// </summary>
    /// <param name="array">Исходный массив</param>
    /// <returns>Отсортированный массив</returns>
    private int[] SelectionSort(int[] array)
    {
        // Реализуйте сортировку массива методом выбора и верните результат

        int pastNum=0;
        for (int j = 0; j < array.Length-1; j++) // итерация начального индекса
        {

            for (int i = j+1; i < array.Length; i++)
            {

                if (array[i] < array[j]) // если текущее число меньше начального в этой итерации, меняем местами
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
