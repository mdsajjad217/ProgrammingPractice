def printNumber(num, limit):
    if num > limit:
        return

    print(num)
    printNumber(num + 1, limit)


def printRev(num, limit):
    if num > limit:
        return

    printRev(num + 1, limit)
    print(num)


def printBoth(num, limit):
    if num > limit:
        return

    print(num)
    printBoth(num + 1, limit)
    print(num)


printNumber(1, 5)
printRev(1, 5)
printBoth(1, 5)
