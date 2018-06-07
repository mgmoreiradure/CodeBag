if __name__ == '__main__':
    n = int(input())
    arr =list(map(int, input().split()))
    
    first = max(arr)
    
    while max(arr) == first:
        arr.remove(first)
   
    print  (max(arr))
