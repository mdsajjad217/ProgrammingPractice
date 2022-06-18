def bubbleSort(arr):
    for i in range(len(arr)):
        for j in range(len(arr) - i - 1):
            if arr[j] > arr[j + 1]:
                arr[j], arr[j + 1] = arr[j + 1], arr[j]
    return arr


def bubbleSortRecursion(arr, start, end):
    if end < 0:
        return arr
    if arr[start] > arr[start + 1]:
        arr[start], arr[start + 1] = arr[start + 1], arr[start]
    if start < end:
        return bubbleSortRecursion(arr, start + 1, end)
    else:
        return bubbleSortRecursion(arr, 0, end - 1)


newArr = bubbleSort([-2, 45, 0, 11, -9])
print(newArr)

newArr = bubbleSortRecursion([-2, 45, 0, 11, -9], 0, len([-2, 45, 0, 11, -9]) - 2)
print(newArr)
