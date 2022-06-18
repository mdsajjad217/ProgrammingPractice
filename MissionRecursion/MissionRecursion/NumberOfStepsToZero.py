def numOfSteps(n, count):
    if n == 0:
        return count

    if n % 2 == 0:
        n = n // 2
    else:
        n = (n - 1)
    return numOfSteps(n, count + 1)


res = numOfSteps(8, 0)
print(res)
