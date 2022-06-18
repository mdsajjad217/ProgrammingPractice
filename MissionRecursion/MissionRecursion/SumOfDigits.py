def sum(n):
    if n == 0:
        return 0
    return n % 10 + sum(n // 10)


result = sum(1234)
print(result)
