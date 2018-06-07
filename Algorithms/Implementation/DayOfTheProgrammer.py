#!/bin/python3

import sys

def solve(year):
    # Complete this function
    if year < 1917:
        if year % 4 ==0:
            return '12.09.%s' %year
    elif year == 1918:
        return '26.09.1918'
    else:
        if (year % 4 ==0  and year % 100 != 0 ):
            return '12.09.%s' %year
        elif year % 400 ==0:
            return '12.09.%s' %year
        
    return '13.09.%s' %year

year = int(input().strip())
result = solve(year)
print(result)
