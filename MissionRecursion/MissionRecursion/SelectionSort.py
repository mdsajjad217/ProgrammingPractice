import sys


def selectionSortRecursive(arr, start, end, currentMaxIndex):
    if end < 0:
        return arr
    if start <= end:
        if arr[currentMaxIndex] <= arr[start]:
            currentMaxIndex = start
        return selectionSortRecursive(arr, start + 1, end, currentMaxIndex)
    else:
        arr[end], arr[currentMaxIndex] = arr[currentMaxIndex], arr[end]
        return selectionSortRecursive(arr, 0, end - 1, 0)


newArr = selectionSortRecursive([-2, 45, 0, 11, -9], 0, len([-2, 45, 0, 11, -9]) - 1, 0)
print(newArr)

newArr = selectionSortRecursive([4, 3, 2, 1], 0, len([4, 3, 2, 1]) - 1, 0)
print(newArr)
