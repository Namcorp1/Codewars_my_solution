# Write a function that when given a URL as a string,
# parses out just the domain name and returns it as a string. For example:
#
# * url = "http://github.com/carbonfive/raygun" -> domain name = "github"
# * url = "http://www.zombie-bites.com"         -> domain name = "zombie-bites"
# * url = "https://www.cnet.com"                -> domain name = "cnet"

def domain_name(url):
    if url[:4] == 'http':
        for i in range(4,len(url)):
            start = 0
            if url[i] == '/' and url[i-1] == '/':
                start = i + 1
                if url[start : (start + 4)] == 'www.':
                    for j in range((start + 4), len(url)):
                        if url[j] == '.':
                            res = url[(start + 4) : j]
                            break
                else:
                    for j in range((start), len(url)):
                        if url[j] == '.':
                            res = url[(start) : j]
                            break
    elif url[:4] == 'www.':
        for j in range(4, len(url)):
            if url[j] == '.':
                res = url[(4) : j]
                break
    else:
        for j in range(0, len(url)):
            if url[j] == '.':
                res = url[(0) : j]
                break
    return res

print(domain_name("https://www.google.ru"))