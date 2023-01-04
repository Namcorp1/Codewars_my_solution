# Complete the function that accepts a string parameter,
# and reverses each word in the string.
# All spaces in the string should be retained.
# Examples:
# "This is an example!" ==> "sihT si na !elpmaxe"
# "double  spaces"      ==> "elbuod  secaps"

def reverse_words(text):
    result = ""
    count = 0
    letter = 0
    # суть в прогоне по всей строке и при нахождении пробела разворот всего, что было до пробела
    for i in text:
        if i != " ":
            count += 1
            letter += 1
        else:
            stop = letter - 1
            # разворачиваем подстроку до пробела
            for j in range(0, count):
                result += text[stop - j]
            result += " "
            letter += 1
            count = 0
    # отдельно разворот крайней подстроки когда вся строка закончилась.
    stop = letter - 1
    for k in range(0, count):
        result += text[stop - k]
    return result

print(reverse_words("Hello world"))