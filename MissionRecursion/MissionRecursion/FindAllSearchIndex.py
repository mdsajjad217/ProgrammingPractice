def findAllSearchIndex(arr, target, index):
    output = []
    if index == len(arr):
        return output

    if arr[index] == target:
        output = [index]
    resFromNext = findAllSearchIndex(arr, target, index + 1)
    output = output + resFromNext
    return output

res = findAllSearchIndex([2,3,1,4,4,5], 4, 0)
print(res)