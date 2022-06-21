def skipCharacter(oldStr, char, index, newStr):
    if(index == len(oldStr)):
        return newStr
    currentChar = oldStr[index]
    index += 1
    if(currentChar == char):
        return skipCharacter(oldStr, char, index, newStr)
    else:
        newStr += currentChar
        return skipCharacter(oldStr, char, index, newStr)


res = skipCharacter("abaacadhta", 'a', 0, "")
print(res)
