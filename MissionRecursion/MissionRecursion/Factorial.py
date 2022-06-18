def factorial(n):
    if n == 0:
        return 1

    return n * factorial(n - 1)

fact = factorial(5)
print(fact)