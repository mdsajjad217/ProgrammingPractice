def subsetsRecursive(subresult, rest, subsetList):
    if(rest == ""):
        subsetList.append(subresult)
        return

    subsetsRecursive(subresult + rest[0], rest[1:], subsetList)
    subsetsRecursive(subresult, rest[1:], subsetList)


def findSubsets(str):
    subsetList = []
    subsetsRecursive("", str, subsetList)
    return subsetList


res = findSubsets("abc")
print(res)
