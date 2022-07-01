def nestedLoop(i, j, ic, jc):
    if i == ic:
        return

    print(str(i) + " - " + str(j))
    if j == jc:
        i += 1
        j = 0
    nestedLoop(i, j + 1, ic, jc)


nestedLoop(0, 0, 3, 4)
