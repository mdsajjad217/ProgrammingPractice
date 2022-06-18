def drawPiramidTriangle(row):
    for x in range(0, row):
        for y in range(row - x):
            print("*", end="")
        print("")


def drawPiramidTriangleRecurstion(row, col):
    if row == 0:
        return
    if col < row:
        print("*", end="")
        drawPiramidTriangleRecurstion(row, col + 1)
    else:
        print("")
        drawPiramidTriangleRecurstion(row - 1, 0)


drawPiramidTriangleRecurstion(4, 0)


def drawPiramidTriangle2(row):
    for x in range(0, row):
        for y in range(x + 1):
            print("*", end="")
        print("")


def drawPiramidTriangleRecurstion2(row, col):
    if row == 0:
        return
    if col < row:        
        drawPiramidTriangleRecurstion2(row, col + 1)
        print("*", end="")
    else:        
        drawPiramidTriangleRecurstion2(row - 1, 0)
        print("")


drawPiramidTriangleRecurstion2(4, 0)
