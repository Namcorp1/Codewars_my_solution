# Complete the method/function so that it converts dash/underscore 
# delimited words into camel casing. 
# The first word within the output should be capitalized only 
# if the original word was capitalized (known as Upper Camel Case, 
# also often referred to as Pascal case). 
# The next words should be always capitalized.
# Examples
# "the-stealth-warrior" gets converted to "theStealthWarrior"
# "The_Stealth_Warrior" gets converted to "TheStealthWarrior"

def to_camel_case(text):
    for i in text:
        if i == " " or i == "-" or i == "_":
            text = text.replace(i,'')
        if i.islower():
            i = i.upper()
    return text
result = to_camel_case('The camel_case-test')
print(result)