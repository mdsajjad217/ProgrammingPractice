def mergeTwoArray(arr1, arr2):
    res = []
    i = 0
    j = 0
    while i < len(arr1) and j < len(arr2):
        if arr1[i] < arr2[j]:
            res.append(arr1[i])
            i += 1
        else:
            res.append(arr2[j])
            j += 1
    
    while(i < len(arr1)):
        res.append(arr1[i])
        i+=1
    
    while(j < len(arr2)):
        res.append(arr2[j])
        j+=1

    return res

#res = mergeTwoArray([3,4,8],[5,6,12])
#print(res)



def mergeSortInPlace(arr,start,end):
    mid = (end-start+1)//2
    if mid==1:
        return []

    
    left = mergeSortInPlace(arr,start, mid)
    right = mergeSortInPlace(arr,mid+1, end)
    return mergeTwoArray(left, right)

res = mergeSortInPlace([8,3,4,12,5,6],0,len([8,3,4,12,5,6]))
print(res)