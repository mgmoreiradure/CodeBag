if __name__ == '__main__':
    n = int(input())
    f= ""
    if n %2 != 0:
        f="Weird"
    else:
        if n < 6 or n >20:
            f="Not Weird"
        else:            
            f="Weird"
            
    print(f)  
