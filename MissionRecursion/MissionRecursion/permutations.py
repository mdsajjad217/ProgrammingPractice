#incomplete logic. need more changes
def permuationRecursive(numberList, permutationStack, isTakenMap, permutationList):
    if len(numberList) == len(permutationStack):
        permutationList.append(permutationStack)
        return

    for i in range(0, len(numberList)):
        if isTakenMap[i] == 0:
            permutationStack.append(numberList[i])
            isTakenMap[i] = 1
            permuationRecursive(
                numberList, permutationStack, isTakenMap, permutationList
            )
            numberList.pop(i)
            isTakenMap[i] = 0


permutationList = []
permutationStack = []
permuationRecursive([1, 2, 3], permutationStack, {0: 0, 1: 0, 2: 0}, permutationList)
print(permutationList)
