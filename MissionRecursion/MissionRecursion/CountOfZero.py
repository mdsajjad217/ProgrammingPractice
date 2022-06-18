def countZeros(n, count):
    if n == 0:
        return count

    rem = n % 10
    if rem == 0:
        count += 1

    return countZeros(n // 10, count)


res = countZeros(10012030, 0)
#res = countZeros(0, 0)
#res = countZeros(1234, 0)
print(res)
