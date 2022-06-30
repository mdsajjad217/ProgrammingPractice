def permutations(arr: list[int], permStack: list[int], itemHash, permList: list[list[int]]):
    if(len(arr) == len(permStack)):
        permList.append(permStack.copy())
        return
    for i in range(0, len(arr)):
        if(itemHash[i] == 0):
            permStack.append(arr[i])
            itemHash[i] = 1
            permutations(arr, permStack, itemHash, permList)
            itemHash[i] = 0
            permStack.pop(len(permStack)-1)


finalResult = []
permutations([1, 2, 3], [], {0: 0, 1: 0, 2: 0}, finalResult)
print(finalResult)
