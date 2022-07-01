class Solution(object):
    letters = {
        "2": "abc",
        "3": "def",
        "4": "ghi",
        "5": "jkl",
        "6": "mno",
        "7": "pqrs",
        "8": "tuv",
        "9": "wxyz",
    }

    def letterCombinationsRecursive(self, digits, currentIndex, currentCombination, combinationList):
        if len(digits) == len(currentCombination):
            combinationList.append(currentCombination)
            return

        for i in range(0, len(self.letters[digits[currentIndex]])):
            self.letterCombinationsRecursive(
                digits, currentIndex+1, currentCombination+(self.letters[digits[currentIndex]])[i], combinationList)

    def letterCombinations(self, digits):
        if digits == "":
            return []
        combinationList = []
        self.letterCombinationsRecursive(digits, 0, "", combinationList)
        return combinationList